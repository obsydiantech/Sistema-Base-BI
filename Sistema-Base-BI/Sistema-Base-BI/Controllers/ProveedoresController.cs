using System;
using System.Collections.Generic;
using System.Data;

using Sistema_Base_BI.Entities;
using Sistema_Base_BI.Managers;

namespace Sistema_Base_BI.Controllers
{
    class ProveedoresController
    {
        // |---------------Atributos---------------|
        private static ProveedoresController instance;
        public static ProveedoresController Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProveedoresController();

                return instance;
            }
        }

        // |---------------Constructores---------------|
        private ProveedoresController()
        {
            Init();
        }

        // |---------------Métodos Públicos---------------|
        public Boolean Init()
        {
                return true;
        }

        public Boolean Agregar(Proveedor proveedor)
        {
            return DBManager.Instance.Execute("EXEC SP_Agregar_Proveedor('" + proveedor.Nombre + "', '" + proveedor.Apellido + "', " +
                "'" + proveedor.Telefono1 + "', '" + proveedor.Telefono2 + "', '" + proveedor.Telefono3 + "', '" + proveedor.Email + "', '" + proveedor.Direccion + "'");
        }

        public Boolean Modificar(Proveedor proveedor)
        {
            return DBManager.Instance.Execute("EXEC SP_Modificar_Proveedor(" + proveedor.ID + ", '" + proveedor.Nombre + "', '" + proveedor.Apellido + "', " + 
                "'" + proveedor.Telefono1 + "', '" + proveedor.Telefono2 + "', '" + proveedor.Telefono3 + "', '" + proveedor.Email + "', '" + proveedor.Direccion + "'");
        }

        public Boolean Eliminar(int id)
        {
            return DBManager.Instance.Execute("DELETE FROM Proveedores WHERE ID_Proveedor = " + id);

        }

        public List<Proveedor> GetProveedores()
        {
            List<Proveedor> proveedores = new List<Proveedor>();

            DataTable dt = DBManager.Instance.ExecuteQuery("SELECT * FROM Proveedores");

            for (int i=0; i < dt.Rows.Count; i++)
            {
                proveedores.Add(new Proveedor(Convert.ToInt32(dt.Rows[i][0]), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(),
                    dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString(), dt.Rows[i][6].ToString(), dt.Rows[i][7].ToString()));
            }


            return proveedores;
        }

        // |---------------Métodos Privados---------------|

        // |-------------------Eventos--------------------|
    }
}
