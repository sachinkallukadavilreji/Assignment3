using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Motorcycle: Vehicle
    {
        private string engineCapacity {  get; set; }
        private string fuelType { get; set; }   
        private string hasfaring { get; set; }

        public void displayDetails()
        {
            base.displayDetails();
            Console.WriteLine("Engine capacity is : " + engineCapacity);
            Console.WriteLine("Fuel Type is : " + fuelType);
            Console.WriteLine("Has faring: " + hasfaring);

        }
    }
}
