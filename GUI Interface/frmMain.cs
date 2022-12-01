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

namespace GUI_Interface
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            NetworkInterface[] networkInterfaces = IP_konfiguracija.GetEAdapters();
            int nIn = networkInterfaces.Count();

            for (int i = 0; i < nIn; i++)
                this.cmbInterface.Items.Add(networkInterfaces[i].Name);
        }

        private void cmbInterface_Click(object sender, EventArgs e)
        {

        }
    }
}
