using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Base_BI.Entities
{
    public class Servicio
    {
        // |---------------Atributos--------------------|
        private String id;
        private String nombre;
        private String descripcion;
        private String tipoAbono;
        private String beneficiario;
        private String monto;


        public String ID
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
        public String TipoAbono
        {
            get
            {
                return this.tipoAbono;
            }

            set
            {
                this.tipoAbono = value;
            }
        }
        public String Beneficiario
        {
            get
            {
                return this.beneficiario;
            }

            set
            {
                this.beneficiario = value;
            }
        }
        public String Monto
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

        // |---------------Constructores----------------|

        public Servicio()
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
