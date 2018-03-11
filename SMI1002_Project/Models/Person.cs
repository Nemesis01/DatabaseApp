using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace SMI1002_Project.Models
{
    class Person
    {

        #region Members

        private String fullName;
        #endregion

        #region Constructors
        public Person()
        {

        }
        public Person(string FirstName, string LastName, string Email, string PhoneNumber)
        {
            fullName = FirstName + LastName;
        }
        #endregion

        #region Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get { return this.fullName; }
        }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        #endregion

        #region Methods
        #endregion

    }
}
