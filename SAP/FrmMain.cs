using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAP.VIEW
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            if (pInventory.Height == 30)
            {
                pInventory.Height = 150;
            }
            else
            {
                pInventory.Height = 30;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            pInventory.Height = 30;
        }

        private void btnEoq_Click(object sender, EventArgs e)
        {
            FrmEoq frm = new FrmEoq();
            frm.ShowDialog();
        }
    }
}
