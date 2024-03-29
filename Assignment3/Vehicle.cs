using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    abstract class Vehicle
    {
        public string model {  get; set; }
        public string manufactureYear { get; set; }
        public string rentalPrice { get; set; }

        public abstract void displayDetails();
        

        

    }
}
