using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Assignment6
{
    /// <summary>
    /// Abstracts describe a contract but does not provide a full implementation of the contract.
    /// </summary>
    abstract class Vehicle : IVehicle
    {
        //Fields section

        private string _brand;
        private string _model;
        private int _numberOfWheels;


        //**********************************************************
        //Constructors section

        /// <summary>
        /// Default constructor
        /// </summary>
        public Vehicle()
        {

        }


        /// <summary>
        /// Constructor that takes three parameters: brand, model, number of wheels
        /// </summary>
        /// <param name="brand">Stirng input for brand name</param>
        /// <param name="model">String input for model name</param>
        /// <param name="numberOfWheels">Integer input for number of wheels</param>
        public Vehicle(string brand, string model, int numberOfWheels)
        {
            Brand = brand;
            Model = model;
            NumberOfWheels = numberOfWheels;
        }




        //*******************************************************
        //Properties section


        /// <summary>
        /// Retrieve/Store Brand Info
        /// </summary>
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        /// <summary>
        /// Retrieve/Store Model Info
        /// </summary>
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        /// <summary>
        /// Retrieve/Store Number of Wheels Info
        /// </summary>
        public int NumberOfWheels
        {
            get { return _numberOfWheels; }
            set { _numberOfWheels = value; }
        }


        //*******************************************************
        //Methods section


        /// <summary>
        /// Prints the Brand, Model, and Number of Wheels info
        /// </summary>
        public virtual void GetInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
        }

    }
}
