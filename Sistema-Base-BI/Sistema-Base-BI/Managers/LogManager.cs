using System;

namespace Sistema_Base_BI.Managers
{
    public class LogManager // Singleton
    {
        // |---------------Atributos---------------|
        private static LogManager instance;
        public static LogManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new LogManager();

                return instance;
            }
        }

        // |---------------Constructores---------------|
        private LogManager()
        {

        }

        // |---------------Métodos Públicos---------------|

        public void EscribirLog(String log)
        {
            if(!FileManager.Instance.WriteFile(NamesPathsManager.Instance.ERROR_LOGS_FILEPATH, "[" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "]" + log));
                MessagesManager.Instance.NewErrorMessage("No se pudo escribir el log correctamente.\nSe generó el error_log en el escritorio.");
        }

        // |---------------Métodos Privados---------------|


    }
}
