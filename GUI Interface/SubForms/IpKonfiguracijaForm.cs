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
    public partial class IpKonfiguracijaForm : Form
    {
        List<IP_konfiguracija.Adapter> MrezniAdapteri { get; set; }
        ToolStripProgressBar progressBar { get; set; }
        ToolStripLabel progressBarLable { get; set; }
        public IpKonfiguracijaForm(List<IP_konfiguracija.Adapter> adapters, ToolStripProgressBar progressBarIn, ToolStripLabel progressBarLable)
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
            mreznaMaskaText1.Enabled = enable;
            mreznaMaskaText2.Enabled = enable;
            mreznaMaskaText3.Enabled = enable;
            mreznaMaskaText4.Enabled = enable;

            ipv4PrefixText.Enabled = enable;

            ipv4Text4.Enabled = enable;
            ipv4Text1.Enabled = enable;
            ipv4Text2.Enabled = enable;
            ipv4Text3.Enabled = enable;

            defaultGatewayText1.Enabled = enable;
            defaultGatewayText2.Enabled = enable;
            defaultGatewayText3.Enabled = enable;
            defaultGatewayText4.Enabled = enable;
        }

        private void ReDrawTextBoxes()
        {
            int interfaceIndex = this.interfaceComboBox.SelectedIndex;
            string prefix = MrezniAdapteri[interfaceIndex].MrezniPrefixV4;
            string maska = MrezniAdapteri[interfaceIndex].MreznaMaskaV4;
            (mreznaMaskaText1.Text, mreznaMaskaText2.Text, mreznaMaskaText3.Text, mreznaMaskaText4.Text)
                = IP_konfiguracija.SeperateMask(maska);
            ipv4PrefixText.Text = prefix;

            string IP = MrezniAdapteri[interfaceIndex].Ipv4Adresa;
            (ipv4Text1.Text, ipv4Text2.Text, ipv4Text3.Text, ipv4Text4.Text)
                = IP_konfiguracija.SeperateMask(IP);

            string defaultGateway = MrezniAdapteri[interfaceIndex].DefaultGatewayV4;
            (defaultGatewayText1.Text, defaultGatewayText2.Text, defaultGatewayText3.Text, defaultGatewayText4.Text)
                = IP_konfiguracija.SeperateMask(defaultGateway);

            DhcpCheckBox.Checked = MrezniAdapteri[interfaceIndex].DhcpEnabled;
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

        private void ipv4PrefixText_KeyUp(object sender, KeyEventArgs e)
        {
            var inputSplit = ipv4PrefixText.Text.Split("/");
            if (inputSplit.Length > 1 && int.TryParse(inputSplit[1], out int null1))
            {
                string maska = IP_konfiguracija.ConvertPrefixToMask("/" + inputSplit[1]);
                (mreznaMaskaText1.Text, mreznaMaskaText2.Text, mreznaMaskaText3.Text, mreznaMaskaText4.Text) = IP_konfiguracija.SeperateMask(maska);
            }
        }

        private void mreznaMaskaText_KeyUp(object sender, KeyEventArgs e)
        {
            string mask = mreznaMaskaText1.Text + "." + mreznaMaskaText2.Text + "." + mreznaMaskaText3.Text + "." + mreznaMaskaText4.Text;
            string prefix = IP_konfiguracija.ConvertMaskToPrefix(mask);
            if (prefix != "!")
            {
                ipv4PrefixText.Text = prefix;
            }
        }

        private void primjeniPostavkeButton_Click(object sender, EventArgs e)
        {
            string ip = ipv4Text1.Text + "." + ipv4Text2.Text + "." + ipv4Text3.Text + "." + ipv4Text4.Text;
            string mask = mreznaMaskaText1.Text + "." + mreznaMaskaText2.Text + "." + mreznaMaskaText3.Text + "." + mreznaMaskaText4.Text;
            string gateway = defaultGatewayText1.Text + "." + defaultGatewayText2.Text + "." + defaultGatewayText3.Text + "." + defaultGatewayText4.Text;
            if (gateway == "...") gateway = "";

            if ((IP_konfiguracija.IsMaskRange(ip) && IP_konfiguracija.IsMask(mask) && (IP_konfiguracija.IsMaskRange(gateway) || gateway == "")
                && mask == IP_konfiguracija.ConvertPrefixToMask(ipv4PrefixText.Text)) || DhcpCheckBox.Checked)
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
                    rezultat = IP_konfiguracija.SetDHCPv4(MrezniAdapteri[interfaceIndex].AdapterName);
                else
                    rezultat = IP_konfiguracija.SetIPv4(MrezniAdapteri[interfaceIndex].AdapterName, ip, mask, gateway);

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
                        MrezniAdapteri[interfaceIndex].DhcpEnabled = !DhcpCheckBox.Checked;
                        MrezniAdapteri[interfaceIndex].DefaultGatewayV4 = gateway;
                        MrezniAdapteri[interfaceIndex].Ipv4Adresa = ip;
                        MrezniAdapteri[interfaceIndex].MrezniPrefixV4 = IP_konfiguracija.ConvertMaskToPrefix(mask);
                        MrezniAdapteri[interfaceIndex].MreznaMaskaV4 = mask;
                    }
                    else
                    {
                        MrezniAdapteri = IP_konfiguracija.GetListOfAdapters();
                        Thread upozoriNaAdaptere = new Thread(upozoriOsvjezitAdapter);
                        upozoriNaAdaptere.Start();
                    }

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
