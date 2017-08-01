using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Sistema_Base_BI.Forms.Admin_Forms.Users;

namespace Sistema_Base_BI.Forms.MainForms
{
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_NewUser_Click(object sender, EventArgs e)
        {
            NewUserForm nuf = new NewUserForm();
            nuf.Show();
        }

        private void LoginForm_LoginButton_Click(object sender, EventArgs e)
        {
            if ( LoginForm_UserTextBox.Text == "usuario" && LoginForm_PassTextBox.Text == "password")
            {
                MainForm mf = new MainForm();
                this.Hide();
                mf.Show();

            } else
            {
                MetroFramework.MetroMessageBox.Show(this, "Usuario o contraseña incorrectos", "Error de acceso",MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            }
        }

        private void LoginForm_LicenceButton_Click(object sender, EventArgs e)
        {
            Forms.Admin_Forms.Management.LicenciaForm lf = new Forms.Admin_Forms.Management.LicenciaForm();
            lf.Show();
        }
    }
}
