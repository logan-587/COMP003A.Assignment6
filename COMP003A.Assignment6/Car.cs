using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Assignment6
{
    /// <summary>
    /// Car extends the Vehicle class
    /// </summary>
    internal class Car : Vehicle
    {
        //*****************************
        //Constructors section: a class does not need to have a default contstrictor


        //**********************************
        //Methods Section

        /// <summary>
        /// Overrides the base Vehicles's Definition for GetInfo()
        /// </summary>
        public override void GetInfo()
        {
            Console.WriteLine($"I'm a {nameof(Car)}");
            Console.WriteLine("But I don't *wanna* give you my details :(");
        }


















    }
}
