using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMI1002_Project.Models
{
    class Driver : User
    {


        #region Members
        private string licenseNumber;
        private Car favouriteCar;
        #endregion

        #region Constructors
        public Driver()
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
        #endregion


    }
}
