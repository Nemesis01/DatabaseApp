using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMI1002_Project.Models
{
    class Subscription
    {


        #region Members
        private int id;
        private Offer subscribedOffer;
        private User subscriber;
        private DateTime subscriptionDate;
        #endregion


        #region Constructors
        public Subscription()
        {
            this.subscriptionDate = DateTime.UtcNow;
        }
        public Subscription(Offer subscribedOffer, User subscriber, int placesNumber)
        {

        }
        #endregion


        #region Properties
        public User Subscriber
        {
            get { return this.subscriber;  }
            set { this.subscriber = value; }
        }
        public DateTime SubscriptionDate
        {
            get { return this.subscriptionDate; }
            set { this.subscriptionDate = value; }
        }
        public int PlacesNumber { get; set; }
        #endregion

    }
}
