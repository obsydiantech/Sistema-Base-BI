using System;
using System.Collections.Generic;
using System.Data;

using Sistema_Base_BI.Entities;
using Sistema_Base_BI.Managers;


namespace Sistema_Base_BI.Controllers
{


    public class EmpleadosController
    {
        // |---------------Atributos---------------|
        private static EmpleadosController instance;
        public static EmpleadosController Instance
        {
            get
            {
                if (instance == null)
                    instance = new EmpleadosController();

                return instance;
            }
        }

        // |---------------Constructores---------------|
        private EmpleadosController()
        {
            Init();
        }

        // |---------------Métodos Públicos---------------|
        public Boolean Init()
        {
                return true;
        }

        public Boolean Agregar(Empleado empleado)
        {
            return DBManager.Instance.Execute("EXEC SP_Agregar_Empleado('" + empleado.IDJornadaLaboral + "', " +
                "'" + empleado.Nombre + "', '" + empleado.Apellido + "', '" + empleado.DNI + "', '" + empleado.Telefono1 + "', '" + empleado.Telefono2 + "', '" + empleado.Email + "')");
        }

        public Boolean Modificar(Empleado empleado)
        {
            return DBManager.Instance.Execute("EXEC SP_Modificar_Empleado(" + empleado.IDSueldo + ", '" + empleado.IDJornadaLaboral + "', " +
                "'" + empleado.Nombre + "', '" + empleado.Apellido + "', '" + empleado.DNI + "', '" + empleado.Telefono1 + "', '" + empleado.Telefono2 + "', '" + empleado.Email + "')");
        }

        public Boolean Eliminar(int id)
        {
            return DBManager.Instance.Execute("DELETE FROM Empleados WHERE ID_Empleado = " + id);

        }

        public List<Empleado> GetEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();

            DataTable dt = DBManager.Instance.ExecuteQuery("SELECT * FROM Entities");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                empleados.Add(new Empleado(Convert.ToInt32(dt.Rows[i][0]), Convert.ToInt32(dt.Rows[i][1]), Convert.ToInt32(dt.Rows[i][2]),
                    dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString(), dt.Rows[i][6].ToString(), dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString()));
            }


            return empleados;
        }

        // |---------------Métodos Privados---------------|

        // |-------------------Eventos--------------------|
    }
}