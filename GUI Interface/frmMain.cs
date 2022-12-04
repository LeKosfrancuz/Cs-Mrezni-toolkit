using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MrezneFunkcije.IP;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_Interface;

public partial class frmMain : Form
{
    public static Form AktivanForm { get; set; }
    public List<IP_konfiguracija.Adapter> MrezniAdapteri{ get; set; }
    public frmMain()
    {
        InitializeComponent();
        MrezniAdapteri = IP_konfiguracija.GetListOfAdapters();
    }

    private void GetAllMrezniAdapteri()
    {        
        Thread AnimateProgressBar
        = new Thread(() => ProgresProcesObnoviAdaptere(progressBar, progressBarLable));
        AnimateProgressBar.Start();
        Cursor = Cursors.WaitCursor;
        MrezniAdapteri = IP_konfiguracija.GetListOfAdapters();
        Cursor = Cursors.Default;
    }

    private void OtvoriSubForm(Form SubForm)
    {
        if (AktivanForm != null)
        {
            AktivanForm.Close();
        }

        AktivanForm = SubForm;

        SubForm.TopLevel = false;
        SubForm.FormBorderStyle = FormBorderStyle.None;
        SubForm.Dock = DockStyle.Fill;

        this.SubFormPanel.Controls.Add(SubForm);

        SubForm.BringToFront();
        SubForm.Show();

    }

    private void frmMain_Load(object sender, EventArgs e)
    {
        progressBarStrip.Visible = true;
        progressBar.Visible = false;
        progressBarLable.Visible = false;

        //OtvoriSubForm(new IpKonfiguracijaForm(progressBarStrip));
    }

    private void Alati_IpKonfiguracija_IPv4_Click(object sender, EventArgs e)
    {
        OtvoriSubForm(new IpKonfiguracijaForm(MrezniAdapteri, progressBar, progressBarLable));
        naslovnaGrupaZaSubForms.Text = alati_IpKonfiguracijaMenuItem.Text;
    }

    private void alati_ReloadMrezniAdapteriMenuItem_Click(object sender, EventArgs e)
    {
        GetAllMrezniAdapteri();
    }

    private void ProgresProcesObnoviAdaptere(ToolStripProgressBar progressBar, ToolStripStatusLabel toolStripLable)
    {
        progressBar.Visible = true;
        progressBarLable.Visible = true;
        progressBar.Minimum = 0;
        progressBar.Maximum = 100;
        progressBarLable.Text = "Dohvaćam mrežne adaptere...";
        for (int i = 0; i <= 100; i+=2)
        {
            if (i == 60) progressBarLable.Text = "Obnavljam listu mrežnih adaptera...";
            progressBar.Value = i;
            if ( i % 2 == 0 ) Thread.Sleep(4);
        }
        progressBar.Visible = false;
        progressBarLable.Visible = false;
    }
}
