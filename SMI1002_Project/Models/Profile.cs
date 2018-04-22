using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMI1002_Project.Models
{
    class Profile
    {

        #region Members
        private int id;
        private string userId;
        private DateTime inscriptionDate;
        private double averageNote;
        private int completedTrips;
        #endregion

        #region Constructors
        public Profile()
        {
            this.inscriptionDate = DateTime.UtcNow;
        }
        public Profile(string userId)
        {
            this.inscriptionDate = DateTime.UtcNow;
        }
        #endregion

        #region Properties
        public DateTime InscriptionDate { get; protected set; }
        public double AverageNote {
            get { return this.averageNote; }
            set
            {
                // Verify that note value is between 1 and 10
                // before doing the average
                if (value >= 0 && value <= 10)
                    this.averageNote = (this.averageNote + value) / 2;
                else
                    this.averageNote = this.averageNote + 0;
               
            }
        }
        #endregion

    }
}
