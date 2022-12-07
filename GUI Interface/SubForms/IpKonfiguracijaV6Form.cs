using MrezneFunkcije.IP;
using MrezneFunkcije.Elevate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using CMDCs;
using System.Runtime.CompilerServices;

namespace GUI_Interface
{
    public partial class IpKonfiguracijaV6Form : Form
    {
        List<IP_konfiguracija.Adapter> MrezniAdapteri { get; set; }
        ToolStripProgressBar progressBar { get; set; }
        ToolStripLabel progressBarLable { get; set; }
        public IpKonfiguracijaV6Form(List<IP_konfiguracija.Adapter> adapters, ToolStripProgressBar progressBarIn, ToolStripLabel progressBarLable)
        {
            this.progressBar = progressBarIn;
            InitializeComponent();
            this.progressBarLable = progressBarLable;
            this.MrezniAdapteri = adapters;
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

            List<IP_konfiguracija.Adapter> MrezniAdapteriSortirani = IP_konfiguracija.DeepCopy<List<IP_konfiguracija.Adapter>>(MrezniAdapteri);

            MrezniAdapteriSortirani.Sort();
            bestAdapter = mrezniInterfaces.FindIndex(a => a.Id.Equals(MrezniAdapteriSortirani[0].AdapterId));
            return bestAdapter;
        }



        private void ToggleAllTextFieldInputs(bool enable)
        {

            ipv6PrefixText.Enabled = enable;

            ipv6Text.Enabled = enable;

            defaultGatewayV6Text.Enabled = enable;
        }

        private void ReDrawTextBoxes()
        {
            int interfaceIndex = this.interfaceComboBox.SelectedIndex;
            string prefix = MrezniAdapteri[interfaceIndex].MrezniPrefixV6;
            ipv6PrefixText.Text = prefix;

            string IP = MrezniAdapteri[interfaceIndex].Ipv6Adresa;
            ipv6Text.Text = IP;

            string defaultGateway = MrezniAdapteri[interfaceIndex].DefaultGatewayV6;
            defaultGatewayV6Text.Text = defaultGateway;

            DhcpCheckBox.Checked = MrezniAdapteri[interfaceIndex].DhcpV6Enabled;
        }


        private void interfaceComboBoxSelectionChanged(object sender, EventArgs e)
        {
            ReDrawTextBoxes();
        }

        private void DhcpCheckChanged(object sender, EventArgs e)
        {
            if (DhcpCheckBox.Checked == true)
            {
                ToggleAllTextFieldInputs(false);
            }
            else
            {
                ToggleAllTextFieldInputs(true);
            }
        }

        private void primjeniPostavkeButton_Click(object sender, EventArgs e)
        {
            string ip = ipv6Text.Text;
            string gateway = defaultGatewayV6Text.Text;
            string prefix = ipv6PrefixText.Text;
            if (gateway == "!") gateway = "";

            if (IP_konfiguracija.IsMaskRange(ip) && prefix == prefix && (IP_konfiguracija.IsMaskRange(gateway) || gateway == "")
               || DhcpCheckBox.Checked)
            {
                MessageBoxButtons gumbi = MessageBoxButtons.YesNo;
                MessageBoxDefaultButton odabranGumb = MessageBoxDefaultButton.Button1;
                MessageBoxIcon slikica = MessageBoxIcon.Question;
                DialogResult messageBoxOdabir = MessageBox.Show("Želiš li promjeniti mrežne postavke računala", "Potvrda mrežnih postavki", gumbi, slikica, odabranGumb);

                if (messageBoxOdabir == DialogResult.No)
                    return;

                int interfaceIndex = this.interfaceComboBox.SelectedIndex;

                int rezultat;

                if (DhcpCheckBox.Checked)
                    rezultat = -2;//IP_konfiguracija.SetDHCPv4(MrezniAdapteri[interfaceIndex].AdapterName);
                else
                    rezultat = -2;//IP_konfiguracija.SetIPv4(MrezniAdapteri[interfaceIndex].AdapterName, ip, mask, gateway);

                if (rezultat == -1)
                {
                    gumbi = MessageBoxButtons.OK;
                    odabranGumb = MessageBoxDefaultButton.Button1;
                    slikica = MessageBoxIcon.Exclamation;
                    MessageBox.Show("Postavljanje mrežnih postavki neuspješno!\nCTRL+E za administratorske ovlasti.", "Potrebne administratorske ovlasti", gumbi, slikica, odabranGumb);
                }
                else if (rezultat == -2)
                {
                    gumbi = MessageBoxButtons.OK;
                    odabranGumb = MessageBoxDefaultButton.Button1;
                    slikica = MessageBoxIcon.Error;
                    MessageBox.Show("Postavljanje mrežnih postavki neuspješno!\nMoguće je da je adapter neaktivan", "Adapter je možda odspojen", gumbi, slikica, odabranGumb);
                }
                else
                {
                    if (!DhcpCheckBox.Checked)
                    {
                        MrezniAdapteri[interfaceIndex].DhcpV6Enabled = !DhcpCheckBox.Checked;
                        MrezniAdapteri[interfaceIndex].DefaultGatewayV6 = gateway;
                        MrezniAdapteri[interfaceIndex].Ipv6Adresa = ip;
                        MrezniAdapteri[interfaceIndex].MrezniPrefixV6 = prefix;
                    }
                    else
                    {
                        MrezniAdapteri = IP_konfiguracija.GetListOfAdapters();
                        Thread upozoriNaAdaptere = new Thread(upozoriOsvjezitAdapter);
                        upozoriNaAdaptere.Start();
                    }
                }

                if (MrezniAdapteri[interfaceIndex].DhcpEnabled == DhcpCheckBox.Checked && MrezniAdapteri[interfaceIndex].DefaultGatewayV4 == gateway
                    && MrezniAdapteri[interfaceIndex].Ipv4Adresa == ip && prefix == prefix)
                {
                    gumbi = MessageBoxButtons.OK;
                    odabranGumb = MessageBoxDefaultButton.Button1;
                    slikica = MessageBoxIcon.Information;
                    MessageBox.Show("Postavljanje mrežnih postavki uspješno!", "Uspjeh", gumbi, slikica, odabranGumb);
                }
            }
            else
            {
                MessageBoxButtons gumbi = MessageBoxButtons.OK;
                MessageBoxDefaultButton odabranGumb = MessageBoxDefaultButton.Button1;
                MessageBoxIcon slikica = MessageBoxIcon.Information;
                MessageBox.Show("Postavljanje mrežnih postavki neuspješno!\nPolja nisu pravilno ispunjena", "Nepotpuni argumenti", gumbi, slikica, odabranGumb);
            }

        }

        private void upozoriOsvjezitAdapter()
        {
            Thread.Sleep(5000);
            progressBarLable.Visible = true;
            progressBarLable.Text = "Preporuča se osvježavanje adaptera (Ctrl+Shift+R)";
        }
    }
}
