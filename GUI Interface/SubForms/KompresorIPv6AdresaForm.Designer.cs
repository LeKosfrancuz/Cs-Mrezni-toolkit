namespace GUI_Interface.SubForms
{
    partial class KompresorIPv6AdresaForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ipv6DeCompresed = new System.Windows.Forms.TextBox();
            this.ipv6Compresed = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ipv6DeCompresed);
            this.panel1.Location = new System.Drawing.Point(21, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 126);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(858, 91);
            this.button1.TabIndex = 2;
            this.button1.Text = "DeKompresirana IPv6 Adresa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ipv6DeCompresed
            // 
            this.ipv6DeCompresed.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ipv6DeCompresed.Location = new System.Drawing.Point(0, 91);
            this.ipv6DeCompresed.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ipv6DeCompresed.Name = "ipv6DeCompresed";
            this.ipv6DeCompresed.Size = new System.Drawing.Size(858, 35);
            this.ipv6DeCompresed.TabIndex = 1;
            this.ipv6DeCompresed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ipv6DeCompresed.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DeKompres_KeyUp);
            // 
            // ipv6Compresed
            // 
            this.ipv6Compresed.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ipv6Compresed.Location = new System.Drawing.Point(0, 81);
            this.ipv6Compresed.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ipv6Compresed.Name = "ipv6Compresed";
            this.ipv6Compresed.Size = new System.Drawing.Size(858, 35);
            this.ipv6Compresed.TabIndex = 1;
            this.ipv6Compresed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ipv6Compresed.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Kompress_KeyUP);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.ipv6Compresed);
            this.panel2.Location = new System.Drawing.Point(21, 258);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(858, 116);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Noto Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(858, 81);
            this.button2.TabIndex = 2;
            this.button2.Text = "Kompresirana (skraćena) IPv6 Adresa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // KompresorIPv6AdresaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 451);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "KompresorIPv6AdresaForm";
            this.Text = "KompresorIPv6AdresaForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button1;
        private TextBox ipv6DeCompresed;
        private TextBox ipv6Compresed;
        private Panel panel2;
        private Button button2;
    }
}