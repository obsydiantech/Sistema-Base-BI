using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Base_BI.Forms
{
    public partial class StartForm : Form
    {
        int count = 0, buffer = 0;
        public StartForm()
        {
            InitializeComponent();
            Opacity = 0;
            StartFormTimer1.Start();
        }


        //EFECTO DE OPACIDAD EN STARTFORM - PRESENTACIÓN OBSYDIAN.
        //TIMER 1
        private void StartFormTimer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                StartFormTimer2.Start();
                StartFormTimer1.Stop();
            }
            else
            {
                count++;
                Opacity = count * 0.01;
            }
        }      
        //TIMER 2
        private void StartFormTimer2_Tick(object sender, EventArgs e)
        {
            if (buffer == 3)
            {
                StartFormTimer3.Start();
                StartFormTimer2.Stop();
            }
            else
            {
                buffer++;
            }
        }
        //TIMER 3
        private void StartFormTimer3_Tick(object sender, EventArgs e)
        {
            if (Opacity ==0)
            {
                MainForms.LoginForm mf1 = new MainForms.LoginForm();
                mf1.Show();
                Hide();
                StartFormTimer3.Stop();
            }
            else
            {
                count--;
                Opacity = count * 0.01;
            }
        }









    }

    
}
