using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMI1002_Project.Models
{

    public enum Category
    {
        Economy,
        Compact,
        Intermediate,
        FullSize,
        SUV,
        Minivan
    }

    class Car
    {


        #region Members
        private int id;
        private Driver owner;
        #endregion

        #region Constructors
        public Car()
        {
            
        }

        public Car(Driver owner)
        {
            this.owner = owner;
        }

        public Car(string brand, string model, int year, string matriculationNumber)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.MatriculationNumber = matriculationNumber;
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string OwnerId
        {
            get { return (this.owner == null) ? null : this.owner.Id; }
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public Category Segment { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public string MatriculationNumber { get; set; }
        #endregion

    }
}
