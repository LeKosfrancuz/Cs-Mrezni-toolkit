using MrezneFunkcije.IP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Interface.SubForms
{
    public partial class KompresorIPv6AdresaForm : Form
    {
        public KompresorIPv6AdresaForm()
        {
            InitializeComponent();
        }

        private void DeKompres_KeyUp(object sender, KeyEventArgs e)
        {
            string ipAdresaCommpresed = IP_konfiguracija.GetCommpresedIPv6(ipv6DeCompresed.Text);
            if (ipAdresaCommpresed == "") return;

            ipv6Compresed.Text = ipAdresaCommpresed;
        }

        private void Kompress_KeyUP(object sender, KeyEventArgs e)
        {
            string ipAdresaDeCommpresed = IP_konfiguracija.GetUnCommpresedIPv6(ipv6Compresed.Text);
            if (ipAdresaDeCommpresed == "") return;

            ipv6DeCompresed.Text = ipAdresaDeCommpresed;
        }
    }
}
