using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Base_BI.Entities
{
    public class Dia
    {
        // |---------------Atributos--------------------|
        private int id;
        private String nombre;


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

        // |---------------Constructores----------------|

        private Dia(int id, String nombre)
        {
            ID = id;
            Nombre = nombre;

            Init();
        }

        private Dia(String nombre)
        {
            Nombre = nombre;

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
