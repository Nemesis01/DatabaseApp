using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SMI1002_Project.Models
{
    class DatabaseInterface
    {

        #region Members
        private static OracleConnection connection;
        #endregion


        #region Constructors
        public DatabaseInterface()
        {
            connection = new OracleConnection("test");
        }
        public DatabaseInterface(string host, string port, string serviceName, string user, string password)
        {
            // Requête de connexion à la base de données 
            string connectionRequest = string.Format("" +
                "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={0})" +
                "(PORT={1}))(CONNECT_DATA=(SID={2})));User Id={3};Password={4};",
                    host,
                    port,
                    serviceName,
                    user, 
                    password);

            // Création d'un objet de connexion à la base de données
            connection = new OracleConnection(connectionRequest);
        }
        #endregion



        #region Properties
        public static OracleConnection ConnectionInstance
        {
            get { return connection ; }
        }
        #endregion


        #region Methods
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
            }
            catch(OracleException e)
            {
                return false;
            }
            return true;
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch(OracleException e)
            {
                return false;
            }
            return true;
        }

        public bool IsConnectionOpen()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                return true;
            return false;
        }
        #endregion

    }
}
