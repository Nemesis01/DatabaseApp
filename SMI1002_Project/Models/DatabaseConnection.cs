using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SMI1002_Project.Models
{
    class DatabaseConnection
    {

        public DatabaseConnection()
        {
            OracleConnection conn = new OracleConnection("test");
        }

    }
}
