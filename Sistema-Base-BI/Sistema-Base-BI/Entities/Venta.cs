using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Base_BI.Entities
{
    public class Venta
    {
        // |---------------Atributos--------------------|
        private int id;
        private int idCliente;
        private int idProducto;
        private float importeBruto;
        private float importeNeto;
        private DateTime fecha;


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
        public int IDCliente
        {
            get
            {
                return this.idCliente;
            }

            set
            {
                this.idCliente = value;
            }
        }
        public int IDProducto
        {
            get
            {
                return this.idProducto;
            }

            set
            {
                this.idProducto = value;
            }
        }
        public float ImporteBruto
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
        public float ImporteNeto
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
        public DateTime Fecha
        {
            get
            {
                return this.fecha;
            }

            set
            {
                this.fecha = value;
            }
        }

        // |---------------Constructores----------------|

        public Venta()
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
