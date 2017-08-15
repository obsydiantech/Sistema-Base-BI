using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Base_BI.Entities
{
    class JornadaLaboral
    {
        // |---------------Atributos--------------------|
        private int id;
        private List<int> dias; // 0 = lunes, 1 = martes, 2 = miércoles, etc
        private String desde;
        private String hasta;


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
        public List<int> Dias
        {
            get
            {
                return this.dias;
            }

            set
            {
                this.dias = value;
            }
        }
        public String Desde
        {
            get
            {
                return this.desde;
            }

            set
            {
                this.desde = value;
            }
        }
        public String Hasta
        {
            get
            {
                return this.hasta;
            }

            set
            {
                this.hasta = value;
            }
        }

        // |---------------Constructores----------------|

        private JornadaLaboral()
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
