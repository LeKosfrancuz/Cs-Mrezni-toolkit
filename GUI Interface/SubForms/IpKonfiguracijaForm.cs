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
        ToolStripProgressBar progressBar { get; set; }
        public IpKonfiguracijaForm(ToolStripProgressBar progressBarIn)
        {
            this.progressBar = progressBarIn;
            InitializeComponent();
        }

        private void IpKonfiguracijaForm_Load(object sender, EventArgs e)
        {
            NetworkInterface[] networkInterfaces = IP_konfiguracija.GetEAdapters();
            int brojAdaptera = networkInterfaces.Count();

            for (int i = 0; i < brojAdaptera; i++)
                this.interfaceComboBox.Items.Add(networkInterfaces[i].Name);

            this.interfaceComboBox.SelectedIndex = GetBestAdapter();
        }

        public int GetBestAdapter()
        {
            int bestAdapter = 0;
            var mrezniInterfaces = IP_konfiguracija.GetEAdapters().ToList();
            List<Adapter> mrezniAdapteri = new List<Adapter> { new Adapter(mrezniInterfaces[0], 0) };
            progressBar.Value = 0;
            progressBar.Visible = true;
            for (int i = 0; i < mrezniInterfaces.Count(); i++)
            {
                mrezniAdapteri.Add(new Adapter(mrezniInterfaces[i], 0));
                string imeAdaptera = mrezniAdapteri[i].AdapterObjekt.Name;
                if (IP_konfiguracija.GetIP(imeAdaptera) != "Nepoznata") mrezniAdapteri[i].BrojDobrihKvaliteta++;
                if (IP_konfiguracija.GetIP(imeAdaptera, 6) != "Nepoznata") mrezniAdapteri[i].BrojDobrihKvaliteta++;
                if (IP_konfiguracija.GetMask(imeAdaptera) != "") mrezniAdapteri[i].BrojDobrihKvaliteta++;
                if (IP_konfiguracija.GetMask(imeAdaptera, 6) != "") mrezniAdapteri[i].BrojDobrihKvaliteta++;
                if (IP_konfiguracija.GetDfltGateway(imeAdaptera).Contains(".")) mrezniAdapteri[i].BrojDobrihKvaliteta++;
                this.progressBar.Value = (int)(100.0 * ((i + 1.0) / mrezniInterfaces.Count()));
                if (mrezniAdapteri[i].BrojDobrihKvaliteta >= 4) break;
            }

            this.progressBar.Value = 100;
            
            mrezniAdapteri.Sort();
            bestAdapter = mrezniInterfaces.IndexOf(mrezniAdapteri[0].AdapterObjekt);

            progressBar.Visible = false;
            progressBar.Value = 0;
            return bestAdapter;
        }
        private class Adapter : IComparable<Adapter>
        {
            public int BrojDobrihKvaliteta { get; set; }
            public NetworkInterface AdapterObjekt { get; set; }

            public Adapter(NetworkInterface adapterObjekt, int brojDobrihKvaliteta)
            {
                AdapterObjekt = adapterObjekt;
                BrojDobrihKvaliteta = brojDobrihKvaliteta;
            }

            public int CompareTo(Adapter? other)
            {
                if (this.BrojDobrihKvaliteta < other.BrojDobrihKvaliteta) return 1;
                return -1;
                throw new NotImplementedException();
            }
        }

        private void ToggleAllTextFieldInputs(bool enable)
        {
            mreznaMaskaText1.Enabled = enable;
            mreznaMaskaText2.Enabled = enable;
            mreznaMaskaText3.Enabled = enable;
            mreznaMaskaText4.Enabled = enable;

            ipv4Text4.Enabled = enable;
            ipv4Text1.Enabled = enable;
            ipv4Text2.Enabled = enable;
            ipv4Text3.Enabled = enable;
        }

        private void ReDrawTextBoxes()
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

            if (DhcpCheckBox.Checked == true)
            {
                ToggleAllTextFieldInputs(false);
            } else
            {
                ToggleAllTextFieldInputs(true);
            }
        }


        private void interfaceComboBoxSelectionChanged(object sender, EventArgs e)
        {
            ReDrawTextBoxes();
        }

        private void DhcpCheckChanged(object sender, EventArgs e)
        {
            ReDrawTextBoxes();
        }
    }
}
