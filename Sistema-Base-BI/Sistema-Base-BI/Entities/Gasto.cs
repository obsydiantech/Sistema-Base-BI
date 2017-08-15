using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Base_BI.Entities
{
    class Gasto
    {
        // |---------------Atributos--------------------|
        private int id;
        private String nombre;
        private String descripcion;
        private float monto;
        private DateTime fechaPago;


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
        public String Nombre
        {
            get
            {
                return this.nombre;
            }

            set
            {
                this.nombre = value;
            }
        }
        public String Descripcion
        {
            get
            {
                return this.descripcion;
            }

            set
            {
                this.descripcion = value;
            }
        }
        public float Monto
        {
            get
            {
                return this.monto;
            }

            set
            {
                this.monto = value;
            }
        }
        public DateTime FechaPago
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

        // |---------------Constructores----------------|

        private Gasto()
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
