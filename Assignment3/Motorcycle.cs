using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Motorcycle : Vehicle
    {
        private string engineCapacity {  get; set; }
        private string fuelType { get; set; }   
        private string hasfaring { get; set; }

        public override void displayDetails()
        {
            Console.WriteLine("Model name is : " + model);
            Console.WriteLine("Manufacture year is : " + manufactureYear);
            Console.WriteLine("Rental price is : " + rentalPrice);
            Console.WriteLine("Engine capacity is : " + engineCapacity);
            Console.WriteLine("Fuel Type is : " + fuelType);
            Console.WriteLine("Has faring: " + hasfaring);

        }

        public void motorCycleDetails()
        {
            
            Console.WriteLine("Enter the engine capacity: ");
            string engineCapacitys = Console.ReadLine();
            engineCapacity = engineCapacitys;
            Console.WriteLine("Enter the type of transmission: ");
            string fuelTypes = Console.ReadLine();
            fuelType = fuelTypes;
            Console.WriteLine("Enter the conversion type: ");
            string hasfarings = Console.ReadLine();
            hasfaring = hasfarings;

        }
    }
}
