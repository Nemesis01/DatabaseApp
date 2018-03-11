using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMI1002_Project.Models
{

    public enum Segment
    {
        Economy,
        Compact,
        Intermediate,
        FullSize,
        SUV,
        Minivan, 
        SuperCar
    }

    class Car
    {


        #region Members
        private string id;
        #endregion

        #region Constructors
        public Car()
        {

        }

        public Car(string brand, string model, int year, string matriculationNumber)
        {
            Brand = brand;
            Model = model;
            Year = year;
            MatriculationNumber = matriculationNumber;
        }

        #endregion

        #region Properties
        public string Id { get => id; set => id = value; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public Segment Category { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public string MatriculationNumber { get; set; }
        #endregion

    }
}
