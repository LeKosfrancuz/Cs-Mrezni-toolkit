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
            this.ipv6PrefixText = new System.Windows.Forms.TextBox();
            this.primjeniPostavkeButton = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
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
            this.TopPanel.Size = new System.Drawing.Size(707, 52);
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
            this.interfaceComboBox.FormattingEnabled = true;
            this.interfaceComboBox.Location = new System.Drawing.Point(231, 13);
            this.interfaceComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.interfaceComboBox.Name = "interfaceComboBox";
            this.interfaceComboBox.Size = new System.Drawing.Size(140, 25);
            this.interfaceComboBox.TabIndex = 0;
            this.interfaceComboBox.SelectedIndexChanged += new System.EventHandler(this.interfaceComboBoxSelectionChanged);
            // 
            // IPv4Lable
            // 
            this.IPv4Lable.AutoSize = true;
            this.IPv4Lable.Location = new System.Drawing.Point(13, 118);
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
            this.ipv6Text.Location = new System.Drawing.Point(123, 115);
            this.ipv6Text.Name = "ipv6Text";
            this.ipv6Text.Size = new System.Drawing.Size(214, 18);
            this.ipv6Text.TabIndex = 3;
            this.ipv6Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DhcpCheckBox
            // 
            this.DhcpCheckBox.AutoSize = true;
            this.DhcpCheckBox.Location = new System.Drawing.Point(14, 76);
            this.DhcpCheckBox.Name = "DhcpCheckBox";
            this.DhcpCheckBox.Size = new System.Drawing.Size(111, 21);
            this.DhcpCheckBox.TabIndex = 2;
            this.DhcpCheckBox.Text = "DHCP Enabled";
            this.DhcpCheckBox.UseVisualStyleBackColor = true;
            this.DhcpCheckBox.CheckStateChanged += new System.EventHandler(this.DhcpCheckChanged);
            // 
            // defaultGatewayLabel
            // 
            this.defaultGatewayLabel.AutoSize = true;
            this.defaultGatewayLabel.Location = new System.Drawing.Point(12, 154);
            this.defaultGatewayLabel.Name = "defaultGatewayLabel";
            this.defaultGatewayLabel.Size = new System.Drawing.Size(108, 17);
            this.defaultGatewayLabel.TabIndex = 11;
            this.defaultGatewayLabel.Text = "Default gateway :";
            // 
            // defaultGatewayV6Text
            // 
            this.defaultGatewayV6Text.BackColor = System.Drawing.Color.Snow;
            this.defaultGatewayV6Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.defaultGatewayV6Text.Location = new System.Drawing.Point(123, 154);
            this.defaultGatewayV6Text.Name = "defaultGatewayV6Text";
            this.defaultGatewayV6Text.Size = new System.Drawing.Size(242, 18);
            this.defaultGatewayV6Text.TabIndex = 11;
            this.defaultGatewayV6Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ipv6PrefixText
            // 
            this.ipv6PrefixText.BackColor = System.Drawing.Color.Snow;
            this.ipv6PrefixText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipv6PrefixText.Location = new System.Drawing.Point(333, 115);
            this.ipv6PrefixText.Name = "ipv6PrefixText";
            this.ipv6PrefixText.Size = new System.Drawing.Size(32, 18);
            this.ipv6PrefixText.TabIndex = 7;
            this.ipv6PrefixText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // primjeniPostavkeButton
            // 
            this.primjeniPostavkeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.primjeniPostavkeButton.BackColor = System.Drawing.Color.PaleGreen;
            this.primjeniPostavkeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.primjeniPostavkeButton.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.primjeniPostavkeButton.FlatAppearance.BorderSize = 2;
            this.primjeniPostavkeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.primjeniPostavkeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.primjeniPostavkeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.primjeniPostavkeButton.Location = new System.Drawing.Point(524, 288);
            this.primjeniPostavkeButton.Name = "primjeniPostavkeButton";
            this.primjeniPostavkeButton.Size = new System.Drawing.Size(119, 49);
            this.primjeniPostavkeButton.TabIndex = 15;
            this.primjeniPostavkeButton.Text = "Primjeni promjene";
            this.primjeniPostavkeButton.UseVisualStyleBackColor = false;
            this.primjeniPostavkeButton.Click += new System.EventHandler(this.primjeniPostavkeButton_Click);
            // 
            // IpKonfiguracijaV6Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(707, 385);
            this.Controls.Add(this.primjeniPostavkeButton);
            this.Controls.Add(this.ipv6PrefixText);
            this.Controls.Add(this.defaultGatewayLabel);
            this.Controls.Add(this.DhcpCheckBox);
            this.Controls.Add(this.ipv6Text);
            this.Controls.Add(this.defaultGatewayV6Text);
            this.Controls.Add(this.IPv4Lable);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(442, 237);
            this.Name = "IpKonfiguracijaV6Form";
            this.Text = "IpKonfiguracijaForm";
            this.Load += new System.EventHandler(this.IpKonfiguracijaForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
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
        private TextBox ipv6PrefixText;
        private Button primjeniPostavkeButton;
    }
}