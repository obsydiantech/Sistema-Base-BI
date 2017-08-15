using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Base_BI.Entities
{
    class Proveedor
    {
        // |---------------Atributos--------------------|
        private int id;
        private String nombre;
        private String apellido;
        private String telefono1;
        private String telefono2;
        private String telefono3;
        private String email;
        private String direccion;

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
        public String Apellido
        {
            get
            {
                return this.apellido;
            }

            set
            {
                this.apellido = value;
            }
        }
        public String Telefono1
        {
            get
            {
                return this.telefono1;
            }

            set
            {
                this.telefono1 = value;
            }
        }
        public String Telefono2
        {
            get
            {
                return this.telefono2;
            }

            set
            {
                this.telefono2 = value;
            }
        }
        public String Telefono3
        {
            get
            {
                return this.telefono3;
            }

            set
            {
                this.telefono3 = value;
            }
        }
        public String Email
        {
            get
            {
                return this.email;
            }

            set
            {
                this.email = value;
            }
        }
        public String Direccion
        {
            get
            {
                return this.direccion;
            }

            set
            {
                this.direccion = value;
            }
        }

        // |---------------Constructores----------------|
        private Proveedor()
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
