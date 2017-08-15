using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Base_BI.Entities
{
    class Cliente
    {
        // |---------------Atributos--------------------|
        private int id;
        private int nombre;
        private int usuario;
        private int telefono1;
        private int telefono2;
        private int email;


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
        public int Nombre
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
        public int Usuario
        {
            get
            {
                return this.usuario;
            }

            set
            {
                this.usuario = value;
            }
        }
        public int Telefono1
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
        public int Telefono2
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
        public int Email
        {
            get
            {
                return this.email;
            }

            set
            {
                this.email= value;
            }
        }

        // |---------------Constructores----------------|

        private Cliente()
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
