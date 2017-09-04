using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Base_BI.Entities
{
    public class Reserva
    {
        // |---------------Atributos--------------------|
        private int id;
        private int idCliente;
        private Producto producto;
        private int cantidad;
        private float seña;
        private DateTime fechaReserva;
        private DateTime fechaEntrega;
        private Boolean entregado;


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
        public Producto Producto
        {
            get
            {
                return this.producto;
            }

            set
            {
                this.producto = value;
            }
        }
        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }

            set
            {
                this.cantidad = value;
            }
        }
        public float Seña
        {
            get
            {
                return this.seña;
            }

            set
            {
                this.seña = value;
            }
        }
        public DateTime FechaReserva
        {
            get
            {
                return this.fechaReserva;
            }

            set
            {
                this.fechaReserva = value;
            }
        }
        public DateTime FechaEntrega
        {
            get
            {
                return this.fechaEntrega;
            }

            set
            {
                this.fechaEntrega = value;
            }
        }
        public Boolean Entregado
        {
            get
            {
                return this.entregado;
            }

            set
            {
                this.entregado = value;
            }
        }
        // |---------------Constructores----------------|

        public Reserva()
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
