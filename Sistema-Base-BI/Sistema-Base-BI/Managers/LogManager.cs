using System;
using System.IO;

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

        private StreamWriter streamWriter;

        // |---------------Constructores---------------|
        private LogManager()
        {

        }

        // |---------------Métodos Públicos---------------|

        public void EscribirLog(String log)
        {
            try
            {
                streamWriter = new StreamWriter(NamesManager.ERROR_LOGS_FILEPATH, true);
                streamWriter.WriteLine("[" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "]" + log);
                streamWriter.Close();
            }
            catch (IOException e)
            {
                streamWriter = new StreamWriter(NamesManager.Instance.DESKTOP_PATH + "\\error_logs.txt", true);
                streamWriter.Write(log);
                streamWriter.Close();
                MessagesManager.Instance.NewErrorMessage("No se pudo escribir el log correctamente.\nSe generó el error_log en el escritorio.");
            }
        }

        // |---------------Métodos Privados---------------|


    }
}
