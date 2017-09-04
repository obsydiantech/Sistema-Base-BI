using System;
using System.Windows.Forms;

using Sistema_Base_BI.Forms;

namespace Sistema_Base_BI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Forms.LoginForm loginForm = new LoginForm();

            Main main = new Main(loginForm);

            Application.Run(loginForm);
        }
    }
}
