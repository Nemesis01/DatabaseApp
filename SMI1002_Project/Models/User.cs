using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMI1002_Project.Models
{
    class User : Person
    {


        #region Members
        private string id;
        private string encryptedPass;
        #endregion

        #region Constructors
        public User()
        {

        }

        public User(string id, string password)
        {
            Id = id;
            Password = password;
        }

        #endregion

        #region Properties
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Password { get; set; }
        #endregion

    }
}
