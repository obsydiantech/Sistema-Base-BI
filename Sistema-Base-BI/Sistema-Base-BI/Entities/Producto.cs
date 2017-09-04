using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Base_BI.Entities
{
    public class Producto
    {
        // |---------------Atributos--------------------|
        private int id;
        private int idProveedor;
        private String codigoBarras;
        private String nombre;
        private String categoria;
        private String subcategoria;
        private String etiqueta;
        private DateTime vencimiento;
        private int stock;


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
        public String CodigoBarras
        {
            get
            {
                return this.codigoBarras;
            }

            set
            {
                this.codigoBarras = value;
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
        public String Categoria
        {
            get
            {
                return this.categoria;
            }

            set
            {
                this.categoria = value;
            }
        }
        public String Subcategoria
        {
            get
            {
                return this.subcategoria;
            }

            set
            {
                this.subcategoria = value;
            }
        }
        public String Etiqueta
        {
            get
            {
                return this.etiqueta;
            }

            set
            {
                this.etiqueta = value;
            }
        }
        public DateTime Vencimiento
        {
            get
            {
                return this.vencimiento;
            }

            set
            {
                this.vencimiento = value;
            }
        }
        public int Stock
        {
            get
            {
                return this.stock;
            }

            set
            {
                this.stock = value;
            }
        }

        // |---------------Constructores----------------|

        public Producto()
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
