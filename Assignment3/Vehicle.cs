using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Vehicle
    {
        private string model {  get; set; }
        private string manufactureYear { get; set; }
        private string rentalPrice { get; set; }

        public void displayDetails()
        {
            Console.WriteLine("Model name is : " + model);
            Console.WriteLine("Manufacture year is : " + manufactureYear);
            Console.WriteLine("Rental price is : " + rentalPrice);
        }

    }
}
