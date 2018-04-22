using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMI1002_Project.Models
{
    class Offer
    {


        #region Members
        private int id;
        private User offerer;
        private Trip offeredTrip;
        private int offeredPlaces;
        private int remainingPlaces;
        #endregion

        #region Constructors
        public Offer()
        {

        }
        public Offer(User offerer, Trip offerdTrip, int offeredPlaces, DateTime departureDate, 
            DateTime departureTime)
        {
            this.offerer = offerer;
            this.offeredTrip = offerdTrip;
            this.offeredPlaces = offeredPlaces;
            this.remainingPlaces = offeredPlaces;
            this.DepartureDate = departureDate;
            this.DepartureTime = departureTime;
            this.PublicationDate = DateTime.UtcNow;
        }
        #endregion


        #region Properties
        public int Id
        {
            get { return this.id; }
            protected set { this.id = value; }
        }
        public string OffererId
        {
            get { return (this.offerer == null) ? null : offerer.Id; }
            set { this.offerer.Id = value; }
        }
        public int TripId
        {
            get { return (this.offeredTrip == null) ? 0 : offeredTrip.Id; }
        }
        public float Price { get; set; }
        public DateTime PublicationDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime DepartureTime { get; set; }
        public int OfferedPlaces { get; set; }
        public int RemainingPlaces
        {
            get { return this.remainingPlaces; }
            set { this.remainingPlaces -= (value <= this.remainingPlaces) ? value : 0; }
        }
        #endregion

    }
}
