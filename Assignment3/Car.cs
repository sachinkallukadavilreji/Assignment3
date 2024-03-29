using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Car : Vehicle
    {
        private int seats {  get; set; }
        private string engineType { get; set; }
        private string transmission { get; set; }
        private string convertable { get; set; }

        public override void displayDetails()
        {

            Console.WriteLine("Model name is : " + model);
            Console.WriteLine("Manufacture year is : " + manufactureYear);
            Console.WriteLine("Rental price is : " + rentalPrice);
            Console.WriteLine("Number of seats are: " + seats);
            Console.WriteLine("Engine Type is: "+  engineType);
            Console.WriteLine("Transmission is : "+ transmission);
            Console.WriteLine("Convertalble : "+  convertable);
        }

        public void carDetails()
        {
            Console.WriteLine("Enter the number of seats: ");
            int seat=Convert.ToInt32(Console.ReadLine());
            seats = seat;
            Console.WriteLine("Enter the type of engine: ");
            string engineTypes = Console.ReadLine();
            engineType = engineTypes;
            Console.WriteLine("Enter the type of transmission: ");
            string transmissions = Console.ReadLine();
            transmission = transmissions;
            Console.WriteLine("Enter the conversion type: ");
            string convertables = Console.ReadLine();
            convertable = convertables;

        }

    }
}
