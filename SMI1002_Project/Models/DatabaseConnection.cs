using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SMI1002_Project.Models
{
    class DatabaseConnection
    {

        #region Members
        private string oradb;
        #endregion


        #region Constructors
        public DatabaseConnection()
        {
            OracleConnection conn = new OracleConnection("test");
        }
        #endregion



        #region Properties
        #endregion

    }
}
