using System;

namespace Sistema_Base_BI.Managers
{
    public class ExceptionManager // Singleton
    {
        // |---------------Atributos---------------|
        private static ExceptionManager instance;
        public static ExceptionManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new ExceptionManager();

                return instance;
            }
        }

        // |---------------Constructores---------------|
        private ExceptionManager()
        {

        }

        // |---------------Métodos Públicos---------------|

        public void CatchException(Exception e)
        {
            LogManager.Instance.EscribirLog(e.ToString());
        }

        public void CatchException(Exception e, String userMessage)
        {
            LogManager.Instance.EscribirLog(e.ToString());
            MessagesManager.Instance.NewErrorMessage(userMessage);
        }

        // |---------------Métodos Privados---------------|
    }
}
