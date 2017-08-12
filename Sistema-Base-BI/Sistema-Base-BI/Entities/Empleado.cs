using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Base_BI.Entities
{
    class Empleado
    {
        // |---------------Atributos--------------------|
        private int id;
        private int idSsueldo;
        private int idJornadaLaboral;
        private String nombre;
        private String apellido;
        private String dni;
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
        public int IDSueldo
        {
            get
            {
                return this.idSsueldo;
            }

            set
            {
                this.idSsueldo = value;
            }
        }
        public int IDJornadaLaboral
        {
            get
            {
                return this.idJornadaLaboral;
            }

            set
            {
                this.idJornadaLaboral = value;
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
        public String DNI
        {
            get
            {
                return this.dni;
            }

            set
            {
                this.dni = value;
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

        private Empleado()
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
