using System;
using System.ComponentModel;

using Sistema_Base_BI.Forms;
using System.Reflection;


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
        private String asyncMethod;
        private String finishCallback;
        private Object obj;
        private LoadingForm loadingForm;

        // |---------------Constructores---------------|
        private LoadingManager()
        {
            asyncMethod = "";
        }

        // |---------------Métodos Públicos---------------|

        public void EjecutarTareaEnSegundoPlano(Boolean displayLoadingForm, Object obj, String asyncMethod, String finishCallback, params String[] parameters)
        {
            this.obj = obj;
            this.asyncMethod = asyncMethod;
            this.finishCallback = finishCallback;

            bgWorker = new BackgroundWorker();
            bgWorker.RunWorkerCompleted += BgWorker_RunWorkerCompleted;
            bgWorker.DoWork += BgWorker_DoWork;
            bgWorker.WorkerSupportsCancellation = false;

            if (displayLoadingForm)
                (loadingForm = new LoadingForm()).Show();


            bgWorker.RunWorkerAsync();
        }

        // |---------------Métodos Privados---------------|

        // |-------------------Eventos--------------------|

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Type type = obj.GetType();
            MethodInfo theMethod = type.GetMethod(asyncMethod);
            theMethod.Invoke(obj, null);
        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (loadingForm != null)
            {
                loadingForm.Close();
                loadingForm = null;
            }

            if (!finishCallback.Equals(String.Empty))
            {
                Type type = obj.GetType();
                MethodInfo theMethod = type.GetMethod(finishCallback);
                theMethod.Invoke(obj, null);
            }
        }
    }
}
