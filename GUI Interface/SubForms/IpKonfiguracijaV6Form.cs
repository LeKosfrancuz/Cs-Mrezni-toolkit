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
using System.CodeDom;

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
            pokaziNaprednoButton_Click(sender, e);

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

            //ipv6PrefixText.Enabled = enable;

            ipv6Text.Enabled = enable;

            defaultGatewayV6Text.Enabled = enable;

            validLifeCheckBox.Enabled = enable;
            validLifeCheckBox.Checked = true;

            preferedLifeCheckBox.Enabled = enable;
            preferedLifeCheckBox.Checked = true;

            tipIPv6Grupa.Enabled = enable;
            spremanjeIPv6Grupa.Enabled = enable;

            skipAsSourceCheckBox.Enabled = enable;
        }

        private void ReDrawTextBoxes(object sender, EventArgs e)
        {
            int interfaceIndex = this.interfaceComboBox.SelectedIndex;
            string prefix = MrezniAdapteri[interfaceIndex].MrezniPrefixV6;
            //ipv6PrefixText.Text = prefix;

            string IP = MrezniAdapteri[interfaceIndex].Ipv6Adresa;
            ipv6Text.Text = IP;

            string defaultGateway = MrezniAdapteri[interfaceIndex].DefaultGatewayV6;
            defaultGatewayV6Text.Text = defaultGateway;

            DhcpCheckBox.Checked = !MrezniAdapteri[interfaceIndex].DhcpV6Enabled;

            refreshButton_Click(sender, e);
        }


        private void interfaceComboBoxSelectionChanged(object sender, EventArgs e)
        {
            ReDrawTextBoxes(sender, e);
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

        private void upozoriOsvjezitAdapter()
        {
            Thread.Sleep(5000);
            progressBarLable.Visible = true;
            progressBarLable.Text = "Preporuča se osvježavanje adaptera (Ctrl+Shift+R)";
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            int interfaceIndex = this.interfaceComboBox.SelectedIndex;

            if (odabirFunkcijeTabs.SelectedTab == tabIPv6Konfiguracija)
                IPv6DisplayTextBox.Text = IP_konfiguracija.GetIPv6ForAdapter(MrezniAdapteri[interfaceIndex].AdapterName);
            else if (odabirFunkcijeTabs.SelectedTab == tabGatewayKonfiguracija)
                IPv6DisplayTextBox.Text = IP_konfiguracija.GetIPv6GatewayForAdapter(MrezniAdapteri[interfaceIndex].AdapterName);
            else if (odabirFunkcijeTabs.SelectedTab == tabDNSKonfiguracija)
                IPv6DisplayTextBox.Text = IP_konfiguracija.GetIPv6DNSForAdapter(MrezniAdapteri[interfaceIndex].AdapterName);
            else
                IPv6DisplayTextBox.Text = "Subnetiranje trenutno nije u potpunosti podržano.\nDolazi uskoro!";
        }

        private void validLifeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetEnabledValidLife(!validLifeCheckBox.Checked);
        }

        public void SetEnabledValidLife(bool enabled)
        {
            validLifeDaysBox.Enabled = enabled;
            validLifeSatiBox.Enabled = enabled;
            validLifeMinuteBox.Enabled = enabled;
            validLifeSekundeBox.Enabled = enabled;
        }

        private void preferedLifeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetEnabledPreferedLife(!preferedLifeCheckBox.Checked);
        }

        public void SetEnabledPreferedLife(bool enabled)
        {
            preferedLifeDaysBox.Enabled = enabled;
            preferedLifeSatiBox.Enabled = enabled;
            preferedLifeMinuteBox.Enabled = enabled;
            preferedLifeSekundeBox.Enabled = enabled;
        }

        private void resetToDefaultAdresaButton_Click(object sender, EventArgs e)
        {
            //ipv6PrefixText.Text = "";
            ipv6Text.Text = "";
            validLifeCheckBox.Checked = true;

            validLifeDaysBox.Value = 0;
            validLifeSatiBox.Value = 0;
            validLifeMinuteBox.Value = 0;
            validLifeSekundeBox.Value = 0;

            preferedLifeCheckBox.Checked = true;
            
            preferedLifeDaysBox.Value = 0;
            preferedLifeSatiBox.Value = 0;
            preferedLifeMinuteBox.Value = 0;
            preferedLifeSekundeBox.Value = 0;

            skipAsSourceCheckBox.Checked = false;

            unicastRadioButton.Checked = true;

            storePersistentRadioButton.Checked = true;
        }

        private void obrisiIPv6AdresuButton_Click(object sender, EventArgs e)
        {
            string ip = ipv6Text.Text;
            int interfaceIndex = this.interfaceComboBox.SelectedIndex;

            MessageBoxButtons gumbi;
            MessageBoxDefaultButton odabranGumb;
            MessageBoxIcon slikica;

            int rezultat = IP_konfiguracija.SetIPv6(MrezniAdapteri[interfaceIndex].AdapterName, ip, false, null, null, null, null, null);

            if (rezultat == -1)
            {
                gumbi = MessageBoxButtons.OK;
                odabranGumb = MessageBoxDefaultButton.Button1;
                slikica = MessageBoxIcon.Exclamation;
                MessageBox.Show("Postavljanje mrežnih postavki neuspješno!\nCTRL+E za administratorske ovlasti.", "Potrebne administratorske ovlasti", gumbi, slikica, odabranGumb);

                return;
            }
            if (rezultat == -3)
            {
                gumbi = MessageBoxButtons.OK;
                odabranGumb = MessageBoxDefaultButton.Button1;
                slikica = MessageBoxIcon.Exclamation;
                MessageBox.Show("Postavljanje mrežnih postavki neuspješno!\nAdresa nije pronađena u tablici adresa", "Nepoznata IP adresa", gumbi, slikica, odabranGumb);

                return;
            }
            if (rezultat == -4)
            {
                gumbi = MessageBoxButtons.OK;
                odabranGumb = MessageBoxDefaultButton.Button1;
                slikica = MessageBoxIcon.Exclamation;
                MessageBox.Show("Postavljanje mrežnih postavki neuspješno!\nIPv6 adresa nije u pravilnom formatu", "Potrebne administratorske ovlasti", gumbi, slikica, odabranGumb);

                return;
            }

            gumbi = MessageBoxButtons.OK;
            odabranGumb = MessageBoxDefaultButton.Button1;
            slikica = MessageBoxIcon.Information;
            MessageBox.Show("Postavljanje mrežnih postavki uspješno!", "Uspjeh", gumbi, slikica, odabranGumb);


            ReDrawTextBoxes(sender, e);

        }

        private void dodajIPv6AdresuButton_Click(object sender, EventArgs e)
        {
            string ip = ipv6Text.Text;
            string prefix = "/64";//ipv6PrefixText.Text;

            MessageBoxButtons gumbi;
            MessageBoxDefaultButton odabranGumb;
            MessageBoxIcon slikica;

            if (!IP_konfiguracija.IsValidLifeSpanIPv6(
                IP_konfiguracija.ConvertTimeFieldToDoubleSekunde(validLifeDaysBox.Value, validLifeSatiBox.Value, validLifeMinuteBox.Value, validLifeSekundeBox.Value, validLifeCheckBox.Checked),
                IP_konfiguracija.ConvertTimeFieldToDoubleSekunde(preferedLifeDaysBox.Value, preferedLifeSatiBox.Value, preferedLifeMinuteBox.Value, preferedLifeSekundeBox.Value, preferedLifeCheckBox.Checked)))
            {
                gumbi = MessageBoxButtons.OK;
                odabranGumb = MessageBoxDefaultButton.Button1;
                slikica = MessageBoxIcon.Warning;
                MessageBox.Show("Postavljanje mrežnih postavki neuspješno!\n\nŽivotni vijek ne može biti manji od preporučenog životnog vijeka!", "Netočni argumenti", gumbi, slikica, odabranGumb);

                return;
            }

            string validTime = "infinite";
            if (!validLifeCheckBox.Checked)
                validTime = validLifeDaysBox.Value + "d" + validLifeSatiBox.Value + "h" + validLifeMinuteBox.Value + "m" + validLifeSekundeBox.Value + "s";

            string preferedTime = "infinite";
            if (!preferedLifeCheckBox.Checked)
                preferedTime = preferedLifeDaysBox.Value + "d" + preferedLifeSatiBox.Value + "h" + preferedLifeMinuteBox.Value + "m" + preferedLifeSekundeBox.Value + "s";

            string type = unicastRadioButton.Checked ? "unicast" : "anycast";

            string store = storePersistentRadioButton.Checked ? "persistent" : "active";

            string skip = skipAsSourceCheckBox.Checked ? "true" : "false";

            if (anycastRadioButton.Checked)
            {
                store = "";
                skip = "";
                validTime = "";
                preferedTime = "";
            }


            if (ip == "" || DhcpCheckBox.Checked)
            {
                gumbi = MessageBoxButtons.OK;
                odabranGumb = MessageBoxDefaultButton.Button1;
                slikica = MessageBoxIcon.Information;
                MessageBox.Show("Postavljanje mrežnih postavki neuspješno!\nPolja nisu pravilno ispunjena", "Nepotpuni argumenti", gumbi, slikica, odabranGumb);

                return;
            }


            gumbi = MessageBoxButtons.YesNo;
            odabranGumb = MessageBoxDefaultButton.Button1;
            slikica = MessageBoxIcon.Question;
            DialogResult messageBoxOdabir = MessageBox.Show("Želiš li dodati adresu u postavke mrežnog adaptera računala", "Potvrda mrežnih postavki", gumbi, slikica, odabranGumb);

            if (messageBoxOdabir == DialogResult.No)
                return;

            int interfaceIndex = this.interfaceComboBox.SelectedIndex;

            int rezultat;

            if (DhcpCheckBox.Checked)
                rezultat = -2;//IP_konfiguracija.SetDHCPv4(MrezniAdapteri[interfaceIndex].AdapterName);
            else
                rezultat = IP_konfiguracija.SetIPv6(MrezniAdapteri[interfaceIndex].AdapterName, ip, true, type, validTime, preferedTime, store, skip);

            if (rezultat == -1)
            {
                gumbi = MessageBoxButtons.OK;
                odabranGumb = MessageBoxDefaultButton.Button1;
                slikica = MessageBoxIcon.Exclamation;
                MessageBox.Show("Postavljanje mrežnih postavki neuspješno!\nCTRL+E za administratorske ovlasti.", "Potrebne administratorske ovlasti", gumbi, slikica, odabranGumb);

                return;
            }

            if (rezultat == -2)
            {
                gumbi = MessageBoxButtons.OK;
                odabranGumb = MessageBoxDefaultButton.Button1;
                slikica = MessageBoxIcon.Error;
                MessageBox.Show("Postavljanje mrežnih postavki neuspješno!\n\nMoguće je da je ta adresa već u upotrebi\n" +
                                "Prvo ju izbrišite prije ponovne konfiguracije", "Adresa je zauzeta", gumbi, slikica, odabranGumb);

                return;
            }
            if (rezultat == -4)
            {
                gumbi = MessageBoxButtons.OK;
                odabranGumb = MessageBoxDefaultButton.Button1;
                slikica = MessageBoxIcon.Exclamation;
                MessageBox.Show("Postavljanje mrežnih postavki neuspješno!\nIPv6 adresa nije u pravilnom formatu", "Potrebne administratorske ovlasti", gumbi, slikica, odabranGumb);

                return;
            }


            if (!DhcpCheckBox.Checked)
            {
                MrezniAdapteri[interfaceIndex].DhcpV6Enabled = !DhcpCheckBox.Checked;
                MrezniAdapteri[interfaceIndex].Ipv6Adresa = ip;
                MrezniAdapteri[interfaceIndex].MrezniPrefixV6 = prefix;
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


            ReDrawTextBoxes(sender, e);
        }

        private void downloadLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //CMD.Command("start chrome https://github.com/LeKosfrancuz/Cs-Mrezni-toolkit/releases/latest");
            IP_konfiguracija.OpenUrl("https://github.com/LeKosfrancuz/Cs-Mrezni-toolkit/releases/latest");
        }

        private void pokaziNaprednoButton_Click(object sender, EventArgs e)
        {
            if (dodatneOpcijePanel.Visible)
            {
                odabirFunkcijeTabs.Height = 150;
                dodatneOpcijePanel.Visible = false;
                pokaziNaprednoButton.Text = "Pokaži napredno";
            }
            else
            {
                odabirFunkcijeTabs.Height = 329;
                dodatneOpcijePanel.Visible = true;
                pokaziNaprednoButton.Text = "Sakrij napredno";
            }
        }

        private void odabirFunkcijeTabs_IndexChanged(object sender, EventArgs e)
        {
            odabirFunkcijeTabs.Height = 329;
            refreshButton_Click(sender, e);
        }

        private void dodajGatewayButton_Click(object sender, EventArgs e)
        {
            string ip = defaultGatewayV6Text.Text;
            int interfaceIndex = this.interfaceComboBox.SelectedIndex;

            MessageBoxButtons gumbi;
            MessageBoxDefaultButton odabranGumb;
            MessageBoxIcon slikica;

            int rezultat = IP_konfiguracija.SetDefaultGatewayV6(MrezniAdapteri[interfaceIndex].AdapterName, ip, true);

            if (rezultat == -1)
            {
                gumbi = MessageBoxButtons.OK;
                odabranGumb = MessageBoxDefaultButton.Button1;
                slikica = MessageBoxIcon.Exclamation;
                MessageBox.Show("Postavljanje gateway-a neuspješno!\nCTRL+E za administratorske ovlasti.", "Potrebne administratorske ovlasti", gumbi, slikica, odabranGumb);

                return;
            }
            if (rezultat == -2)
            {
                gumbi = MessageBoxButtons.OK;
                odabranGumb = MessageBoxDefaultButton.Button1;
                slikica = MessageBoxIcon.Error;
                MessageBox.Show("Postavljanje gateway-a neuspješno!\nDošlo je do nepoznate pogreške\n\n"+
                                "Moguće da adapter ne podržava ipv6 adrese.", "Nepoznata Pogreška", gumbi, slikica, odabranGumb);

                return;
            }
            if (rezultat == -3)
            {
                gumbi = MessageBoxButtons.OK;
                odabranGumb = MessageBoxDefaultButton.Button1;
                slikica = MessageBoxIcon.Exclamation;
                MessageBox.Show("Postavljanje gateway-a neuspješno!\nIPv6 adresa nije u pravilnom formatu", "Potrebne administratorske ovlasti", gumbi, slikica, odabranGumb);

                return;
            }

            gumbi = MessageBoxButtons.OK;
            odabranGumb = MessageBoxDefaultButton.Button1;
            slikica = MessageBoxIcon.Information;
            MessageBox.Show("Postavljanje gateway-a uspješno!", "Uspjeh", gumbi, slikica, odabranGumb);


            ReDrawTextBoxes(sender, e);
        }

        private void obrisiGatewayButton_Click(object sender, EventArgs e)
        {
            string ip = defaultGatewayV6Text.Text;
            int interfaceIndex = this.interfaceComboBox.SelectedIndex;

            MessageBoxButtons gumbi;
            MessageBoxDefaultButton odabranGumb;
            MessageBoxIcon slikica;

            int rezultat = IP_konfiguracija.SetDefaultGatewayV6(MrezniAdapteri[interfaceIndex].AdapterName, ip, false);

            if (rezultat == -1)
            {
                gumbi = MessageBoxButtons.OK;
                odabranGumb = MessageBoxDefaultButton.Button1;
                slikica = MessageBoxIcon.Exclamation;
                MessageBox.Show("Brisanje gateway-a neuspješno!\nCTRL+E za administratorske ovlasti.", "Potrebne administratorske ovlasti", gumbi, slikica, odabranGumb);

                return;
            }
            if (rezultat == -2)
            {
                gumbi = MessageBoxButtons.OK;
                odabranGumb = MessageBoxDefaultButton.Button1;
                slikica = MessageBoxIcon.Error;
                MessageBox.Show("Brisanje gateway-a neuspješno!\nDošlo je do nepoznate pogreške\n\n" +
                                "Moguće da tražena gateway adresa ne postoji u tablici.", "Nepoznata Pogreška", gumbi, slikica, odabranGumb);

                return;
            }
            if (rezultat == -3)
            {
                gumbi = MessageBoxButtons.OK;
                odabranGumb = MessageBoxDefaultButton.Button1;
                slikica = MessageBoxIcon.Exclamation;
                MessageBox.Show("Brisanje gateway-a neuspješno!\nIPv6 adresa nije u pravilnom formatu", "Potrebne administratorske ovlasti", gumbi, slikica, odabranGumb);

                return;
            }

            gumbi = MessageBoxButtons.OK;
            odabranGumb = MessageBoxDefaultButton.Button1;
            slikica = MessageBoxIcon.Information;
            MessageBox.Show("Brisanje gateway-a uspješno!", "Uspjeh", gumbi, slikica, odabranGumb);


            ReDrawTextBoxes(sender, e);
        }

        private void dodajDnsButton_Click(object sender, EventArgs e)
        {
            string ip = dnsV6Text.Text;
            int interfaceIndex = this.interfaceComboBox.SelectedIndex;
            if (dnsPrefixText.Text == "") dnsPrefixText.Text = "/64";

            MessageBoxButtons gumbi;
            MessageBoxDefaultButton odabranGumb;
            MessageBoxIcon slikica;

            int rezultat = IP_konfiguracija.SetDnsIPv6(MrezniAdapteri[interfaceIndex].AdapterName, ip, true, dnsPrefixText.Text);

            if (rezultat == -1)
            {
                gumbi = MessageBoxButtons.OK;
                odabranGumb = MessageBoxDefaultButton.Button1;
                slikica = MessageBoxIcon.Exclamation;
                MessageBox.Show("Dodavanje DNS servera neuspješno!\nCTRL+E za administratorske ovlasti.", "Potrebne administratorske ovlasti", gumbi, slikica, odabranGumb);

                return;
            }
            if (rezultat == -2)
            {
                gumbi = MessageBoxButtons.OK;
                odabranGumb = MessageBoxDefaultButton.Button1;
                slikica = MessageBoxIcon.Error;
                MessageBox.Show("Dodavanje DNS servera neuspješno!\nDNS server je netočan ili ne postoji", "DNS Server ne postoji", gumbi, slikica, odabranGumb);

                return;
            }
            if (rezultat == -3)
            {
                gumbi = MessageBoxButtons.OK;
                odabranGumb = MessageBoxDefaultButton.Button1;
                slikica = MessageBoxIcon.Exclamation;
                MessageBox.Show("Dodavanje DNS servera neuspješno!\nIPv6 adresa nije u pravilnom formatu", "Potrebne administratorske ovlasti", gumbi, slikica, odabranGumb);

                return;
            }

            gumbi = MessageBoxButtons.OK;
            odabranGumb = MessageBoxDefaultButton.Button1;
            slikica = MessageBoxIcon.Information;
            MessageBox.Show("Dodavanje DNS servera uspješno!", "Uspjeh", gumbi, slikica, odabranGumb);


            ReDrawTextBoxes(sender, e);
        }

        private void obrisiDnsButton_Click(object sender, EventArgs e)
        {
            string ip = dnsV6Text.Text;
            int interfaceIndex = this.interfaceComboBox.SelectedIndex;
            if (obrisiSveDNSCheckBox.Checked) ip = "all";

            MessageBoxButtons gumbi;
            MessageBoxDefaultButton odabranGumb;
            MessageBoxIcon slikica;

            int rezultat = IP_konfiguracija.SetDnsIPv6(MrezniAdapteri[interfaceIndex].AdapterName, ip, false, null);

            if (rezultat == -1)
            {
                gumbi = MessageBoxButtons.OK;
                odabranGumb = MessageBoxDefaultButton.Button1;
                slikica = MessageBoxIcon.Exclamation;
                MessageBox.Show("Brisanje DNS servera neuspješno!\nCTRL+E za administratorske ovlasti.", "Potrebne administratorske ovlasti", gumbi, slikica, odabranGumb);

                return;
            }
            if (rezultat == -2)
            {
                gumbi = MessageBoxButtons.OK;
                odabranGumb = MessageBoxDefaultButton.Button1;
                slikica = MessageBoxIcon.Error;
                MessageBox.Show("Brisanje DNS servera neuspješno!\nDNS server je netočan ili ne postoji", "DNS Server ne postoji", gumbi, slikica, odabranGumb);

                return;
            }
            if (rezultat == -3)
            {
                gumbi = MessageBoxButtons.OK;
                odabranGumb = MessageBoxDefaultButton.Button1;
                slikica = MessageBoxIcon.Exclamation;
                MessageBox.Show("Brisanje DNS servera neuspješno!\nIPv6 adresa nije u pravilnom formatu", "Potrebne administratorske ovlasti", gumbi, slikica, odabranGumb);

                return;
            }

            gumbi = MessageBoxButtons.OK;
            odabranGumb = MessageBoxDefaultButton.Button1;
            slikica = MessageBoxIcon.Information;
            MessageBox.Show("Brisanje DNS servera uspješno!", "Uspjeh", gumbi, slikica, odabranGumb);


            ReDrawTextBoxes(sender, e);
        }

        private void obrisiSveDNSCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            obrisiDnsButton.Text = obrisiSveDNSCheckBox.Checked ? "Obriši sve DNS servere" : "Obriši DNS server";
        }
    }
}
