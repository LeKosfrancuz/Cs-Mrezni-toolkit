namespace GUI_Interface
{
    partial class IpKonfiguracijaV6Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopPanel = new System.Windows.Forms.Panel();
            this.interfaceLable = new System.Windows.Forms.Label();
            this.interfaceComboBox = new System.Windows.Forms.ComboBox();
            this.IPv4Lable = new System.Windows.Forms.Label();
            this.ipv6Text = new System.Windows.Forms.TextBox();
            this.DhcpCheckBox = new System.Windows.Forms.CheckBox();
            this.defaultGatewayLabel = new System.Windows.Forms.Label();
            this.defaultGatewayV6Text = new System.Windows.Forms.TextBox();
            this.dodajIPv6AdresuButton = new System.Windows.Forms.Button();
            this.unicastRadioButton = new System.Windows.Forms.RadioButton();
            this.anycastRadioButton = new System.Windows.Forms.RadioButton();
            this.tipIPv6Grupa = new System.Windows.Forms.GroupBox();
            this.IPv6DisplayTextBox = new System.Windows.Forms.RichTextBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.odabirFunkcijeTabs = new System.Windows.Forms.TabControl();
            this.tabIPv6Konfiguracija = new System.Windows.Forms.TabPage();
            this.obrisiIPv6AdresuButton = new System.Windows.Forms.Button();
            this.dodatneOpcijePanel = new System.Windows.Forms.Panel();
            this.validLifeDaysBox = new System.Windows.Forms.NumericUpDown();
            this.validLifeSatiBox = new System.Windows.Forms.NumericUpDown();
            this.preferedLifeSekundeBox = new System.Windows.Forms.NumericUpDown();
            this.spremanjeIPv6Grupa = new System.Windows.Forms.GroupBox();
            this.storePersistentRadioButton = new System.Windows.Forms.RadioButton();
            this.storeActiveRadioButton = new System.Windows.Forms.RadioButton();
            this.validLifeMinuteBox = new System.Windows.Forms.NumericUpDown();
            this.preferedLifeMinuteBox = new System.Windows.Forms.NumericUpDown();
            this.validLifeSekundeBox = new System.Windows.Forms.NumericUpDown();
            this.preferedLifeSatiBox = new System.Windows.Forms.NumericUpDown();
            this.preferedLifeDaysBox = new System.Windows.Forms.NumericUpDown();
            this.validTimeLable = new System.Windows.Forms.Label();
            this.validLifeDaysLable = new System.Windows.Forms.Label();
            this.skipAsSourceCheckBox = new System.Windows.Forms.CheckBox();
            this.validLifeSatiLable = new System.Windows.Forms.Label();
            this.preferedLifeCheckBox = new System.Windows.Forms.CheckBox();
            this.validLifeMinuteLable = new System.Windows.Forms.Label();
            this.preferedLifeSekundeLable = new System.Windows.Forms.Label();
            this.validLifeSekundeLable = new System.Windows.Forms.Label();
            this.preferedLifeMinuteLable = new System.Windows.Forms.Label();
            this.validLifeCheckBox = new System.Windows.Forms.CheckBox();
            this.preferedTimeLable = new System.Windows.Forms.Label();
            this.preferedLifeSatiLable = new System.Windows.Forms.Label();
            this.preferedLifeDaysLable = new System.Windows.Forms.Label();
            this.pokaziNaprednoButton = new System.Windows.Forms.Button();
            this.resetToDefaultAdresaButton = new System.Windows.Forms.Button();
            this.tabGatewayKonfiguracija = new System.Windows.Forms.TabPage();
            this.obrisiGatewayButton = new System.Windows.Forms.Button();
            this.dodajGatewayButton = new System.Windows.Forms.Button();
            this.tabDNSKonfiguracija = new System.Windows.Forms.TabPage();
            this.obrisiSveDNSCheckBox = new System.Windows.Forms.CheckBox();
            this.dnsPrefixText = new System.Windows.Forms.TextBox();
            this.obrisiDnsButton = new System.Windows.Forms.Button();
            this.dnsV6Lable = new System.Windows.Forms.Label();
            this.dodajDnsButton = new System.Windows.Forms.Button();
            this.dnsV6Text = new System.Windows.Forms.TextBox();
            this.tabSubnetiranje = new System.Windows.Forms.TabPage();
            this.porukaOStatusuAplikacije = new System.Windows.Forms.Label();
            this.downloadLink = new System.Windows.Forms.LinkLabel();
            this.tekstZaDownload = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.tipIPv6Grupa.SuspendLayout();
            this.odabirFunkcijeTabs.SuspendLayout();
            this.tabIPv6Konfiguracija.SuspendLayout();
            this.dodatneOpcijePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validLifeDaysBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validLifeSatiBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preferedLifeSekundeBox)).BeginInit();
            this.spremanjeIPv6Grupa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validLifeMinuteBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preferedLifeMinuteBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validLifeSekundeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preferedLifeSatiBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preferedLifeDaysBox)).BeginInit();
            this.tabGatewayKonfiguracija.SuspendLayout();
            this.tabDNSKonfiguracija.SuspendLayout();
            this.tabSubnetiranje.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.interfaceLable);
            this.TopPanel.Controls.Add(this.interfaceComboBox);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(4);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(914, 52);
            this.TopPanel.TabIndex = 1;
            // 
            // interfaceLable
            // 
            this.interfaceLable.AutoSize = true;
            this.interfaceLable.Location = new System.Drawing.Point(21, 16);
            this.interfaceLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.interfaceLable.Name = "interfaceLable";
            this.interfaceLable.Size = new System.Drawing.Size(207, 17);
            this.interfaceLable.TabIndex = 1;
            this.interfaceLable.Text = "Odaberi mrežnu karticu/adapter : ";
            // 
            // interfaceComboBox
            // 
            this.interfaceComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.interfaceComboBox.FormattingEnabled = true;
            this.interfaceComboBox.Location = new System.Drawing.Point(231, 13);
            this.interfaceComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.interfaceComboBox.MinimumSize = new System.Drawing.Size(134, 0);
            this.interfaceComboBox.Name = "interfaceComboBox";
            this.interfaceComboBox.Size = new System.Drawing.Size(474, 25);
            this.interfaceComboBox.TabIndex = 0;
            this.interfaceComboBox.SelectedIndexChanged += new System.EventHandler(this.interfaceComboBoxSelectionChanged);
            // 
            // IPv4Lable
            // 
            this.IPv4Lable.AutoSize = true;
            this.IPv4Lable.Location = new System.Drawing.Point(10, 12);
            this.IPv4Lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IPv4Lable.Name = "IPv4Lable";
            this.IPv4Lable.Size = new System.Drawing.Size(86, 17);
            this.IPv4Lable.TabIndex = 2;
            this.IPv4Lable.Text = "IPv6 adresa : ";
            // 
            // ipv6Text
            // 
            this.ipv6Text.BackColor = System.Drawing.Color.Snow;
            this.ipv6Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipv6Text.Location = new System.Drawing.Point(121, 11);
            this.ipv6Text.Name = "ipv6Text";
            this.ipv6Text.PlaceholderText = "Upiši IPv6 adresu";
            this.ipv6Text.Size = new System.Drawing.Size(236, 18);
            this.ipv6Text.TabIndex = 3;
            this.ipv6Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DhcpCheckBox
            // 
            this.DhcpCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DhcpCheckBox.AutoSize = true;
            this.DhcpCheckBox.Location = new System.Drawing.Point(12, 186);
            this.DhcpCheckBox.Name = "DhcpCheckBox";
            this.DhcpCheckBox.Size = new System.Drawing.Size(111, 21);
            this.DhcpCheckBox.TabIndex = 2;
            this.DhcpCheckBox.Text = "DHCP Enabled";
            this.DhcpCheckBox.UseVisualStyleBackColor = true;
            this.DhcpCheckBox.CheckStateChanged += new System.EventHandler(this.DhcpCheckChanged);
            // 
            // defaultGatewayLabel
            // 
            this.defaultGatewayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.defaultGatewayLabel.AutoSize = true;
            this.defaultGatewayLabel.Location = new System.Drawing.Point(6, 16);
            this.defaultGatewayLabel.Name = "defaultGatewayLabel";
            this.defaultGatewayLabel.Size = new System.Drawing.Size(108, 17);
            this.defaultGatewayLabel.TabIndex = 11;
            this.defaultGatewayLabel.Text = "Default gateway :";
            // 
            // defaultGatewayV6Text
            // 
            this.defaultGatewayV6Text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.defaultGatewayV6Text.BackColor = System.Drawing.Color.Snow;
            this.defaultGatewayV6Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.defaultGatewayV6Text.Location = new System.Drawing.Point(117, 16);
            this.defaultGatewayV6Text.Name = "defaultGatewayV6Text";
            this.defaultGatewayV6Text.Size = new System.Drawing.Size(255, 18);
            this.defaultGatewayV6Text.TabIndex = 11;
            this.defaultGatewayV6Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dodajIPv6AdresuButton
            // 
            this.dodajIPv6AdresuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dodajIPv6AdresuButton.BackColor = System.Drawing.Color.PaleGreen;
            this.dodajIPv6AdresuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dodajIPv6AdresuButton.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.dodajIPv6AdresuButton.FlatAppearance.BorderSize = 2;
            this.dodajIPv6AdresuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.dodajIPv6AdresuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.dodajIPv6AdresuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajIPv6AdresuButton.Location = new System.Drawing.Point(716, 238);
            this.dodajIPv6AdresuButton.Name = "dodajIPv6AdresuButton";
            this.dodajIPv6AdresuButton.Size = new System.Drawing.Size(119, 49);
            this.dodajIPv6AdresuButton.TabIndex = 15;
            this.dodajIPv6AdresuButton.Text = "Dodaj Adresu";
            this.dodajIPv6AdresuButton.UseVisualStyleBackColor = false;
            this.dodajIPv6AdresuButton.Click += new System.EventHandler(this.dodajIPv6AdresuButton_Click);
            // 
            // unicastRadioButton
            // 
            this.unicastRadioButton.AutoSize = true;
            this.unicastRadioButton.Checked = true;
            this.unicastRadioButton.Location = new System.Drawing.Point(14, 24);
            this.unicastRadioButton.Name = "unicastRadioButton";
            this.unicastRadioButton.Size = new System.Drawing.Size(68, 21);
            this.unicastRadioButton.TabIndex = 16;
            this.unicastRadioButton.TabStop = true;
            this.unicastRadioButton.Text = "Unicast";
            this.unicastRadioButton.UseVisualStyleBackColor = true;
            // 
            // anycastRadioButton
            // 
            this.anycastRadioButton.AutoSize = true;
            this.anycastRadioButton.Location = new System.Drawing.Point(14, 51);
            this.anycastRadioButton.Name = "anycastRadioButton";
            this.anycastRadioButton.Size = new System.Drawing.Size(70, 21);
            this.anycastRadioButton.TabIndex = 17;
            this.anycastRadioButton.TabStop = true;
            this.anycastRadioButton.Text = "Anycast";
            this.anycastRadioButton.UseVisualStyleBackColor = true;
            // 
            // tipIPv6Grupa
            // 
            this.tipIPv6Grupa.Controls.Add(this.unicastRadioButton);
            this.tipIPv6Grupa.Controls.Add(this.anycastRadioButton);
            this.tipIPv6Grupa.Location = new System.Drawing.Point(0, 153);
            this.tipIPv6Grupa.Name = "tipIPv6Grupa";
            this.tipIPv6Grupa.Size = new System.Drawing.Size(104, 81);
            this.tipIPv6Grupa.TabIndex = 18;
            this.tipIPv6Grupa.TabStop = false;
            this.tipIPv6Grupa.Text = "Tip";
            // 
            // IPv6DisplayTextBox
            // 
            this.IPv6DisplayTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IPv6DisplayTextBox.Location = new System.Drawing.Point(14, 66);
            this.IPv6DisplayTextBox.Name = "IPv6DisplayTextBox";
            this.IPv6DisplayTextBox.ReadOnly = true;
            this.IPv6DisplayTextBox.Size = new System.Drawing.Size(865, 114);
            this.IPv6DisplayTextBox.TabIndex = 19;
            this.IPv6DisplayTextBox.Text = "[Nema informacija]";
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.refreshButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.refreshButton.FlatAppearance.BorderSize = 2;
            this.refreshButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.refreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Location = new System.Drawing.Point(802, 186);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(77, 33);
            this.refreshButton.TabIndex = 20;
            this.refreshButton.Text = "Osvježi";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // odabirFunkcijeTabs
            // 
            this.odabirFunkcijeTabs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.odabirFunkcijeTabs.Controls.Add(this.tabIPv6Konfiguracija);
            this.odabirFunkcijeTabs.Controls.Add(this.tabGatewayKonfiguracija);
            this.odabirFunkcijeTabs.Controls.Add(this.tabDNSKonfiguracija);
            this.odabirFunkcijeTabs.Controls.Add(this.tabSubnetiranje);
            this.odabirFunkcijeTabs.Location = new System.Drawing.Point(14, 225);
            this.odabirFunkcijeTabs.Name = "odabirFunkcijeTabs";
            this.odabirFunkcijeTabs.SelectedIndex = 0;
            this.odabirFunkcijeTabs.Size = new System.Drawing.Size(865, 329);
            this.odabirFunkcijeTabs.TabIndex = 21;
            this.odabirFunkcijeTabs.SelectedIndexChanged += new System.EventHandler(this.odabirFunkcijeTabs_IndexChanged);
            // 
            // tabIPv6Konfiguracija
            // 
            this.tabIPv6Konfiguracija.Controls.Add(this.obrisiIPv6AdresuButton);
            this.tabIPv6Konfiguracija.Controls.Add(this.dodajIPv6AdresuButton);
            this.tabIPv6Konfiguracija.Controls.Add(this.dodatneOpcijePanel);
            this.tabIPv6Konfiguracija.Controls.Add(this.pokaziNaprednoButton);
            this.tabIPv6Konfiguracija.Controls.Add(this.resetToDefaultAdresaButton);
            this.tabIPv6Konfiguracija.Controls.Add(this.IPv4Lable);
            this.tabIPv6Konfiguracija.Controls.Add(this.ipv6Text);
            this.tabIPv6Konfiguracija.Location = new System.Drawing.Point(4, 26);
            this.tabIPv6Konfiguracija.Name = "tabIPv6Konfiguracija";
            this.tabIPv6Konfiguracija.Padding = new System.Windows.Forms.Padding(3);
            this.tabIPv6Konfiguracija.Size = new System.Drawing.Size(857, 299);
            this.tabIPv6Konfiguracija.TabIndex = 0;
            this.tabIPv6Konfiguracija.Text = "IPv6 Adresa";
            this.tabIPv6Konfiguracija.UseVisualStyleBackColor = true;
            // 
            // obrisiIPv6AdresuButton
            // 
            this.obrisiIPv6AdresuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.obrisiIPv6AdresuButton.BackColor = System.Drawing.Color.LightCoral;
            this.obrisiIPv6AdresuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.obrisiIPv6AdresuButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.obrisiIPv6AdresuButton.FlatAppearance.BorderSize = 2;
            this.obrisiIPv6AdresuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.obrisiIPv6AdresuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.obrisiIPv6AdresuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.obrisiIPv6AdresuButton.Location = new System.Drawing.Point(579, 238);
            this.obrisiIPv6AdresuButton.Name = "obrisiIPv6AdresuButton";
            this.obrisiIPv6AdresuButton.Size = new System.Drawing.Size(119, 49);
            this.obrisiIPv6AdresuButton.TabIndex = 19;
            this.obrisiIPv6AdresuButton.Text = "Obriši Adresu";
            this.obrisiIPv6AdresuButton.UseVisualStyleBackColor = false;
            this.obrisiIPv6AdresuButton.Click += new System.EventHandler(this.obrisiIPv6AdresuButton_Click);
            // 
            // dodatneOpcijePanel
            // 
            this.dodatneOpcijePanel.Controls.Add(this.validLifeDaysBox);
            this.dodatneOpcijePanel.Controls.Add(this.validLifeSatiBox);
            this.dodatneOpcijePanel.Controls.Add(this.preferedLifeSekundeBox);
            this.dodatneOpcijePanel.Controls.Add(this.spremanjeIPv6Grupa);
            this.dodatneOpcijePanel.Controls.Add(this.validLifeMinuteBox);
            this.dodatneOpcijePanel.Controls.Add(this.preferedLifeMinuteBox);
            this.dodatneOpcijePanel.Controls.Add(this.tipIPv6Grupa);
            this.dodatneOpcijePanel.Controls.Add(this.validLifeSekundeBox);
            this.dodatneOpcijePanel.Controls.Add(this.preferedLifeSatiBox);
            this.dodatneOpcijePanel.Controls.Add(this.preferedLifeDaysBox);
            this.dodatneOpcijePanel.Controls.Add(this.validTimeLable);
            this.dodatneOpcijePanel.Controls.Add(this.validLifeDaysLable);
            this.dodatneOpcijePanel.Controls.Add(this.skipAsSourceCheckBox);
            this.dodatneOpcijePanel.Controls.Add(this.validLifeSatiLable);
            this.dodatneOpcijePanel.Controls.Add(this.preferedLifeCheckBox);
            this.dodatneOpcijePanel.Controls.Add(this.validLifeMinuteLable);
            this.dodatneOpcijePanel.Controls.Add(this.preferedLifeSekundeLable);
            this.dodatneOpcijePanel.Controls.Add(this.validLifeSekundeLable);
            this.dodatneOpcijePanel.Controls.Add(this.preferedLifeMinuteLable);
            this.dodatneOpcijePanel.Controls.Add(this.validLifeCheckBox);
            this.dodatneOpcijePanel.Controls.Add(this.preferedTimeLable);
            this.dodatneOpcijePanel.Controls.Add(this.preferedLifeSatiLable);
            this.dodatneOpcijePanel.Controls.Add(this.preferedLifeDaysLable);
            this.dodatneOpcijePanel.Location = new System.Drawing.Point(10, 47);
            this.dodatneOpcijePanel.Name = "dodatneOpcijePanel";
            this.dodatneOpcijePanel.Size = new System.Drawing.Size(532, 237);
            this.dodatneOpcijePanel.TabIndex = 44;
            // 
            // validLifeDaysBox
            // 
            this.validLifeDaysBox.Enabled = false;
            this.validLifeDaysBox.Location = new System.Drawing.Point(118, 8);
            this.validLifeDaysBox.Name = "validLifeDaysBox";
            this.validLifeDaysBox.Size = new System.Drawing.Size(42, 25);
            this.validLifeDaysBox.TabIndex = 21;
            // 
            // validLifeSatiBox
            // 
            this.validLifeSatiBox.Enabled = false;
            this.validLifeSatiBox.Location = new System.Drawing.Point(200, 9);
            this.validLifeSatiBox.Name = "validLifeSatiBox";
            this.validLifeSatiBox.Size = new System.Drawing.Size(42, 25);
            this.validLifeSatiBox.TabIndex = 23;
            // 
            // preferedLifeSekundeBox
            // 
            this.preferedLifeSekundeBox.Enabled = false;
            this.preferedLifeSekundeBox.Location = new System.Drawing.Point(437, 70);
            this.preferedLifeSekundeBox.Name = "preferedLifeSekundeBox";
            this.preferedLifeSekundeBox.Size = new System.Drawing.Size(42, 25);
            this.preferedLifeSekundeBox.TabIndex = 37;
            // 
            // spremanjeIPv6Grupa
            // 
            this.spremanjeIPv6Grupa.Controls.Add(this.storePersistentRadioButton);
            this.spremanjeIPv6Grupa.Controls.Add(this.storeActiveRadioButton);
            this.spremanjeIPv6Grupa.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.spremanjeIPv6Grupa.Location = new System.Drawing.Point(118, 153);
            this.spremanjeIPv6Grupa.Name = "spremanjeIPv6Grupa";
            this.spremanjeIPv6Grupa.Size = new System.Drawing.Size(200, 81);
            this.spremanjeIPv6Grupa.TabIndex = 40;
            this.spremanjeIPv6Grupa.TabStop = false;
            this.spremanjeIPv6Grupa.Text = "Spremanje";
            // 
            // storePersistentRadioButton
            // 
            this.storePersistentRadioButton.AutoSize = true;
            this.storePersistentRadioButton.Checked = true;
            this.storePersistentRadioButton.Location = new System.Drawing.Point(10, 28);
            this.storePersistentRadioButton.Name = "storePersistentRadioButton";
            this.storePersistentRadioButton.Size = new System.Drawing.Size(166, 22);
            this.storePersistentRadioButton.TabIndex = 1;
            this.storePersistentRadioButton.TabStop = true;
            this.storePersistentRadioButton.Text = "Dok se ručno ne makne";
            this.storePersistentRadioButton.UseVisualStyleBackColor = true;
            // 
            // storeActiveRadioButton
            // 
            this.storeActiveRadioButton.AutoSize = true;
            this.storeActiveRadioButton.Location = new System.Drawing.Point(10, 47);
            this.storeActiveRadioButton.Name = "storeActiveRadioButton";
            this.storeActiveRadioButton.Size = new System.Drawing.Size(172, 22);
            this.storeActiveRadioButton.TabIndex = 0;
            this.storeActiveRadioButton.Text = "Samo do idućeg restarta";
            this.storeActiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // validLifeMinuteBox
            // 
            this.validLifeMinuteBox.Enabled = false;
            this.validLifeMinuteBox.Location = new System.Drawing.Point(273, 9);
            this.validLifeMinuteBox.Name = "validLifeMinuteBox";
            this.validLifeMinuteBox.Size = new System.Drawing.Size(42, 25);
            this.validLifeMinuteBox.TabIndex = 25;
            // 
            // preferedLifeMinuteBox
            // 
            this.preferedLifeMinuteBox.Enabled = false;
            this.preferedLifeMinuteBox.Location = new System.Drawing.Point(345, 70);
            this.preferedLifeMinuteBox.Name = "preferedLifeMinuteBox";
            this.preferedLifeMinuteBox.Size = new System.Drawing.Size(42, 25);
            this.preferedLifeMinuteBox.TabIndex = 35;
            // 
            // validLifeSekundeBox
            // 
            this.validLifeSekundeBox.Enabled = false;
            this.validLifeSekundeBox.Location = new System.Drawing.Point(365, 9);
            this.validLifeSekundeBox.Name = "validLifeSekundeBox";
            this.validLifeSekundeBox.Size = new System.Drawing.Size(42, 25);
            this.validLifeSekundeBox.TabIndex = 27;
            // 
            // preferedLifeSatiBox
            // 
            this.preferedLifeSatiBox.Enabled = false;
            this.preferedLifeSatiBox.Location = new System.Drawing.Point(272, 70);
            this.preferedLifeSatiBox.Name = "preferedLifeSatiBox";
            this.preferedLifeSatiBox.Size = new System.Drawing.Size(42, 25);
            this.preferedLifeSatiBox.TabIndex = 33;
            // 
            // preferedLifeDaysBox
            // 
            this.preferedLifeDaysBox.Enabled = false;
            this.preferedLifeDaysBox.Location = new System.Drawing.Point(190, 69);
            this.preferedLifeDaysBox.Name = "preferedLifeDaysBox";
            this.preferedLifeDaysBox.Size = new System.Drawing.Size(42, 25);
            this.preferedLifeDaysBox.TabIndex = 31;
            // 
            // validTimeLable
            // 
            this.validTimeLable.AutoSize = true;
            this.validTimeLable.Location = new System.Drawing.Point(0, 10);
            this.validTimeLable.Name = "validTimeLable";
            this.validTimeLable.Size = new System.Drawing.Size(97, 17);
            this.validTimeLable.TabIndex = 20;
            this.validTimeLable.Text = "Vrijeme života :";
            // 
            // validLifeDaysLable
            // 
            this.validLifeDaysLable.AutoSize = true;
            this.validLifeDaysLable.Location = new System.Drawing.Point(157, 11);
            this.validLifeDaysLable.Name = "validLifeDaysLable";
            this.validLifeDaysLable.Size = new System.Drawing.Size(37, 17);
            this.validLifeDaysLable.TabIndex = 22;
            this.validLifeDaysLable.Text = "dana";
            // 
            // skipAsSourceCheckBox
            // 
            this.skipAsSourceCheckBox.AutoSize = true;
            this.skipAsSourceCheckBox.Location = new System.Drawing.Point(3, 126);
            this.skipAsSourceCheckBox.Name = "skipAsSourceCheckBox";
            this.skipAsSourceCheckBox.Size = new System.Drawing.Size(187, 21);
            this.skipAsSourceCheckBox.TabIndex = 41;
            this.skipAsSourceCheckBox.Text = "Preskoči kao izvor u paketu";
            this.skipAsSourceCheckBox.UseVisualStyleBackColor = true;
            // 
            // validLifeSatiLable
            // 
            this.validLifeSatiLable.AutoSize = true;
            this.validLifeSatiLable.Location = new System.Drawing.Point(239, 12);
            this.validLifeSatiLable.Name = "validLifeSatiLable";
            this.validLifeSatiLable.Size = new System.Drawing.Size(28, 17);
            this.validLifeSatiLable.TabIndex = 24;
            this.validLifeSatiLable.Text = "sati";
            // 
            // preferedLifeCheckBox
            // 
            this.preferedLifeCheckBox.AutoSize = true;
            this.preferedLifeCheckBox.Checked = true;
            this.preferedLifeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.preferedLifeCheckBox.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.preferedLifeCheckBox.Location = new System.Drawing.Point(3, 90);
            this.preferedLifeCheckBox.Name = "preferedLifeCheckBox";
            this.preferedLifeCheckBox.Size = new System.Drawing.Size(100, 22);
            this.preferedLifeCheckBox.TabIndex = 39;
            this.preferedLifeCheckBox.Text = "Beskonačno";
            this.preferedLifeCheckBox.UseVisualStyleBackColor = true;
            this.preferedLifeCheckBox.CheckedChanged += new System.EventHandler(this.preferedLifeCheckBox_CheckedChanged);
            // 
            // validLifeMinuteLable
            // 
            this.validLifeMinuteLable.AutoSize = true;
            this.validLifeMinuteLable.Location = new System.Drawing.Point(312, 12);
            this.validLifeMinuteLable.Name = "validLifeMinuteLable";
            this.validLifeMinuteLable.Size = new System.Drawing.Size(47, 17);
            this.validLifeMinuteLable.TabIndex = 26;
            this.validLifeMinuteLable.Text = "minuta";
            // 
            // preferedLifeSekundeLable
            // 
            this.preferedLifeSekundeLable.AutoSize = true;
            this.preferedLifeSekundeLable.Location = new System.Drawing.Point(476, 73);
            this.preferedLifeSekundeLable.Name = "preferedLifeSekundeLable";
            this.preferedLifeSekundeLable.Size = new System.Drawing.Size(52, 17);
            this.preferedLifeSekundeLable.TabIndex = 38;
            this.preferedLifeSekundeLable.Text = "sekundi";
            // 
            // validLifeSekundeLable
            // 
            this.validLifeSekundeLable.AutoSize = true;
            this.validLifeSekundeLable.Location = new System.Drawing.Point(404, 12);
            this.validLifeSekundeLable.Name = "validLifeSekundeLable";
            this.validLifeSekundeLable.Size = new System.Drawing.Size(52, 17);
            this.validLifeSekundeLable.TabIndex = 28;
            this.validLifeSekundeLable.Text = "sekundi";
            // 
            // preferedLifeMinuteLable
            // 
            this.preferedLifeMinuteLable.AutoSize = true;
            this.preferedLifeMinuteLable.Location = new System.Drawing.Point(384, 73);
            this.preferedLifeMinuteLable.Name = "preferedLifeMinuteLable";
            this.preferedLifeMinuteLable.Size = new System.Drawing.Size(47, 17);
            this.preferedLifeMinuteLable.TabIndex = 36;
            this.preferedLifeMinuteLable.Text = "minuta";
            // 
            // validLifeCheckBox
            // 
            this.validLifeCheckBox.AutoSize = true;
            this.validLifeCheckBox.Checked = true;
            this.validLifeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.validLifeCheckBox.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.validLifeCheckBox.Location = new System.Drawing.Point(3, 29);
            this.validLifeCheckBox.Name = "validLifeCheckBox";
            this.validLifeCheckBox.Size = new System.Drawing.Size(100, 22);
            this.validLifeCheckBox.TabIndex = 29;
            this.validLifeCheckBox.Text = "Beskonačno";
            this.validLifeCheckBox.UseVisualStyleBackColor = true;
            this.validLifeCheckBox.CheckedChanged += new System.EventHandler(this.validLifeCheckBox_CheckedChanged);
            // 
            // preferedTimeLable
            // 
            this.preferedTimeLable.AutoSize = true;
            this.preferedTimeLable.Location = new System.Drawing.Point(0, 71);
            this.preferedTimeLable.Name = "preferedTimeLable";
            this.preferedTimeLable.Size = new System.Drawing.Size(175, 17);
            this.preferedTimeLable.TabIndex = 30;
            this.preferedTimeLable.Text = "Preporučeno vrijeme života :";
            // 
            // preferedLifeSatiLable
            // 
            this.preferedLifeSatiLable.AutoSize = true;
            this.preferedLifeSatiLable.Location = new System.Drawing.Point(311, 73);
            this.preferedLifeSatiLable.Name = "preferedLifeSatiLable";
            this.preferedLifeSatiLable.Size = new System.Drawing.Size(28, 17);
            this.preferedLifeSatiLable.TabIndex = 34;
            this.preferedLifeSatiLable.Text = "sati";
            // 
            // preferedLifeDaysLable
            // 
            this.preferedLifeDaysLable.AutoSize = true;
            this.preferedLifeDaysLable.Location = new System.Drawing.Point(229, 72);
            this.preferedLifeDaysLable.Name = "preferedLifeDaysLable";
            this.preferedLifeDaysLable.Size = new System.Drawing.Size(37, 17);
            this.preferedLifeDaysLable.TabIndex = 32;
            this.preferedLifeDaysLable.Text = "dana";
            // 
            // pokaziNaprednoButton
            // 
            this.pokaziNaprednoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pokaziNaprednoButton.Location = new System.Drawing.Point(382, 10);
            this.pokaziNaprednoButton.Name = "pokaziNaprednoButton";
            this.pokaziNaprednoButton.Size = new System.Drawing.Size(136, 23);
            this.pokaziNaprednoButton.TabIndex = 43;
            this.pokaziNaprednoButton.Text = "Odabir prikaza";
            this.pokaziNaprednoButton.UseVisualStyleBackColor = true;
            this.pokaziNaprednoButton.Click += new System.EventHandler(this.pokaziNaprednoButton_Click);
            // 
            // resetToDefaultAdresaButton
            // 
            this.resetToDefaultAdresaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetToDefaultAdresaButton.BackColor = System.Drawing.Color.Snow;
            this.resetToDefaultAdresaButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.resetToDefaultAdresaButton.FlatAppearance.BorderSize = 2;
            this.resetToDefaultAdresaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.resetToDefaultAdresaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.resetToDefaultAdresaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetToDefaultAdresaButton.Location = new System.Drawing.Point(807, 6);
            this.resetToDefaultAdresaButton.Name = "resetToDefaultAdresaButton";
            this.resetToDefaultAdresaButton.Size = new System.Drawing.Size(42, 37);
            this.resetToDefaultAdresaButton.TabIndex = 42;
            this.resetToDefaultAdresaButton.Text = "X";
            this.resetToDefaultAdresaButton.UseVisualStyleBackColor = false;
            this.resetToDefaultAdresaButton.Click += new System.EventHandler(this.resetToDefaultAdresaButton_Click);
            // 
            // tabGatewayKonfiguracija
            // 
            this.tabGatewayKonfiguracija.Controls.Add(this.obrisiGatewayButton);
            this.tabGatewayKonfiguracija.Controls.Add(this.defaultGatewayLabel);
            this.tabGatewayKonfiguracija.Controls.Add(this.dodajGatewayButton);
            this.tabGatewayKonfiguracija.Controls.Add(this.defaultGatewayV6Text);
            this.tabGatewayKonfiguracija.Location = new System.Drawing.Point(4, 24);
            this.tabGatewayKonfiguracija.Name = "tabGatewayKonfiguracija";
            this.tabGatewayKonfiguracija.Padding = new System.Windows.Forms.Padding(3);
            this.tabGatewayKonfiguracija.Size = new System.Drawing.Size(857, 301);
            this.tabGatewayKonfiguracija.TabIndex = 1;
            this.tabGatewayKonfiguracija.Text = "Gateway";
            this.tabGatewayKonfiguracija.UseVisualStyleBackColor = true;
            // 
            // obrisiGatewayButton
            // 
            this.obrisiGatewayButton.BackColor = System.Drawing.Color.LightCoral;
            this.obrisiGatewayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.obrisiGatewayButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.obrisiGatewayButton.FlatAppearance.BorderSize = 2;
            this.obrisiGatewayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.obrisiGatewayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.obrisiGatewayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.obrisiGatewayButton.Location = new System.Drawing.Point(41, 51);
            this.obrisiGatewayButton.Name = "obrisiGatewayButton";
            this.obrisiGatewayButton.Size = new System.Drawing.Size(119, 49);
            this.obrisiGatewayButton.TabIndex = 46;
            this.obrisiGatewayButton.Text = "Obriši Gateway";
            this.obrisiGatewayButton.UseVisualStyleBackColor = false;
            this.obrisiGatewayButton.Click += new System.EventHandler(this.obrisiGatewayButton_Click);
            // 
            // dodajGatewayButton
            // 
            this.dodajGatewayButton.BackColor = System.Drawing.Color.PaleGreen;
            this.dodajGatewayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dodajGatewayButton.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.dodajGatewayButton.FlatAppearance.BorderSize = 2;
            this.dodajGatewayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.dodajGatewayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.dodajGatewayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajGatewayButton.Location = new System.Drawing.Point(178, 51);
            this.dodajGatewayButton.Name = "dodajGatewayButton";
            this.dodajGatewayButton.Size = new System.Drawing.Size(119, 49);
            this.dodajGatewayButton.TabIndex = 45;
            this.dodajGatewayButton.Text = "Dodaj Gateway";
            this.dodajGatewayButton.UseVisualStyleBackColor = false;
            this.dodajGatewayButton.Click += new System.EventHandler(this.dodajGatewayButton_Click);
            // 
            // tabDNSKonfiguracija
            // 
            this.tabDNSKonfiguracija.Controls.Add(this.obrisiSveDNSCheckBox);
            this.tabDNSKonfiguracija.Controls.Add(this.dnsPrefixText);
            this.tabDNSKonfiguracija.Controls.Add(this.obrisiDnsButton);
            this.tabDNSKonfiguracija.Controls.Add(this.dnsV6Lable);
            this.tabDNSKonfiguracija.Controls.Add(this.dodajDnsButton);
            this.tabDNSKonfiguracija.Controls.Add(this.dnsV6Text);
            this.tabDNSKonfiguracija.Location = new System.Drawing.Point(4, 26);
            this.tabDNSKonfiguracija.Name = "tabDNSKonfiguracija";
            this.tabDNSKonfiguracija.Size = new System.Drawing.Size(857, 299);
            this.tabDNSKonfiguracija.TabIndex = 2;
            this.tabDNSKonfiguracija.Text = "DNS";
            this.tabDNSKonfiguracija.UseVisualStyleBackColor = true;
            // 
            // obrisiSveDNSCheckBox
            // 
            this.obrisiSveDNSCheckBox.AutoSize = true;
            this.obrisiSveDNSCheckBox.Location = new System.Drawing.Point(14, 42);
            this.obrisiSveDNSCheckBox.Name = "obrisiSveDNSCheckBox";
            this.obrisiSveDNSCheckBox.Size = new System.Drawing.Size(85, 21);
            this.obrisiSveDNSCheckBox.TabIndex = 52;
            this.obrisiSveDNSCheckBox.Text = "Obriši sve";
            this.obrisiSveDNSCheckBox.UseVisualStyleBackColor = true;
            this.obrisiSveDNSCheckBox.CheckedChanged += new System.EventHandler(this.obrisiSveDNSCheckBox_CheckedChanged);
            // 
            // dnsPrefixText
            // 
            this.dnsPrefixText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dnsPrefixText.BackColor = System.Drawing.Color.Snow;
            this.dnsPrefixText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dnsPrefixText.Location = new System.Drawing.Point(403, 17);
            this.dnsPrefixText.Name = "dnsPrefixText";
            this.dnsPrefixText.PlaceholderText = "/64 (Default)";
            this.dnsPrefixText.Size = new System.Drawing.Size(82, 18);
            this.dnsPrefixText.TabIndex = 51;
            this.dnsPrefixText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // obrisiDnsButton
            // 
            this.obrisiDnsButton.BackColor = System.Drawing.Color.LightCoral;
            this.obrisiDnsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.obrisiDnsButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.obrisiDnsButton.FlatAppearance.BorderSize = 2;
            this.obrisiDnsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.obrisiDnsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.obrisiDnsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.obrisiDnsButton.Location = new System.Drawing.Point(116, 85);
            this.obrisiDnsButton.Name = "obrisiDnsButton";
            this.obrisiDnsButton.Size = new System.Drawing.Size(119, 49);
            this.obrisiDnsButton.TabIndex = 50;
            this.obrisiDnsButton.Text = "Obriši DNS server";
            this.obrisiDnsButton.UseVisualStyleBackColor = false;
            this.obrisiDnsButton.Click += new System.EventHandler(this.obrisiDnsButton_Click);
            // 
            // dnsV6Lable
            // 
            this.dnsV6Lable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dnsV6Lable.AutoSize = true;
            this.dnsV6Lable.Location = new System.Drawing.Point(14, 17);
            this.dnsV6Lable.Name = "dnsV6Lable";
            this.dnsV6Lable.Size = new System.Drawing.Size(134, 17);
            this.dnsV6Lable.TabIndex = 47;
            this.dnsV6Lable.Text = "Adresa DNS servera :";
            // 
            // dodajDnsButton
            // 
            this.dodajDnsButton.BackColor = System.Drawing.Color.PaleGreen;
            this.dodajDnsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dodajDnsButton.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.dodajDnsButton.FlatAppearance.BorderSize = 2;
            this.dodajDnsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.dodajDnsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.dodajDnsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajDnsButton.Location = new System.Drawing.Point(241, 85);
            this.dodajDnsButton.Name = "dodajDnsButton";
            this.dodajDnsButton.Size = new System.Drawing.Size(119, 49);
            this.dodajDnsButton.TabIndex = 49;
            this.dodajDnsButton.Text = "Dodaj DNS server";
            this.dodajDnsButton.UseVisualStyleBackColor = false;
            this.dodajDnsButton.Click += new System.EventHandler(this.dodajDnsButton_Click);
            // 
            // dnsV6Text
            // 
            this.dnsV6Text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dnsV6Text.BackColor = System.Drawing.Color.Snow;
            this.dnsV6Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dnsV6Text.Location = new System.Drawing.Point(154, 17);
            this.dnsV6Text.Name = "dnsV6Text";
            this.dnsV6Text.Size = new System.Drawing.Size(255, 18);
            this.dnsV6Text.TabIndex = 48;
            this.dnsV6Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabSubnetiranje
            // 
            this.tabSubnetiranje.Controls.Add(this.porukaOStatusuAplikacije);
            this.tabSubnetiranje.Controls.Add(this.downloadLink);
            this.tabSubnetiranje.Controls.Add(this.tekstZaDownload);
            this.tabSubnetiranje.Location = new System.Drawing.Point(4, 24);
            this.tabSubnetiranje.Name = "tabSubnetiranje";
            this.tabSubnetiranje.Size = new System.Drawing.Size(857, 301);
            this.tabSubnetiranje.TabIndex = 3;
            this.tabSubnetiranje.Text = "Subnetiranje";
            this.tabSubnetiranje.UseVisualStyleBackColor = true;
            // 
            // porukaOStatusuAplikacije
            // 
            this.porukaOStatusuAplikacije.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.porukaOStatusuAplikacije.AutoSize = true;
            this.porukaOStatusuAplikacije.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.porukaOStatusuAplikacije.Location = new System.Drawing.Point(138, 7);
            this.porukaOStatusuAplikacije.Name = "porukaOStatusuAplikacije";
            this.porukaOStatusuAplikacije.Size = new System.Drawing.Size(339, 37);
            this.porukaOStatusuAplikacije.TabIndex = 8;
            this.porukaOStatusuAplikacije.Text = "Subnetiranje dolazi uskoro!";
            this.porukaOStatusuAplikacije.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // downloadLink
            // 
            this.downloadLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadLink.AutoSize = true;
            this.downloadLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.downloadLink.Location = new System.Drawing.Point(399, 54);
            this.downloadLink.Name = "downloadLink";
            this.downloadLink.Size = new System.Drawing.Size(66, 17);
            this.downloadLink.TabIndex = 10;
            this.downloadLink.TabStop = true;
            this.downloadLink.Text = "download";
            this.downloadLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.downloadLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.downloadLink_LinkClicked);
            // 
            // tekstZaDownload
            // 
            this.tekstZaDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tekstZaDownload.AutoSize = true;
            this.tekstZaDownload.Location = new System.Drawing.Point(147, 54);
            this.tekstZaDownload.Name = "tekstZaDownload";
            this.tekstZaDownload.Size = new System.Drawing.Size(255, 17);
            this.tekstZaDownload.TabIndex = 9;
            this.tekstZaDownload.Text = "Najnovija verzija može se skuniti klikom na";
            this.tekstZaDownload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IpKonfiguracijaV6Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(914, 566);
            this.Controls.Add(this.odabirFunkcijeTabs);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.IPv6DisplayTextBox);
            this.Controls.Add(this.DhcpCheckBox);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(495, 395);
            this.Name = "IpKonfiguracijaV6Form";
            this.Text = "IpKonfiguracijaForm";
            this.Load += new System.EventHandler(this.IpKonfiguracijaForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.tipIPv6Grupa.ResumeLayout(false);
            this.tipIPv6Grupa.PerformLayout();
            this.odabirFunkcijeTabs.ResumeLayout(false);
            this.tabIPv6Konfiguracija.ResumeLayout(false);
            this.tabIPv6Konfiguracija.PerformLayout();
            this.dodatneOpcijePanel.ResumeLayout(false);
            this.dodatneOpcijePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validLifeDaysBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validLifeSatiBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preferedLifeSekundeBox)).EndInit();
            this.spremanjeIPv6Grupa.ResumeLayout(false);
            this.spremanjeIPv6Grupa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validLifeMinuteBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preferedLifeMinuteBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validLifeSekundeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preferedLifeSatiBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preferedLifeDaysBox)).EndInit();
            this.tabGatewayKonfiguracija.ResumeLayout(false);
            this.tabGatewayKonfiguracija.PerformLayout();
            this.tabDNSKonfiguracija.ResumeLayout(false);
            this.tabDNSKonfiguracija.PerformLayout();
            this.tabSubnetiranje.ResumeLayout(false);
            this.tabSubnetiranje.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel TopPanel;
        private ComboBox interfaceComboBox;
        private Label interfaceLable;
        private Label IPv4Lable;
        private TextBox ipv6Text;
        private CheckBox DhcpCheckBox;
        private Label defaultGatewayLabel;
        private TextBox defaultGatewayV6Text;
        private Button dodajIPv6AdresuButton;
        private RadioButton unicastRadioButton;
        private RadioButton anycastRadioButton;
        private GroupBox tipIPv6Grupa;
        private RichTextBox IPv6DisplayTextBox;
        private Button refreshButton;
        private TabControl odabirFunkcijeTabs;
        private TabPage tabIPv6Konfiguracija;
        private TabPage tabGatewayKonfiguracija;
        private TabPage tabDNSKonfiguracija;
        private Button obrisiIPv6AdresuButton;
        private Label validTimeLable;
        private NumericUpDown validLifeDaysBox;
        private Label validLifeDaysLable;
        private NumericUpDown validLifeSatiBox;
        private Label validLifeSatiLable;
        private NumericUpDown validLifeMinuteBox;
        private Label validLifeMinuteLable;
        private NumericUpDown validLifeSekundeBox;
        private Label validLifeSekundeLable;
        private CheckBox validLifeCheckBox;
        private CheckBox preferedLifeCheckBox;
        private NumericUpDown preferedLifeSekundeBox;
        private Label preferedLifeSekundeLable;
        private NumericUpDown preferedLifeMinuteBox;
        private Label preferedLifeMinuteLable;
        private NumericUpDown preferedLifeSatiBox;
        private Label preferedLifeSatiLable;
        private NumericUpDown preferedLifeDaysBox;
        private Label preferedLifeDaysLable;
        private Label preferedTimeLable;
        private GroupBox spremanjeIPv6Grupa;
        private RadioButton storePersistentRadioButton;
        private RadioButton storeActiveRadioButton;
        private CheckBox skipAsSourceCheckBox;
        private Button resetToDefaultAdresaButton;
        private TabPage tabSubnetiranje;
        private LinkLabel downloadLink;
        private Label tekstZaDownload;
        private Label porukaOStatusuAplikacije;
        private Button pokaziNaprednoButton;
        private Panel dodatneOpcijePanel;
        private Button obrisiGatewayButton;
        private Button dodajGatewayButton;
        private Button obrisiDnsButton;
        private Label dnsV6Lable;
        private Button dodajDnsButton;
        private TextBox dnsV6Text;
        private TextBox dnsPrefixText;
        private CheckBox obrisiSveDNSCheckBox;
    }
}