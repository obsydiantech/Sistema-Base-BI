using System;

using System.Data;
using System.Data.SqlClient;

namespace Sistema_Base_BI.Managers
{
    public class DBManager//SINGLETON
    {
        // |--------------------------------ATRIBUTES---------------------------------|

        private String PC_NAME = System.Environment.MachineName;
        private String dbName = "Sistema";//TODO: Set dBName
        private static String DB_INSTANCE = "SQLEXPRESS";
        private static DBManager instance;
        public static DBManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new DBManager();

                return instance;
            }
        }
        private SqlConnection sqlConnection;
        //FileName del script de creación de bdd
        private String createDBScriptFileName;
        //Path del script de creación de bdd
        private String createDBScriptFilePath;

        // |--------------------------------CONSTRUCTOR---------------------------------|

        private DBManager()
        {

        }

        // |--------------------------------METHODS-FUNCTIONS---------------------------------|

        /* Requerido
         * */
        public Boolean Init()
        {
            InitSqlCon();
            this.createDBScriptFileName = "SistemaBase 1.0.0.sql";//TODO: Set scriptFileName
            this.createDBScriptFilePath = @"C:\Program Files\Me\Work\LUDEBE Sistemas\SistemaBase\SistemaBase 1.0.0\Base de datos\1.0.0";//TODO: Set scriptPath
            return true;
        }

        public Boolean Execute(String query)
        {
            //Si se abrió correctamente la conexión
            if (TryOpenConnection() && !query.Equals(String.Empty))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException e)
                {
                    return false;
                }
                finally { CloseConnection(); }
            }

            else
                return false;
        }

        public DataTable ExecuteQuery(String query)
        {
            DataTable dataTable = null;

            //Si se abrió correctamente la conexión
            if (TryOpenConnection())
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                }
                catch (SqlException e)
                {
                }
                finally { CloseConnection(); }
            }

            return dataTable;
        }

        public Boolean GenerateBackup()
        {
            if (TryOpenConnection())
            {
                try
                {
                    String fileName = dbName + " " + DateTime.Today.ToShortDateString().Replace("/", "-");
                    String query = "BACKUP DATABASE SistemaBase "//TODO: Nombre BDD
                                   + @"TO DISK = 'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\Backup\" + fileName + ".bak' WITH FORMAT";
                    SqlCommand sqlcmd = new SqlCommand(query, sqlConnection);
                    sqlcmd.ExecuteNonQuery();

                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
                finally { CloseConnection(); }
            }

            else
                return false;
        }

        public Boolean DBExists()
        {
            Boolean exists = false;

            ChangeDbName("master");
            try
            {
                DataTable dt = ExecuteQuery("IF (EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE ('[' + name + ']' = 'SistemaBase' OR "
                + "name = 'SistemaBase'))) SELECT 1 ELSE SELECT 0");//TODO: Nombre BDD 2 veces

                if (dt.Rows[0][0].ToString().Equals("1"))
                    exists = true;
            }

            catch (Exception e)
            {
            }

            finally
            {
                ChangeDbName("SistemaBase");//TODO: Nombre BDD
            }

            return exists;
        }

        public Boolean CreateDB()
        {
            ChangeDbName("master");

            //Crea la BDD
            //Todo: Remover para iniciar normalmente
            Environment.Exit(0);
            String query = System.IO.File.ReadAllText(createDBScriptFilePath + @"\" + createDBScriptFileName).Replace("�", "ñ");

            String[] querys = query.Split(new string[] { "GO" }, StringSplitOptions.None);

            if (Execute("CREATE DATABASE SistemaBase"))//TODO: Nombre BDD
            {
                ChangeDbName("SistemaBase");//TODO: Nombre BDD

                for (int i = 1; i < querys.Length; i++)
                {
                    if (!querys[i].Equals(String.Empty))
                        if (!Execute(querys[i]))
                        {
                            return false;
                        }
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        // |--------------------------------SERVICE METHODS/FUNCTIONS---------------------------------|

        private void InitSqlCon()
        {
            String sqlConnectionUrl = "Server=" + System.Environment.MachineName + "\\" + DB_INSTANCE + ";Database=" + dbName + ";Trusted_Connection=true;";
            sqlConnection = new SqlConnection(sqlConnectionUrl);
        }

        private Boolean TryOpenConnection()
        {
            try
            {
                sqlConnection.Open();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void CloseConnection()
        {
            try
            {
                sqlConnection.Close();
            }
            catch (Exception e)
            {
            }
        }

        private void ChangeDbName(String dbName)
        {
            this.dbName = dbName;
            InitSqlCon();
        }

        private Boolean DropDB()
        {
            ChangeDbName("master");
            if (System.IO.File.Exists(createDBScriptFilePath + @"\" + createDBScriptFileName))
            {
                //Borra la BDD
                String query = "ALTER DATABASE [SistemaBase] SET SINGLE_USER WITH ROLLBACK IMMEDIATE; DROP DATABASE SistemaBase;";//TODO: Nombre BDD 2 

                if (Execute(query))
                    return true;

                else
                {
                    return false;
                }
            }

            else
            {
                return false;
            }
        }
    }
}