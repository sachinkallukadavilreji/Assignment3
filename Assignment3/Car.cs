using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Car : Vehicle
    {
        private string seats {  get; set; }
        private string engineType { get; set; }
        private string transmission { get; set; }
        private string convertable { get; set; }

        public void displayDetails()
        {
            base.displayDetails();
            Console.WriteLine("Number of seats are: " + seats);
            Console.WriteLine("Engine Type is: "+  engineType);
            Console.WriteLine("Transmission is : "+ transmission);
            Console.WriteLine("Convertalble : "+  convertable);
        }

    }
}
