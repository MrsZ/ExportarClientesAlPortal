using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using FirebirdSql.Data.FirebirdClient;

namespace ClientesMicrosipPortal.clases
{
    public class Firebird_DAL
    {
        private FbConnection fbConexion;
        private FbCommand fbCommand;
        private FbDataAdapter fbAdapter;
        private ConfiguracionMicrosip confMicrosip;

        public Firebird_DAL(ConfiguracionMicrosip confMicrosip)
        {
            this.confMicrosip = confMicrosip;
            fbConexion = new FbConnection();
            fbConexion.ConnectionString = getConnectionString();
        }

        private string getConnectionString()
        {
            FbConnectionStringBuilder ConnectionStringBuilder = new FbConnectionStringBuilder();
            ConnectionStringBuilder.UserID = confMicrosip.user;
            ConnectionStringBuilder.Password = confMicrosip.pass;
            ConnectionStringBuilder.Port = Convert.ToInt32(confMicrosip.port);
            ConnectionStringBuilder.Database = confMicrosip.path;

            return ConnectionStringBuilder.ToString();
        }

        public List<Cliente> getClientesForaneos()
        {
            List<Cliente> lstClientes = new List<Cliente>();
            DataTable dtResultado = new DataTable();

            string sConsulta =
                            @"SELECT 
                                  CLAVES_CLIENTES.CLAVE_CLIENTE AS ClaveCliente,
                                  CLIENTES.NOMBRE AS NombreCliente,
                                  CLAVES_CAT_SEC.CLAVE AS ClaveRuta,
                                  VIAS_EMBARQUE.NOMBRE AS Ruta
                                FROM
                                  CLAVES_CLIENTES
                                  INNER JOIN CLIENTES ON (CLAVES_CLIENTES.CLIENTE_ID = CLIENTES.CLIENTE_ID)
                                  INNER JOIN ROLES_CLAVES_CLIENTES ON (CLAVES_CLIENTES.ROL_CLAVE_CLI_ID = ROLES_CLAVES_CLIENTES.ROL_CLAVE_CLI_ID)
                                  INNER JOIN DIRS_CLIENTES ON (CLIENTES.CLIENTE_ID = DIRS_CLIENTES.CLIENTE_ID)
                                  INNER JOIN VIAS_EMBARQUE ON (DIRS_CLIENTES.VIA_EMBARQUE_ID = VIAS_EMBARQUE.VIA_EMBARQUE_ID)
                                  INNER JOIN CLAVES_CAT_SEC ON (VIAS_EMBARQUE.VIA_EMBARQUE_ID = CLAVES_CAT_SEC.ELEM_ID)
                                  INNER JOIN TIPOS_CLIENTES ON (CLIENTES.TIPO_CLIENTE_ID = TIPOS_CLIENTES.TIPO_CLIENTE_ID)
                                WHERE
                                  ROLES_CLAVES_CLIENTES.ES_PPAL LIKE 'S' AND 
                                  TIPOS_CLIENTES.NOMBRE LIKE '%FORANEO%'";
            fbCommand = new FbCommand(sConsulta, fbConexion);
            fbAdapter = new FbDataAdapter(fbCommand);            
            fbAdapter.Fill(dtResultado);

            Cliente cliente;
            foreach (DataRow row in dtResultado.Rows)
            {
                cliente = new Cliente();
                cliente.ClaveCliente = Convert.ToString(row["ClaveCliente"]);
                cliente.Nombre = Convert.ToString(row["NombreCliente"]);
                cliente.RutaID = Convert.ToInt32(row["ClaveRuta"]);
                cliente.Ruta = Convert.ToString(row["Ruta"]);
                lstClientes.Add(cliente);
            }

            return lstClientes;
        }
    }
}
