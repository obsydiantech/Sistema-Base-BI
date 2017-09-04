using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Base_BI.Entities
{
    public class Pedido
    {
        // |---------------Atributos--------------------|
        private int id;
        private int idProveedor;
        private Producto producto;
        private int cantidad;
        private DateTime fechaPedido;
        private DateTime fechaEntrega;
        private Boolean recibido;


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
        public int IDProveedor
        {
            get
            {
                return this.idProveedor;
            }

            set
            {
                this.idProveedor = value;
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
        public DateTime FechaPedido
        {
            get
            {
                return this.fechaPedido;
            }

            set
            {
                this.fechaPedido = value;
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
        public Boolean Recibido
        {
            get
            {
                return this.recibido;
            }

            set
            {
                this.recibido = value;
            }
        }

        // |---------------Constructores----------------|

        public Pedido()
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
