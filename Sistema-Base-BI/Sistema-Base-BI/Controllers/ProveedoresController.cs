using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Base_BI.Controllers
{
    class ProveedoresController
    {
        // |---------------Atributos---------------|
        private static ProveedoresController instance;
        public static ProveedoresController Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProveedoresController();

                return instance;
            }
        }

        // |---------------Constructores---------------|
        private ProveedoresController()
        {
            Init();
        }

        // |---------------Métodos Públicos---------------|
        public Boolean Init()
        {
                return true;
        }

        // |---------------Métodos Privados---------------|

        // |-------------------Eventos--------------------|
    }
}
