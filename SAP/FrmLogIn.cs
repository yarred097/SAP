using SAP.VIEW;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAP
{
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void btnAcced_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals("") || txtPass.Text.Equals(""))
            {
                MessageBox.Show("INGRESAR USUARIO Y CONTRASEÑA");
            }
            else
            {
                if (txtUser.Text.Equals("admin") && txtPass.Text.Equals("76543210"))
                {
                    FrmMain frm = new FrmMain();
                    frm.Show();
                    this.Hide();
                    txtUser.Text = "";
                    txtPass.Text = "";
                }
                else
                {
                    MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTOS");
                }
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtUser.ForeColor = Color.Black;
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            txtPass.Text = "";
            txtPass.ForeColor = Color.Black;
            txtPass.PasswordChar = '*';
        }

    }
}
