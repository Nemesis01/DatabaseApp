using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMI1002_Project.Models
{
    class Driver : Person
    {


        #region Members
        private string licenseNumber;
        private Car favouriteCar;
        #endregion

        #region Constructors
        public Driver()
        {
            
        }
        public Driver(string FirstName, string LastName, string Email, string PhoneNumber, string Password)
            :base(FirstName, LastName, Email, PhoneNumber, Password)
        {
            
        }
        #endregion

        #region Properties
        public string LicenseNumber { get; set; }
        public Car FavouriteCar
        {
            get { return this.favouriteCar; }
            set { this.favouriteCar = value; }
        }
        public List<Car> DrivenCar { get; set; }
        #endregion


    }
}
