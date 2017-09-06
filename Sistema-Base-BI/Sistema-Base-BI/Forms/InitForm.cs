using System;
using System.Windows.Forms;

using Sistema_Base_BI.Managers;

namespace Sistema_Base_BI.Forms
{
    public partial class InitForm : Form
    {
        // |---------------Atributos---------------|

        private int count;
        private int buffer;

        // |---------------Constructores---------------|

        public InitForm()
        {
            InitializeComponent();

            count = 0;
            buffer = 0;

            Opacity = 0;
            fadingInTimer.Start();
        }

        // |---------------Métodos Públicos---------------|

        public void Load()
        {
            // Managers
            ConfigManager.Instance.Init();
            DBManager.Instance.Init();
            FileManager.Instance.Init();
            NamesPathsManager.Instance.Init();
        }

        // |---------------Métodos Privados---------------|

        // |-------------------Eventos--------------------|

        private void FadingIn_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                fadingInTimer.Stop();
                LoadingManager.Instance.EjecutarTareaEnSegundoPlano(false, this, "Load", "OnLoadFinished");
            }
            else
            {
                count++;
                Opacity = count * 0.01;
            }
        }

        public void OnLoadFinished()
        {
            fadingInTimer.Stop();
            fadingOutTimer.Start();
        }

        private void FadingOut_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                fadingOutTimer.Stop();
                LoginForm mf1 = new LoginForm();
                mf1.Show();
                Hide();
            }
            else
            {
                count--;
                Opacity = count * 0.01;
            }
        }
    }
}
