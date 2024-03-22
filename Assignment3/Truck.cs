using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Truck: Vehicle
    {
        private string capacity {  get; set; }
        private string truckType { get; set; }
        private string fourWheelDrive { get; set; }

        public void displayDetails()
        {
            base.displayDetails();
            Console.WriteLine("Capacity is: "+ capacity);
            Console.WriteLine("Truck Type is: "+  truckType);
            Console.WriteLine("Four wheel drive: "+ fourWheelDrive);

        }

    }
}
