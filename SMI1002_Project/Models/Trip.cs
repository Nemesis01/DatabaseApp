using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMI1002_Project.Models
{
    class Trip
    {


        #region Members
        private int id;
        #endregion

        #region Constructors
        public Trip() { }
        public Trip(string departurePoint, string droppingPoint)
        {
            this.DeparturePoint = departurePoint;
            this.DroppingPoint = droppingPoint;
        }
        #endregion

        #region Properties
        public int Id
        {
            get { return this.id; }
            protected set { this.id = value; }
        }
        public string DeparturePoint { get; set; }
        public string DroppingPoint { get; set; }
        public float Distance { get; set; }
        #endregion

    }
}
