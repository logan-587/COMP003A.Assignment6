/*
 * Author: Logan Smith
 * Course: COMP-003A
 * Purpose: Week 6 Assignment
 */

namespace COMP003A.Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //************************************************************
            //First Vehicle

            PrintSeparator("Vehicle 1", '@');
            Vehicle vehicle1 = new Car();  //This is one way to instantiate a class
            vehicle1.Brand = "Tesla";
            vehicle1.Model = "Model X";
            vehicle1.NumberOfWheels = 4;
            vehicle1.GetInfo();


            //*********************************************************
            //Second Vehicle

            PrintSeparator("Vehicle 2", '$');
            Vehicle vehicle2 = new Car()  //this is another way to instantiate a class that has a constructor that does not take any params
            {
                Brand = "Toyota",
                Model = "Camry",
                NumberOfWheels = 4
            };
            vehicle2.GetInfo();
            Console.WriteLine("Though I *suppose* you can still access my properties");
            Console.WriteLine($"{vehicle2.Brand} {vehicle2.Model} with {vehicle2.NumberOfWheels} wheels");


            //**********************************************************
            //Third Vehicle
            PrintSeparator("Vehicle 3", '*');
            Vehicle vehicle3 = new Truck("GMC", "Sierra 1500 AT4", 6, 5.5);
            vehicle3.GetInfo();


            //***********************************************************
            //Fourth Vehicle
            PrintSeparator("Vehicle 4", '#');
            Vehicle vehicle4 = new Truck(truckNumberOfWheels: 4, truckBrand: "Ford", truckModel: "F-150 Raptor", sizeOfTruckBed: 5.5);
            vehicle4.GetInfo();





        }






        /// <summary>
        /// Method to make titles easy
        /// </summary>
        /// <param name="message">String input</param>
        /// <param name="x">Char input</param>
        static void PrintSeparator(string message, char x)
        {
            Console.WriteLine("\n\n".PadRight(102, x));
            Console.WriteLine($"\t{message}");
            Console.WriteLine("".PadRight(100, x));
        }


    }
}