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
        var adapter = b[odabir-1];

        var a = IP_konfiguracija.GetIP(adapter.Name);

        Console.Write($"Na adapteru {adapter.Name} je IPv4 adresa: {a}{IP_konfiguracija.GetMask(adapter.Name)}\n");
        Console.Write($"Mrežna maska je: {IP_konfiguracija.ConvertPrefixToMask(IP_konfiguracija.GetMask(adapter.Name))}\n");
        Console.Write($"Gateway: {IP_konfiguracija.GetDfltGateway(adapter.Name)}\n");

        a = IP_konfiguracija.GetIP(adapter.Name, 6);
        Console.Write($"Na adapteru {adapter.Name} je IPv6 adresa: {a}{IP_konfiguracija.GetMask(adapter.Name, 6)}\n");
        Console.Write($"Mrežna maska je: {IP_konfiguracija.ConvertPrefixToMask(IP_konfiguracija.GetMask(adapter.Name, 6), 6)}\n");

        Console.WriteLine($"DHCP enabled: {IP_konfiguracija.GetDHCP(adapter.Name)}");


        Console.WriteLine("\n");
        Console.Write($"Upiši novu IP adresu za adapter {adapter.Name}: ");
        string newIP = Console.ReadLine();
        Console.Write($"Upiši prefix adrese za adapter {adapter.Name}: ");
        string prefix = "/" + Console.ReadLine();
        Console.Write($"Upiši novi default gateway za adapter {adapter.Name}: ");
        string gateway = Console.ReadLine();

        int r = IP_konfiguracija.SetIPv4(adapter.Name, newIP, IP_konfiguracija.ConvertPrefixToMask(prefix), gateway);
        if (r == -2) Console.WriteLine("Potrebne su administratorske ovlasti!");
        else if (r == -1) Console.WriteLine("Greška pri unosu podataka!");
        else Console.WriteLine("Adresa uspješno promjenjena!");




    }
}