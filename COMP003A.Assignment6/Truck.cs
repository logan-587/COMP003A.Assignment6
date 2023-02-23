using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Assignment6
{
    /// <summary>
    /// Trucks extends the Vehicle class
    /// </summary>
    internal class Truck: Vehicle
    {
        //***********************
        //Fields Section
        private double _sizeOfTruckBed;





        //*********************************************
        //Constructors Section

        
        /// <summary>
        /// Constructor that takes 4 parameters: truckBrand, truckModel, truckNumberOfWheels, and SizeOfTruckBed
        /// It reuses the bse class (Vehicle)'s constructor that takes three parameters: brand, model, numberOfWheels
        /// </summary>
        /// <param name="turckBrand"></param>
        /// <param name="TruckModel"></param>
        /// <param name="truckNumberOfWheels"></param>
        /// <param name="sizeofTruckBed"></param>
        public Truck(string truckBrand, string truckModel, int truckNumberOfWheels, double sizeOfTruckBed) : base(truckBrand, truckModel, truckNumberOfWheels)
        {
            SizeOfTruckBed = sizeOfTruckBed;
        }

        
        //*********************************************************
        //Properties section

        public double SizeOfTruckBed
        {
            get { return _sizeOfTruckBed; }
            set { _sizeOfTruckBed = value; }
        }



        //***********************************************************
        //Methods section


        public override void GetInfo()
        {
            Console.WriteLine($"I'm a {nameof(Truck)}");
            base.GetInfo();
            Console.WriteLine($"I also have a {SizeOfTruckBed} ft. truck bed length!");
        }

    }
}
