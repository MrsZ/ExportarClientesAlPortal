using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace ClientesMicrosipPortal.clases
{
    public class Mysql_DAL
    {
        private MySqlConnection myConexion;
        private MySqlCommand myCommand;
        private MySqlDataAdapter myAdapter;
        private ConfiguracionMysql confMysql;

        public Mysql_DAL(ConfiguracionMysql confMysql)
        {
            this.confMysql = confMysql;
            myConexion = new MySqlConnection();
            myConexion.ConnectionString = getConnectionString();
        }

        private string getConnectionString()
        {
            MySqlConnectionStringBuilder myStringBuilder = new MySqlConnectionStringBuilder();
            myStringBuilder.Server = confMysql.server;
            myStringBuilder.UserID = confMysql.user;
            myStringBuilder.Password = confMysql.pass;
            myStringBuilder.Database = ConfigurationManager.AppSettings["BD_Name"];

            return myStringBuilder.ToString();
        }

        public string ProbarConexion()
        {
            string sRespuesta = string.Empty;

            try
            {
                myConexion.Open();             

                sRespuesta = "OK";
            }
            catch (Exception ex)
            {
                sRespuesta = ex.Message;                
            }
            finally
            {
                if (myConexion.State != ConnectionState.Closed)
                    myConexion.Close();
            }

            return sRespuesta;
        }

        public void InsertarClientes(List<Cliente> lstClientes)
        {
            myConexion.Open();
            MySqlTransaction myTransaccion = myConexion.BeginTransaction();

            myCommand = new MySqlCommand();
            myCommand.Connection = myConexion;
            int id_vendedor = Convert.ToInt32(ConfigurationManager.AppSettings["ID_Vendedor"]);

            try
            {
                foreach (Cliente cliente in lstClientes)
                {
                    myCommand.CommandText =
                        string.Format(@"Insert Into clientes (nombre, id_vendedor, id_interno, id_ruta, estatus)
                                                      Values ('{0}' , {1}        , '{2}'     , {3}    , 1)",
                                             cliente.Nombre, id_vendedor, cliente.ClaveCliente, cliente.RutaID);
                    myCommand.ExecuteNonQuery();
                }

                myTransaccion.Commit();
                myConexion.Close();
            }
            catch (Exception ex)
            {
                myTransaccion.Rollback();
                if (myConexion.State != ConnectionState.Closed)
                    myConexion.Close();

                throw ex;
            }
        }
    }
}
