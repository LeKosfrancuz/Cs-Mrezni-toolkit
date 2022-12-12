using CMDCs;
using Newtonsoft.Json.Serialization;
using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace MrezneFunkcije.IP
{
    public static class IP_konfiguracija
    {
        public static NetworkInterface[] a = GetEAdapters();

        public static NetworkInterface[] GetEAdapters()
        {
            return NetworkInterface.GetAllNetworkInterfaces();
        }

        public static NetworkInterface GetEAdapters(int index)
        {
            return NetworkInterface.GetAllNetworkInterfaces()[index];
        }

        [Serializable]
        public class Adapter : IComparable<Adapter>
        {
            public int BrojDobrihKvaliteta { get; set; }
            public string AdapterName { get; set; }
            public string AdapterId { get; set; }
            public string Ipv4Adresa { get; set; }
            public string Ipv6Adresa { get; set; }
            public string MreznaMaskaV4 { get; set; }
            public string MrezniPrefixV4 { get; set; }
            public string MrezniPrefixV6 { get; set; }
            public string DefaultGatewayV4 { get; set; }
            public string DefaultGatewayV6 { get; set; }
            public bool DhcpEnabled { get; set; }
            public bool DhcpV6Enabled { get; set; }

            public Adapter(NetworkInterface adapterObjekt, int brojDobrihKvaliteta)
            {
                AdapterName = adapterObjekt.Name;
                AdapterId = adapterObjekt.Id;
                BrojDobrihKvaliteta = brojDobrihKvaliteta;
                this.Ipv4Adresa = "";
                this.Ipv6Adresa = "";
                this.MreznaMaskaV4 = "";
                this.MrezniPrefixV4 = "";
                this.MrezniPrefixV6 = "";
                this.DefaultGatewayV4 = "";
                this.DefaultGatewayV6 = "";
                this.DhcpEnabled = false;
                this.DhcpV6Enabled = false;
            }
            public int CompareTo(Adapter? other)
            {
                if (other == null) return 1;
                if (this.BrojDobrihKvaliteta < other.BrojDobrihKvaliteta) return 1;
                return -1;
                throw new NotImplementedException();
            }
        }


        public static List<Adapter> GetListOfAdapters()
        {
            var mrezniInterfaces = IP_konfiguracija.GetEAdapters().ToList();
            List<Adapter> mrezniAdapteri = new List<Adapter> { new Adapter(mrezniInterfaces[0], 0) };
            mrezniAdapteri.RemoveAt(0);

            List<Thread> listaUpdateThreads = new List<Thread>();

            Span<NetworkInterface> listaInterfaceaKaoSpan = CollectionsMarshal.AsSpan(mrezniInterfaces);
            for (int i = 0; i < listaInterfaceaKaoSpan.Length; i++)
            {
                mrezniAdapteri.Add(new Adapter(listaInterfaceaKaoSpan[i], 0));

                Thread updateThread = new Thread(() => updateMrezniAdapter(mrezniAdapteri, i));
                listaUpdateThreads.Add(updateThread);
                listaUpdateThreads[i].Start();
                Thread.Sleep(10);
                //progressBar.Value = (int)(100.0 * ((i + 1.0) / mrezniInterfaces.Count()));
            }

            bool isAlive = false;
            
            while (!isAlive)
            {
                isAlive = listaUpdateThreads.All(item => item.IsAlive == false);
            } 

                return mrezniAdapteri;
        }

        public static void updateMrezniAdapter(List<Adapter> mrezniAdapteri, int i)
        {
            if (i >= mrezniAdapteri.Count) return;
            string imeAdaptera = mrezniAdapteri[i].AdapterName;

            mrezniAdapteri[i].Ipv4Adresa = GetIP(imeAdaptera);
            if (mrezniAdapteri[i].Ipv4Adresa != "Nepoznata") mrezniAdapteri[i].BrojDobrihKvaliteta++;
            else mrezniAdapteri[i].Ipv4Adresa = "!";

            mrezniAdapteri[i].Ipv6Adresa = GetIP(imeAdaptera, 6);
            if (mrezniAdapteri[i].Ipv6Adresa != "Nepoznata") mrezniAdapteri[i].BrojDobrihKvaliteta++;
            else mrezniAdapteri[i].Ipv6Adresa = "!";

            mrezniAdapteri[i].MrezniPrefixV4 = GetMask(imeAdaptera);
            mrezniAdapteri[i].MreznaMaskaV4 = ConvertPrefixToMask(mrezniAdapteri[i].MrezniPrefixV4);
            if (mrezniAdapteri[i].MrezniPrefixV4 != "") mrezniAdapteri[i].BrojDobrihKvaliteta++;
            else mrezniAdapteri[i].MreznaMaskaV4 = "!";

            mrezniAdapteri[i].MrezniPrefixV6 = GetMask(imeAdaptera, 6);
            if (mrezniAdapteri[i].MrezniPrefixV6 != "") mrezniAdapteri[i].BrojDobrihKvaliteta++;
            else mrezniAdapteri[i].MrezniPrefixV6 = "!";

            mrezniAdapteri[i].DefaultGatewayV4 = GetDfltGateway(imeAdaptera);
            if (mrezniAdapteri[i].DefaultGatewayV4.Contains(".")) mrezniAdapteri[i].BrojDobrihKvaliteta++;

            mrezniAdapteri[i].DhcpEnabled = GetDHCP(imeAdaptera);
            mrezniAdapteri[i].DhcpV6Enabled = GetDHCP(imeAdaptera, 6);
        }

        public static IPAddress[] GetIPs(bool? IPv4Only)
        {
            if (IPv4Only == null) IPv4Only = false;

            IPAddress[] IPs = Dns.GetHostAddresses(Dns.GetHostName());
            if ((bool)IPv4Only)
            {
                List<IPAddress> IPv4s = new List<IPAddress>{ IPAddress.None };
                IPv4s.RemoveAt(0);
                foreach (var IP in IPs)
                    if (IP.AddressFamily == AddressFamily.InterNetwork)
                    {
                        IPv4s.Add(IP);
                    }

                IPAddress[] IPv4sPolje = IPv4s.ToArray();

                return IPv4sPolje;
            }
            return IPs;
        }


        public static string GetIP(string imeAdaptera = "", int verzijaProtokola = 4)
        {
            string CMDoutput = CMD.Command($"netsh interface ipv{verzijaProtokola} show addresses \"{imeAdaptera}\"");
            string IP = "";

            int nBSN = -1; // Jer je zadnji char uvijek \n
            foreach (char c in CMDoutput)
                    if (c == '\n') nBSN++;

            if (imeAdaptera == "")
            return "Nije specificirana mrežna kartica";


            if (verzijaProtokola == 4)
            {
                string[] s = CMDoutput.Split(":");

                for (int i = 1; i < s.Count() - 1; i++)
                {
                    if (s[i - 1].Contains($"IP Address"))
                    {
                        var IPSpaces = s[i].Split('\r')[0].Split(" ");      //Uzme desni dio od nove linije (ip adresa) i podjeli stringove po razmacima
                        IP = IPSpaces[IPSpaces.Length - 1];                 //Ip adresa je zadnja jer je djeljeno po razmacima a u ipv4 nema razmaka
                    }

                }
            }
            else if (verzijaProtokola == 6 && CMDoutput.Length > 25)
            {
                string ipv6SaId = CMDoutput.Split("Address")[1].Split(" ")[1];
                IP = ipv6SaId.Split("%")[0];
            }
            if (IP == "") return "Nepoznata";
            return IP;
        }

        public static bool GetDHCP(string imeAdaptera = "", int verzijaProtokola = 4)
        {
            if (verzijaProtokola == 4)
            {
                string CMDoutput = CMD.Command($"netsh interface ipv4 show addresses \"{imeAdaptera}\"");

                int nBSN = -1; // Jer je zadnji char uvijek \n
                foreach (char c in CMDoutput)
                    if (c == '\n') nBSN++;

                if (imeAdaptera == "")
                    return false;

                string[] adapterAtributes = CMDoutput.Split("\r\n");

                if (adapterAtributes.Count() >= 3 && adapterAtributes[2].Contains("Yes")) return true;
                return false;
            } else
            {
                string CMDoutput = CMD.Command($"netsh interface ipv6 show interfaces \"{imeAdaptera}\"");
                int nBSN = -1; // Jer je zadnji char uvijek \n
                foreach (char c in CMDoutput)
                    if (c == '\n') nBSN++;

                if (imeAdaptera == "")
                    return false;

                string[] adapterAtributes = CMDoutput.Split("\r\n");
                for (int i = 0; i < adapterAtributes.Length; i++)
                    if (adapterAtributes[i].Contains("DHCP")) 
                    {
                        if (adapterAtributes[i].Contains("enabled")) return true;
                        else return false;
                    }
            }

            return false;

        }

        public static int GetInterfaceId (string InterfaceName = "")
        {
            string CMDoutput = CMD.Command($"netsh interface ipv6 show interfaces \"{InterfaceName}\"");
            int nBSN = -1; // Jer je zadnji char uvijek \n
            foreach (char c in CMDoutput)
                if (c == '\n') nBSN++;

            if (InterfaceName == "")
                return 0;

            string[] adapterAtributes = CMDoutput.Split("\r\n");
            for (int i = 0; i < adapterAtributes.Length; i++)
                if (adapterAtributes[i].Contains("IfIndex"))
                {
                    return int.Parse(adapterAtributes[i].Split(": ")[1].Split("\r")[0]);
                }

            return 0;
        }

        public static string GetMask(string imeAdaptera = "", int verzijaProtokola = 4)
        {
            string komanda;
            if (verzijaProtokola == 6) komanda = $"netsh interface ipv6 show interface \"{imeAdaptera}\"";
            else if (verzijaProtokola == 4) komanda = $"netsh interface ipv4 show addresses \"{imeAdaptera}\"";
            else return "Nepoznat protokol!";

            string CMDOutput = CMD.Command(komanda);
            string subnetPrefix = "";

            if (verzijaProtokola == 4 && CMDOutput.Split("/").Count() >= 2) subnetPrefix = "/" + CMDOutput.Split("/")[1].Split(" ")[0];
            else if (verzijaProtokola == 6)
            {
                string[] CMDOutLinije = CMDOutput.Split("\r\n");
                for (int i = 0; i < CMDOutLinije.Count(); i++)
                {
                    if (CMDOutLinije[i].Contains("Site Prefix Length"))
                    {
                        subnetPrefix = "/" + CMDOutLinije[i].Split(": ")[1].Split("\r\n")[0];
                    }
                }
            }

            return subnetPrefix;

        }

        public static (string, string, string, string) SeperateMask(string mask)
        {
            string[] maskSplit = mask.Split('.', 4);

            if (maskSplit.Length >= 4)
            return (maskSplit[0], maskSplit[1], maskSplit[2], maskSplit[3]);

            return ("", "", "", "");
        }

        public static string GetDfltGateway(string imeAdaptera = "", int verzijaProtokola = 4)
        {
            string CMDOutput = CMD.Command("ipconfig /all");
            string gateway = "";

            int nBSN = -1; // Jer je zadnji char uvijek \n
            foreach (char c in CMDOutput)
                if (c == '\n') nBSN++;

            if (imeAdaptera == "")
                return "";

            CMDOutput = CMD.Command($"ipconfig");

            string[] cmdOutputSplit = CMDOutput.Split("adapter");
            int numberOfAdaptersFound = cmdOutputSplit.Count();

            int indeksOdabranogAdaptera = -1;
            for (int i = 0; i < numberOfAdaptersFound; i++)
                if (cmdOutputSplit[i].Contains(imeAdaptera))
                {
                    indeksOdabranogAdaptera = i;
                    break;
                }
            if (indeksOdabranogAdaptera == -1) return "";


            string[] s = cmdOutputSplit[indeksOdabranogAdaptera].Split(": ");

            for (int i = 1; i < s.Count(); i++)
                if (s[i - 1].Contains($"Default Gateway"))
                {
                    gateway = s[i].Split('\r')[0];
                }

            return gateway;
        }

        public static string ConvertPrefixToMask(string prefix, int verzijaProtokola = 4)
        {
            if (prefix == null || prefix == "") return "Nepoznata";
            string mask = "";

            if (verzijaProtokola == 4)
            {
                uint maskInt = 0xffffffff;

                int prefixNum = 32 - int.Parse(prefix.Split("/")[1]);


                maskInt = maskInt >> prefixNum -1 >> 1 << prefixNum -1 << 1;


                for (int i = 0; i < 4; i++)
                {
                    if (i != 0) mask += ".";
                    uint bytemm =
                        (maskInt & 0xff000000) >> 32-8;
                    mask += bytemm.ToString();
                    maskInt <<= 8;
                }

            } else if (verzijaProtokola == 6)
            {
                UInt64 maskInt1 = UInt64.Parse("ffffffffffffffff", System.Globalization.NumberStyles.AllowHexSpecifier);
                UInt64 maskInt2 = UInt64.Parse("ffffffffffffffff", System.Globalization.NumberStyles.AllowHexSpecifier);

                int prefixNum = 128 - int.Parse(prefix.Split("/")[1]);

                int prefixNum2 = 0;


                maskInt2 = maskInt2 >> prefixNum -1 >> 1 << prefixNum -1 << 1;
                if (prefixNum > 64)
                {
                    prefixNum2 = prefixNum - 64;
                    maskInt1 = maskInt1 >> prefixNum2 - 1 >> 1 << prefixNum2 - 1 << 1;
                }


                for (int i = 0; i < 16; i++)
                {
                    if (i == 8) maskInt1 = maskInt2;
                    if (i != 0) mask += ".";
                    UInt64 bytemm =
                        (maskInt1 & UInt64.Parse("ff", System.Globalization.NumberStyles.AllowHexSpecifier) << 56) >> 64 - 8;
                    mask += bytemm.ToString();
                    maskInt1 <<= 8;
                }
            }

            return mask;
        }

        public static string ConvertMaskToPrefix(string mask) 
        {
            string prefix = "!";
            if (IsMaskRange(mask))
            {
                string[] maskSplit = mask.Split(".");
                uint octet1 = uint.Parse(maskSplit[0]);
                uint octet2 = uint.Parse(maskSplit[1]);
                uint octet3 = uint.Parse(maskSplit[2]);
                uint octet4 = uint.Parse(maskSplit[3]);

                int numberOfSetBits = 0;
                uint tempOctet = 0;
                bool endOdOnes = false;
                for (int i = 0; i < 32; i++)
                {
                    switch(i)
                    {
                        case 0: tempOctet = octet1; break;
                        case 8: tempOctet = octet2; break;
                        case 16: tempOctet = octet3; break;
                        case 24: tempOctet = octet4; break;
                        default: break;
                    }
                    
                    uint tempBit = tempOctet & 0x80;
                    tempBit >>= 7;
                    if (tempBit == 1 && endOdOnes == true) return prefix;
                    else if (endOdOnes == false && tempBit == 0) endOdOnes = true;

                    numberOfSetBits += (int)tempBit;

                    tempOctet <<= 1;
                }

                prefix = "/" + numberOfSetBits;

            }
            return prefix;
        }

        public static bool IsMaskRange(string mask)
        {
                string[] maskaSplit = mask.Split(".");
                if (maskaSplit.Length != 4) return false;

                if (int.TryParse(maskaSplit[0], out int octet1) && int.TryParse(maskaSplit[1], out int octet2) 
                    && int.TryParse(maskaSplit[2], out int octet3) && int.TryParse(maskaSplit[3], out int octet4))
                {
                    if (octet1 >= 0 && octet2 >= 0 && octet3 >= 0 && octet4 >= 0 && octet1 <= 255 && octet2 <= 255 && octet3 <= 255 && octet4 <= 255)
                        return true;
                }
                
                return false;
        }

        public static bool IsMask(string mask)
        {
            if (ConvertMaskToPrefix(mask) != "!") return true;
            else return false;
        }

        public static int SetIPv4(string InterfaceName, string NewIP, string SubnetMask, string Gateway) {
            if (SubnetMask == "Nepoznata") return -2;
            string CMDOutput = CMD.Command($"netsh interface ipv4 set address name=\"{InterfaceName}\" static {NewIP} {SubnetMask} {Gateway}");
            if (CMDOutput.Contains("Run as admin")) return -1;
            if (CMDOutput.Contains("The interface may be disconnected")) return -2;
            return 0;  
        }

        public static int SetDHCPv4(string InterfaceName)
        {
            string CMDoutput = CMD.Command($"netsh interface ip set address \"{InterfaceName}\" dhcp");
            if (CMDoutput.Contains("Run as admin")) return -1;
            if (CMDoutput.Contains("The interface may be disconnected")) return -2;
            return 0;
        }

        public static string GetIPv6ForAdapter(string InterfaceName) 
        {
            string output = CMD.Command($"netsh interface ipv6 show addresses \"{InterfaceName}\"");

            return output;
        }

        public static string GetIPv6GatewayForAdapter(string InterfaceName, bool displayHeader = true)
        {
            string output = CMD.Command($"netsh interface ipv6 show route | findstr /C:\" {GetInterfaceId(InterfaceName)} \"");
            
            if (displayHeader)
            output = "Publish  Type      Met  Prefix                      Idx  Gateway/Interface Name\r\n--------  -------     ----  -----------------------  ---  ------------------------\r\n" + output;

            return output;
        }

        public static string GetIPv6DNSForAdapter(string InterfaceName)
        {
            string output = CMD.Command($"netsh interface ipv6 show dnsserver \"{InterfaceName}\"");

            return output;
        }

        public static int SetIPv6(string InterfaceName, string IPv6, bool Add, string? type="unicast", string? validlife = "infinite", string? preferedlife = "infinite", string? store = "persistent", string? skip = "false")
        {
            string addRemove = Add ? "add" : "delete";
            if (type == null) type = "";
            if (validlife == null) validlife = "";
            if (preferedlife == null) preferedlife = "";
            if (store == null) store = "";
            if (skip == null) skip = "";

            string CMDOutput = CMD.Command($"netsh interface ipv6 {addRemove} address \"{InterfaceName}\" {IPv6} {type} {validlife} {preferedlife} {store} {skip}");

            if (CMDOutput.Contains("Run as admin")) return -1;
            if (CMDOutput.Contains("The object already exists.")) return -2;
            if (CMDOutput.Contains("The parameter is incorrect.")) return -3;
            if (CMDOutput.Contains("It should be a valid IPv6 address.")) return -4;

            return 0;
        }

        public static (int, int) GetPrecedenceLabelIPv6(string IPv6)
        {
            string CMDOutput = CMD.Command($"netsh interface ipv6 show prefixpolicies | findstr /C:\"{IPv6}\"");


            return (0, 0);
        }

        public static double ConvertTimeFieldToDoubleSekunde(decimal dani, decimal sati, decimal minute, decimal sekunde, bool infinite)
        {
            if (infinite) return double.PositiveInfinity;

            double rjesenje = (double)(dani * 24 * 60 * 60 + sati * 60 * 60 + minute * 60 + sekunde);

            return rjesenje;
        }

        public static bool IsValidLifeSpanIPv6(double ValidTime, double PreferedTime)
        {
            if (ValidTime == double.NaN || PreferedTime == double.NaN) return false;

            if (PreferedTime > ValidTime) return false;
            
            return true;
        }

        public static int SetDefaultGatewayV6(string InterfaceName, string IPv6, bool Add) 
        {
            string addRemove = Add ? "add" : "delete";
            string CMDOutput = CMD.Command($"netsh interface ipv6 {addRemove} route ::/0 \"{InterfaceName}\" {IPv6}");

            if (CMDOutput.Contains("Ok.")) return 0;
            
            if (CMDOutput.Contains("Run as admin")) return -1;

            if (CMDOutput.Contains("It should be a valid IPv6 address.")) return -3;
            return -2;
        }

        public static int SetDnsIPv6(string InterfaceName, string IPv6, bool Add, string? prefix) 
        {
            string addRemove = Add ? "add" : "delete";

            string prefixNum = "";
            if (prefix != null)
            prefixNum = prefix.Split("/")[1];

            string CMDOutput = CMD.Command($"netsh interface ipv6 {addRemove} dns \"{InterfaceName}\" {IPv6} {prefixNum} no");

            if (CMDOutput.Contains("Run as admin")) return -1;
            if (CMDOutput.Contains("DNS server is incorrect")) return -2;
            if (CMDOutput.Contains("It should be a valid IPv6 address.")) return -3;

            return 0;
        }

        public static string GetCommpresedIPv6(string IPv6)
        {
            string[] ipSplit = IPv6.Split(":");

            if (ipSplit.Length != 8) return "";
            if (ipSplit[7] == "") return "";

            int brojacNula = 0;
            int maxNula = 0;
            int indexZavrsne = 0;
            for (int i = 0; i < 8; i++)
            {
                int temp;
                try
                {
                    temp = int.Parse(ipSplit[i], System.Globalization.NumberStyles.HexNumber);
                } catch (FormatException) { return ""; }
                ipSplit[i] = temp.ToString("x");
            }


            IPv6 = "";
            for (int i = 0; i < ipSplit.Length; i++)
            {
                if (i != 0) IPv6 += ":";
                IPv6 += ipSplit[i];
            }

            return IPAddress.Parse(IPv6).ToString();
        }

        public static string GetUnCommpresedIPv6(string IPv6)
        {
            IPAddress adresa;
            if (IPAddress.TryParse(IPv6, out adresa))
            {
                if (adresa.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6)
                {
                    var bytes = adresa.GetAddressBytes();
                    var unCommpresedAddress = string.Format("{0:x2}{1:x2}:{2:x2}{3:x2}:{4:x2}{5:x2}:{6:x2}{7:x2}:{8:x2}{9:x2}:{10:x2}{11:x2}:{12:x2}{13:x2}:{14:x2}{15:x2}", bytes[0], bytes[1], bytes[2], bytes[3], bytes[4], bytes[5], bytes[6], bytes[7], bytes[8], bytes[9], bytes[10], bytes[11], bytes[12], bytes[13], bytes[14], bytes[15]);
                    Console.WriteLine(unCommpresedAddress);

                    return unCommpresedAddress;
                }
            }

            return "";
        }

        public static T DeepCopy<T>(T item)
        {
#pragma warning disable SYSLIB0011
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream stream = new MemoryStream();
            if (item == null) throw new ArgumentNullException(nameof(item), "Argument funkcije DeepCopy ne smije biti NULL!");
            formatter.Serialize(stream, item);
            stream.Seek(0, SeekOrigin.Begin);
            T result = (T)formatter.Deserialize(stream);
            stream.Close();
            return result;
#pragma warning restore SYSLIB0011
        }

        public static void OpenUrl(string url) 
            //Funkcija kopirana sa https://stackoverflow.com/questions/4580263/how-to-open-in-default-browser-in-c-sharp
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }
    }
}


namespace MrezneFunkcije.Elevate
{
    public static class Elevate
    {
        public static Process ElevateProcess()
        {
            Process source = Process.GetCurrentProcess();

            //Create a new process
            Process target = new Process();
            //target.StartInfo = source.StartInfo;
            target.StartInfo.FileName = source.MainModule.FileName;
            target.StartInfo.WorkingDirectory = Path.GetDirectoryName(source.MainModule.FileName);

            //Required for UAC to work
            target.StartInfo.UseShellExecute = true;
            target.StartInfo.Verb = "runas";

            try
            {
                if (!target.Start())
                    return null;
            }
            catch (Win32Exception e)
            {
                //Cancelled
                if (e.NativeErrorCode == 1223)
                    return null;
                throw;
            };
            return target;
        }
    }
}


