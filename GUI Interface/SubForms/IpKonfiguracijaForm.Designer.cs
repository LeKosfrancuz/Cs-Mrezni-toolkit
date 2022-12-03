namespace GUI_Interface
{
    partial class IpKonfiguracijaForm
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
            this.mreznaMaskaText1 = new System.Windows.Forms.TextBox();
            this.mreznaMaskaLable = new System.Windows.Forms.Label();
            this.mreznaMaskaText2 = new System.Windows.Forms.TextBox();
            this.mreznaMaskaText3 = new System.Windows.Forms.TextBox();
            this.ipv4Text1 = new System.Windows.Forms.TextBox();
            this.ipv4Text2 = new System.Windows.Forms.TextBox();
            this.ipv4Text3 = new System.Windows.Forms.TextBox();
            this.ipv4Text4 = new System.Windows.Forms.TextBox();
            this.DhcpCheckBox = new System.Windows.Forms.CheckBox();
            this.mreznaMaskaText4 = new System.Windows.Forms.TextBox();
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
            this.interfaceLable.Location = new System.Drawing.Point(68, 12);
            this.interfaceLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.interfaceLable.Name = "interfaceLable";
            this.interfaceLable.Size = new System.Drawing.Size(207, 17);
            this.interfaceLable.TabIndex = 1;
            this.interfaceLable.Text = "Odaberi mrežnu karticu/adapter : ";
            // 
            // interfaceComboBox
            // 
            this.interfaceComboBox.FormattingEnabled = true;
            this.interfaceComboBox.Location = new System.Drawing.Point(316, 8);
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
            this.IPv4Lable.Size = new System.Drawing.Size(87, 17);
            this.IPv4Lable.TabIndex = 2;
            this.IPv4Lable.Text = "IPv4 Adresa : ";
            // 
            // mreznaMaskaText1
            // 
            this.mreznaMaskaText1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mreznaMaskaText1.Location = new System.Drawing.Point(123, 149);
            this.mreznaMaskaText1.Name = "mreznaMaskaText1";
            this.mreznaMaskaText1.Size = new System.Drawing.Size(33, 18);
            this.mreznaMaskaText1.TabIndex = 4;
            // 
            // mreznaMaskaLable
            // 
            this.mreznaMaskaLable.AutoSize = true;
            this.mreznaMaskaLable.Location = new System.Drawing.Point(14, 149);
            this.mreznaMaskaLable.Name = "mreznaMaskaLable";
            this.mreznaMaskaLable.Size = new System.Drawing.Size(100, 17);
            this.mreznaMaskaLable.TabIndex = 5;
            this.mreznaMaskaLable.Text = "Mrežna maska :";
            // 
            // mreznaMaskaText2
            // 
            this.mreznaMaskaText2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mreznaMaskaText2.Location = new System.Drawing.Point(162, 149);
            this.mreznaMaskaText2.Name = "mreznaMaskaText2";
            this.mreznaMaskaText2.Size = new System.Drawing.Size(35, 18);
            this.mreznaMaskaText2.TabIndex = 6;
            // 
            // mreznaMaskaText3
            // 
            this.mreznaMaskaText3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mreznaMaskaText3.Location = new System.Drawing.Point(203, 149);
            this.mreznaMaskaText3.Name = "mreznaMaskaText3";
            this.mreznaMaskaText3.Size = new System.Drawing.Size(34, 18);
            this.mreznaMaskaText3.TabIndex = 7;
            // 
            // ipv4Text1
            // 
            this.ipv4Text1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipv4Text1.Location = new System.Drawing.Point(123, 115);
            this.ipv4Text1.Name = "ipv4Text1";
            this.ipv4Text1.Size = new System.Drawing.Size(33, 18);
            this.ipv4Text1.TabIndex = 9;
            // 
            // ipv4Text2
            // 
            this.ipv4Text2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipv4Text2.Location = new System.Drawing.Point(164, 115);
            this.ipv4Text2.Name = "ipv4Text2";
            this.ipv4Text2.Size = new System.Drawing.Size(33, 18);
            this.ipv4Text2.TabIndex = 9;
            // 
            // ipv4Text3
            // 
            this.ipv4Text3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipv4Text3.Location = new System.Drawing.Point(203, 115);
            this.ipv4Text3.Name = "ipv4Text3";
            this.ipv4Text3.Size = new System.Drawing.Size(33, 18);
            this.ipv4Text3.TabIndex = 9;
            // 
            // ipv4Text4
            // 
            this.ipv4Text4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipv4Text4.Location = new System.Drawing.Point(243, 115);
            this.ipv4Text4.Name = "ipv4Text4";
            this.ipv4Text4.Size = new System.Drawing.Size(33, 18);
            this.ipv4Text4.TabIndex = 9;
            // 
            // DhcpCheckBox
            // 
            this.DhcpCheckBox.AutoSize = true;
            this.DhcpCheckBox.Location = new System.Drawing.Point(14, 76);
            this.DhcpCheckBox.Name = "DhcpCheckBox";
            this.DhcpCheckBox.Size = new System.Drawing.Size(111, 21);
            this.DhcpCheckBox.TabIndex = 10;
            this.DhcpCheckBox.Text = "DHCP Enabled";
            this.DhcpCheckBox.UseVisualStyleBackColor = true;
            this.DhcpCheckBox.CheckStateChanged += new System.EventHandler(this.DhcpCheckChanged);
            // 
            // mreznaMaskaText4
            // 
            this.mreznaMaskaText4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mreznaMaskaText4.Location = new System.Drawing.Point(243, 149);
            this.mreznaMaskaText4.Name = "mreznaMaskaText4";
            this.mreznaMaskaText4.Size = new System.Drawing.Size(32, 18);
            this.mreznaMaskaText4.TabIndex = 8;
            // 
            // IpKonfiguracijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(707, 385);
            this.Controls.Add(this.DhcpCheckBox);
            this.Controls.Add(this.ipv4Text4);
            this.Controls.Add(this.ipv4Text3);
            this.Controls.Add(this.ipv4Text2);
            this.Controls.Add(this.ipv4Text1);
            this.Controls.Add(this.mreznaMaskaText4);
            this.Controls.Add(this.mreznaMaskaText3);
            this.Controls.Add(this.mreznaMaskaText2);
            this.Controls.Add(this.mreznaMaskaLable);
            this.Controls.Add(this.mreznaMaskaText1);
            this.Controls.Add(this.IPv4Lable);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "IpKonfiguracijaForm";
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
        private TextBox mreznaMaskaText1;
        private Label mreznaMaskaLable;
        private TextBox mreznaMaskaText2;
        private TextBox mreznaMaskaText3;
        private TextBox ipv4Text1;
        private TextBox ipv4Text2;
        private TextBox ipv4Text3;
        private TextBox ipv4Text4;
        private CheckBox DhcpCheckBox;
        private TextBox mreznaMaskaText4;
    }
}