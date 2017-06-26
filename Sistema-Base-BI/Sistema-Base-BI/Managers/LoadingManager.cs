using System;
using System.ComponentModel;

using System.Windows.Forms;


namespace Sistema_Base_BI.Managers
{
    public class LoadingManager // Singleton
    {
        // |---------------Atributos---------------|
        private static LoadingManager instance;
        public static LoadingManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoadingManager();

                return instance;
            }
        }
        private BackgroundWorker bgWorker;

        // |---------------Constructores---------------|
        private LoadingManager()
        {

        }

        // |---------------Métodos Públicos---------------|

        public void ejecutarTareaEnSegundoPlano(String fullMethodAccess)
        {
            bgWorker = new BackgroundWorker();
            bgWorker.RunWorkerCompleted += BgWorker_RunWorkerCompleted;
            bgWorker.DoWork += BgWorker_DoWork;
            bgWorker.WorkerSupportsCancellation = false;
            bgWorker.RunWorkerAsync();
        }

        // |---------------Métodos Privados---------------|

        // |-------------------Eventos--------------------|

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Leído por el thread UI
            MessagesManager.Instance.NewInformationMessage("bgWorker ended!");
        }

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Leído por el thread bgWorker
            System.Threading.Thread.Sleep(5000);
        }
    }
}
