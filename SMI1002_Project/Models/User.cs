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

        public User(string FirstName, string LastName, string Email, string PhoneNumber, string Password)
            :base(FirstName, LastName, Email, PhoneNumber, Password)
        {
            
        }

        #endregion

        #region Properties

        #endregion

    }
}
