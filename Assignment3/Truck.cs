using Microsoft.VisualBasic.FileIO;
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

        public override void displayDetails()
        {

            Console.WriteLine("Model name is : " + model);
            Console.WriteLine("Manufacture year is : " + manufactureYear);
            Console.WriteLine("Rental price is : " + rentalPrice);
            Console.WriteLine("Capacity is: "+ capacity);
            Console.WriteLine("Truck Type is: "+  truckType);
            Console.WriteLine("Four wheel drive: "+ fourWheelDrive);

        }

        public void motorCycleDetails()
        {

            Console.WriteLine("Enter the capacity: ");
            string capacitys = Console.ReadLine();
            capacity = capacitys;
            Console.WriteLine("Enter the truck type: ");
            string truckTypes = Console.ReadLine();
            truckType = truckTypes;
            Console.WriteLine("Enter drive type: ");
            string fourWheelDrives = Console.ReadLine();
            fourWheelDrive = fourWheelDrives;

        }

    }
}
