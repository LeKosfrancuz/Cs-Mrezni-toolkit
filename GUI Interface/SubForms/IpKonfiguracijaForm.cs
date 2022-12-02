using MrezneFunkcije.IP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Interface
{
    public partial class IpKonfiguracijaForm : Form
    {
        public IpKonfiguracijaForm()
        {
            InitializeComponent();
        }

        private void IpKonfiguracijaForm_Load(object sender, EventArgs e)
        {
            NetworkInterface[] networkInterfaces = IP_konfiguracija.GetEAdapters();
            int brojAdaptera = networkInterfaces.Count();

            for (int i = 0; i < brojAdaptera; i++)
                this.interfaceComboBox.Items.Add(networkInterfaces[i].Name);
        }


        private void interfaceComboBoxSelectionChanged(object sender, EventArgs e)
        {
            NetworkInterface[] networkInterfaces = IP_konfiguracija.GetEAdapters();
            int interfaceIndex = this.interfaceComboBox.SelectedIndex;
            string prefixNumber = IP_konfiguracija.GetMask(networkInterfaces[interfaceIndex].Name);
            string maska = IP_konfiguracija.ConvertPrefixToMask(prefixNumber);
            (mreznaMaskaText1.Text, mreznaMaskaText2.Text, mreznaMaskaText3.Text, mreznaMaskaText4.Text) 
                = IP_konfiguracija.SeperateMask(maska);

            string IP = IP_konfiguracija.GetIP(networkInterfaces[interfaceIndex].Name);
            (ipv4Text1.Text, ipv4Text2.Text, ipv4Text3.Text, ipv4Text4.Text)
                = IP_konfiguracija.SeperateMask(IP);
        }
    }
}
