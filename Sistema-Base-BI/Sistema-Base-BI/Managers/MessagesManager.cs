using System;
using System.Windows.Forms;

namespace Sistema_Base_BI.Managers
{
    public class MessagesManager // Singleton
    {
        // |---------------Atributos---------------|
        private static MessagesManager instance;
        public static MessagesManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new MessagesManager();

                return instance;
            }
        }
        private String[] titulos;

        // |---------------Constructores---------------|
        private MessagesManager()
        {
            titulos = new String[] { "Información", "Confirmación", "ADVERTENCIA" };
        }

        // |---------------Métodos Públicos---------------|
        public void NewInformationMessage(String message)
        {
            MessageBox.Show(message, titulos[1]);
        }

        public Boolean NewConfirmMessage(String message)
        {
            if (MessageBox.Show(message, titulos[1], MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                return true;
            else
                return false;
        }

        public void NewErrorMessage(String message)
        {
            MessageBox.Show(message + "\n\nPorfavor, contacte al Programador.", titulos[2]);
        }

        // |---------------Métodos Privados---------------|
    }
}
