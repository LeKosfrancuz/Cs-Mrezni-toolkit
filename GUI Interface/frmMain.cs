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

namespace GUI_Interface;

public partial class frmMain : Form
{
    public static Form AktivanForm { get; set; }
    public frmMain()
    {
        InitializeComponent();
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
        OtvoriSubForm(new IpKonfiguracijaForm());
    }

    private void Alati_IpKonfiguracija_IPv4_Click(object sender, EventArgs e)
    {
        OtvoriSubForm(new IpKonfiguracijaForm());
        naslovnaGrupaZaSubForms.Text = alati_IpKonfiguracijaMenuItem.Text;
    }
}
