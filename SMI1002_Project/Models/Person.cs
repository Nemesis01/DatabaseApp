using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMI1002_Project.Models
{
    class Person
    {

        #region Members
        private string id;
        private Profile profile;
        #endregion

        #region Constructors
        public Person()
        {
            this.profile = new Profile(id);
        }
        public Person(string FirstName, string LastName, string Email, string PhoneNumber, string Password)
        {
            this.profile = new Profile(id);
            this.id = GenerateId();
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.Password = Password;
        }
        #endregion

        #region Properties
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Creates an unique id by concatening user's name and lastName with inscription timestamp 
        /// </summary>
        /// <returns></returns>
        private string GenerateId()
        {
           
            StringBuilder builder = new StringBuilder();
            builder.Append(FirstName.Substring(0, 3));
            builder.Append(LastName.Substring(0, 1));
            builder.Append(profile.InscriptionDate.Year);
            builder.Append(profile.InscriptionDate.Month);
            builder.Append(profile.InscriptionDate.Day);
            builder.Append(profile.InscriptionDate.Hour);
            builder.Append(profile.InscriptionDate.Minute);
            builder.Append(profile.InscriptionDate.Second);

            return builder.ToString();
        }
        #endregion

    }
}
