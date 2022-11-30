using CMDCs;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters;

namespace MrezneFunkcije.IP
{
    public static class IP_konfiguracija
    {
        public static NetworkInterface[] GetEAdapters()
        {
            return NetworkInterface.GetAllNetworkInterfaces();
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
            string CMDoutput = CMD.Command("ipconfig | findstr \"Ethernet Adapter\"");
            string IP = "";

            int nBSN = -1; // Jer je zadnji char uvijek \n
            foreach (char c in CMDoutput)
                    if (c == '\n') nBSN++;

            if (imeAdaptera == "")
            return "Nije specificirana mrežna kartica";

            if (nBSN == 1)
                CMDoutput = CMD.Command($"ipconfig | findstr \"IPv{verzijaProtokola}\"");
            else
            {
                CMDoutput = CMD.Command($"ipconfig");

                string[] cmdOutputSplit = CMDoutput.Split("adapter");
                int numberOfAdaptersFound = cmdOutputSplit.Count();

                int indeksOdabranogAdaptera = -1;
                for (int i = 0; i < numberOfAdaptersFound; i++)
                    if (cmdOutputSplit[i].Contains(imeAdaptera))
                    {
                        indeksOdabranogAdaptera = i;
                        break;
                    }
                if (indeksOdabranogAdaptera == -1)
                {
                    CMDoutput = CMD.Command($"netsh interface ipv{verzijaProtokola} show addresses \"{imeAdaptera}\"");
                    if (CMDoutput.Contains(imeAdaptera)) return "Adapter je pronađen, ali ipconfig ne dopušta konfiguraciju";

                    return "Nije pronađen mrežni adapter!"; 
                }


                string[] s = cmdOutputSplit[indeksOdabranogAdaptera].Split(": ");

                for (int i = 1; i < s.Count()-1; i++)
                if (s[i-1].Contains($"IPv{verzijaProtokola}"))
                {
                    IP = s[i].Split('\r')[0];
                }

            }

            if (IP == "") return "Nepoznata";
            return IP;
        }

        public static bool GetDHCP(string imeAdaptera = "", int verzijaProtokola = 4)
        {
            if (verzijaProtokola != 4) return false;
            string CMDoutput = CMD.Command("netsh interface ipv4 show addresses");
            string IP = "";

            int nBSN = -1; // Jer je zadnji char uvijek \n
            foreach (char c in CMDoutput)
                if (c == '\n') nBSN++;

            if (imeAdaptera == "")
                return false;

            string[] s = CMDoutput.Split("\r\n");

            if (s.Count() >= 3 && s[2].Contains("Yes")) return true;
            return false;

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

        public static int SetIPv4() { return 0;  }
    }
}


