using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using Microsoft.VisualBasic;
using MrezneFunkcije.IP;

class Program
{ 
    static void Main ()
    {
        int k = 1;
        var b = IP_konfiguracija.GetEAdapters();
        foreach (var bEl in b)
        {
            Console.WriteLine("[" + k + "] " + bEl.Name);
            k++;
        }

        Console.Write("Odaberi adapter: ");
        int odabir = (int)double.Parse(Console.ReadLine());

        var a = IP_konfiguracija.GetIP(b[odabir-1].Name);

        Console.Write($"Na adapteru {b[odabir-1].Name} je IPv4 adresa: {a}{IP_konfiguracija.GetMask(b[odabir - 1].Name)}\n");

        a = IP_konfiguracija.GetIP(b[odabir - 1].Name, 6);
        Console.Write($"Na adapteru {b[odabir - 1].Name} je IPv6 adresa: {a}{IP_konfiguracija.GetMask(b[odabir - 1].Name, 6)}\n");

        Console.WriteLine($"DHCP enabled: {IP_konfiguracija.GetDHCP(b[odabir - 1].Name)}");



    }
}