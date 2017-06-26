using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Base_BI.Managers
{
    public class CloseManager // Singleton
    {
        // |---------------Atributos---------------|
        private static CloseManager instance;
        public static CloseManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new CloseManager();

                return instance;
            }
        }

        // |---------------Constructores---------------|
        private CloseManager()
        {

        }

        // |---------------Métodos Públicos---------------|

        public void CloseWholeApp()
        {
            Environment.Exit(0);
        }

        // |---------------Métodos Privados---------------|
    }
}
