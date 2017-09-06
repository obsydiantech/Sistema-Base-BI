using System;
using System.Collections.Generic;
using System.Data;

using Sistema_Base_BI.Entities;
using Sistema_Base_BI.Managers;

namespace Sistema_Base_BI.Controllers
{
    public class Controller
    {
        // |---------------Atributos---------------|
        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if (instance == null)
                    instance = new Controller();

                return instance;
            }
        }

        // |---------------Constructores---------------|
        private Controller()
        {
            Init();
        }

        // |---------------Métodos Públicos---------------|
        public Boolean Init()
        {
            return true;
        }

        public Boolean Agregar(Cliente cliente)
        {
            return DBManager.Instance.Execute("EXEC SP_Agregar_Cliente('" + cliente.Nombre + "', " +
                "'" + cliente.Apellido + "', '" + cliente.Usuario + "', '" + cliente.Telefono1 + "', '" + cliente.Telefono2 + "', '" + cliente.Email + "')");
        }

        public Boolean Modificar(Cliente cliente)
        {
            return DBManager.Instance.Execute("EXEC SP_Modificar_Cliente(" + cliente.ID + ", '" + cliente.Nombre + "', " +
                "'" + cliente.Apellido + "', '" + cliente.Usuario + "', '" + cliente.Telefono1 + "', '" + cliente.Telefono2 + "', '" + cliente.Email + "')");
        }

        public Boolean Eliminar(int id)
        {
            return DBManager.Instance.Execute("DELETE FROM Clientes WHERE ID_Cliente = " + id);

        }

        public List<Cliente> GetClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            DataTable dt = DBManager.Instance.ExecuteQuery("SELECT * FROM Clientes");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                clientes.Add(new Cliente(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString()));
            }


            return clientes;
        }

        // |---------------Métodos Privados---------------|

        // |-------------------Eventos--------------------|
    }
}
