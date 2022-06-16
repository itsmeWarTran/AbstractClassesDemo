using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

 
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var Vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion


            Car Mercades = new Car();
            Mercades.year = 2018;
            Mercades.make = "Mercades";
            Mercades.model = "New one";
            Mercades.HasTrunk = true;
            Vehicles.Add(Mercades);

            Motercycle standard = new Motercycle();
            standard.year = 2005;
            standard.make = "standard";
            standard.model = "sports";
            standard.HasSideCart = false;
            Vehicles.Add(standard);

            Car BMW = new Car();
            BMW.year = 2020;
            BMW.make = "BMW";
            BMW.model = "M3";
            BMW.HasTrunk = false;
            Vehicles.Add(BMW);

            Motercycle goKart = new Motercycle();
            goKart.year = 2017;
            goKart.make = "Go Kart";
            goKart.model = "Mario";
            goKart.HasSideCart = true;
            Vehicles.Add(goKart);


            foreach(var c in Vehicles)
            {
                Console.WriteLine($"The model {c.model} was made in {c.year} from the brand {c.make}.");
                c.DriveAbstract();
                c.DriveVirtual();
                Console.WriteLine("");
            }
        }


        }
}
