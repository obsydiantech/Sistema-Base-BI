using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Base_BI.Entities
{
    public class Cliente
    {
        // |---------------Atributos--------------------|
        private int id;
        private String nombre;
        private String apellido;
        private String usuario;
        private String telefono1;
        private String telefono2;
        private String email;


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
        public String Usuario
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

        // |---------------Constructores----------------|

        public Cliente(int id, String nombre, String apellido, String usuario, String telefono1, String telefono2, String email)
        {
            ID = id;
            Nombre = nombre;
            Apellido= apellido;
            Usuario = usuario;
            Telefono1 = telefono1;
            Telefono2 = telefono2;
            Email = email;

            Init();
        }

        public Cliente(String nombre, String apellido, String usuario, String telefono1, String telefono2, String email)
        {
            Nombre = nombre;
            Apellido = apellido;
            Usuario = usuario;
            Telefono1 = telefono1;
            Telefono2 = telefono2;
            Email = email;

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
