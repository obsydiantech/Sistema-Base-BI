using System;
using System.Collections.Generic;
using System.Data;

using Sistema_Base_BI.Entities;
using Sistema_Base_BI.Managers;


namespace Sistema_Base_BI.Controllers
{


    public class JornadasLaboralesController
    {
        // |---------------Atributos---------------|
        private static JornadasLaboralesController instance;
        public static JornadasLaboralesController Instance
        {
            get
            {
                if (instance == null)
                    instance = new JornadasLaboralesController();

                return instance;
            }
        }

        // |---------------Constructores---------------|
        private JornadasLaboralesController()
        {
            Init();
        }

        // |---------------Métodos Públicos---------------|
        public Boolean Init()
        {
            return true;
        }

        public Boolean Agregar(JornadaLaboral jornadaLaboral)
        {
            return DBManager.Instance.Execute("EXEC SP_Agregar_Jornada_Laboral('" + jornadaLaboral.Desde + "', '" + jornadaLaboral.Hasta + "')");
        }

        public Boolean Modificar(JornadaLaboral jornadaLaboral)
        {
            return DBManager.Instance.Execute("EXEC SP_Modificar_Jornada_Laboral(" + jornadaLaboral.ID + ", '" + jornadaLaboral.Desde + "', '" + jornadaLaboral.Hasta + "')");
        }

        public Boolean Eliminar(int id)
        {
            return DBManager.Instance.Execute("EXEC SP_Eliminar_Jornada_Laboral(" + id  + ")");

        }

        public List<JornadaLaboral> GetJornadasLaborales()
        {
            List<JornadaLaboral> jornadasLaborales = new List<JornadaLaboral>();

            DataTable dt = DBManager.Instance.ExecuteQuery("EXEC SP_Get_Jornadas_Laborales()");



            for (int i = 0; i < dt.Rows.Count; i++)
            {

                List<int> dias = new List<int>();
                DataTable dtDias = DBManager.Instance.ExecuteQuery("EXEC SP_Get_Jornadas_Laborales_Dias(" + dt.Rows[i][0] + ")");

                for (int j = 0; j < dt.Rows.Count; j++)
                    dias.Add(Convert.ToInt32(dtDias.Rows[j][0]));

                    jornadasLaborales.Add(new JornadaLaboral(Convert.ToInt32(dt.Rows[i][0]), dias, dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString()));
            }


            return jornadasLaborales;
        }

        // |---------------Métodos Privados---------------|

        // |-------------------Eventos--------------------|
    }
}