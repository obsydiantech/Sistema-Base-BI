using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Base_BI.Entities
{
    class Sueldo
    {
        // |---------------Atributos--------------------|
        private int id;
        private int fechaPago;
        private int importeBruto;
        private int importeNeto;


        public int ID
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
            }
        }
        public int FechaPago
        {
            get
            {
                return this.fechaPago;
            }

            set
            {
                this.fechaPago = value;
            }
        }
        public int ImporteBruto
        {
            get
            {
                return this.importeBruto;
            }

            set
            {
                this.importeBruto = value;
            }
        }
        public int ImporteNeto
        {
            get
            {
                return this.importeNeto;
            }

            set
            {
                this.importeNeto = value;
            }
        }

        // |---------------Constructores----------------|

        private Sueldo()
        {
            Init();
        }

        // |---------------Métodos Públicos--------------|

        // |---------------Métodos Privados---------------|

        private Boolean Init()
        {
            return true;
        }

        // |-------------------Eventos--------------------|
    }
}
