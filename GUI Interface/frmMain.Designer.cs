namespace GUI_Interface
{
    partial class frmMain
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
            this.glavniIzbornik = new System.Windows.Forms.MenuStrip();
            this.alatiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alati_IpKonfiguracijaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Alati_IpKonfiguracija_IPv4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Alati_IpKonfiguracija_IPv6 = new System.Windows.Forms.ToolStripMenuItem();
            this.SubFormPanel = new System.Windows.Forms.Panel();
            this.naslovnaGrupaZaSubForms = new System.Windows.Forms.GroupBox();
            this.glavniIzbornik.SuspendLayout();
            this.naslovnaGrupaZaSubForms.SuspendLayout();
            this.SuspendLayout();
            // 
            // glavniIzbornik
            // 
            this.glavniIzbornik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alatiMenuItem});
            this.glavniIzbornik.Location = new System.Drawing.Point(0, 0);
            this.glavniIzbornik.Name = "glavniIzbornik";
            this.glavniIzbornik.Size = new System.Drawing.Size(800, 24);
            this.glavniIzbornik.TabIndex = 0;
            this.glavniIzbornik.Text = "menuStrip1";
            // 
            // alatiMenuItem
            // 
            this.alatiMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alati_IpKonfiguracijaMenuItem});
            this.alatiMenuItem.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alatiMenuItem.Name = "alatiMenuItem";
            this.alatiMenuItem.Size = new System.Drawing.Size(43, 20);
            this.alatiMenuItem.Text = "&Alati";
            // 
            // alati_IpKonfiguracijaMenuItem
            // 
            this.alati_IpKonfiguracijaMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Alati_IpKonfiguracija_IPv4,
            this.toolStripSeparator1,
            this.Alati_IpKonfiguracija_IPv6});
            this.alati_IpKonfiguracijaMenuItem.Name = "alati_IpKonfiguracijaMenuItem";
            this.alati_IpKonfiguracijaMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alati_IpKonfiguracijaMenuItem.Text = "&IP Konfiguracija";
            // 
            // Alati_IpKonfiguracija_IPv4
            // 
            this.Alati_IpKonfiguracija_IPv4.Name = "Alati_IpKonfiguracija_IPv4";
            this.Alati_IpKonfiguracija_IPv4.Size = new System.Drawing.Size(180, 22);
            this.Alati_IpKonfiguracija_IPv4.Text = "IPv4";
            this.Alati_IpKonfiguracija_IPv4.Click += new System.EventHandler(this.Alati_IpKonfiguracija_IPv4_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // Alati_IpKonfiguracija_IPv6
            // 
            this.Alati_IpKonfiguracija_IPv6.Name = "Alati_IpKonfiguracija_IPv6";
            this.Alati_IpKonfiguracija_IPv6.Size = new System.Drawing.Size(180, 22);
            this.Alati_IpKonfiguracija_IPv6.Text = "IPv6";
            this.Alati_IpKonfiguracija_IPv6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // SubFormPanel
            // 
            this.SubFormPanel.AccessibleDescription = "Panel za sve sub formove";
            this.SubFormPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubFormPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SubFormPanel.BackColor = System.Drawing.Color.MistyRose;
            this.SubFormPanel.Location = new System.Drawing.Point(6, 24);
            this.SubFormPanel.Name = "SubFormPanel";
            this.SubFormPanel.Size = new System.Drawing.Size(764, 441);
            this.SubFormPanel.TabIndex = 2;
            // 
            // naslovnaGrupaZaSubForms
            // 
            this.naslovnaGrupaZaSubForms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.naslovnaGrupaZaSubForms.BackColor = System.Drawing.Color.Transparent;
            this.naslovnaGrupaZaSubForms.Controls.Add(this.SubFormPanel);
            this.naslovnaGrupaZaSubForms.Location = new System.Drawing.Point(12, 27);
            this.naslovnaGrupaZaSubForms.Name = "naslovnaGrupaZaSubForms";
            this.naslovnaGrupaZaSubForms.Size = new System.Drawing.Size(776, 471);
            this.naslovnaGrupaZaSubForms.TabIndex = 3;
            this.naslovnaGrupaZaSubForms.TabStop = false;
            this.naslovnaGrupaZaSubForms.Text = "Nije odabrana funkcija";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.naslovnaGrupaZaSubForms);
            this.Controls.Add(this.glavniIzbornik);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.glavniIzbornik;
            this.Name = "frmMain";
            this.Text = "Mrežni toolkit";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.glavniIzbornik.ResumeLayout(false);
            this.glavniIzbornik.PerformLayout();
            this.naslovnaGrupaZaSubForms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip glavniIzbornik;
        private ToolStripMenuItem alatiMenuItem;
        private ToolStripMenuItem alati_IpKonfiguracijaMenuItem;
        private Panel SubFormPanel;
        private GroupBox naslovnaGrupaZaSubForms;
        private ToolStripMenuItem Alati_IpKonfiguracija_IPv4;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem Alati_IpKonfiguracija_IPv6;
    }
}