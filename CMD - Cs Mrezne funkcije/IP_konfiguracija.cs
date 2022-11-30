﻿using CMDCs;
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
                    CMDoutput = CMD.Command($"netsh interface ipv{verzijaProtokola} show addresses");
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


            string[] cmdOutputSplit = CMDoutput.Split("Configuration for interface");
            int numberOfAdaptersFound = cmdOutputSplit.Count();

            int indeksOdabranogAdaptera = -1;
            for (int i = 0; i < numberOfAdaptersFound; i++)
                if (cmdOutputSplit[i].Contains(imeAdaptera))
                {
                    indeksOdabranogAdaptera = i;
                    break;
                }
            if (indeksOdabranogAdaptera == -1) return false;


            string[] s = cmdOutputSplit[indeksOdabranogAdaptera].Split("\r\n");

            if (s[1].Contains("Yes")) return true;
            return false;

        }
    }
}