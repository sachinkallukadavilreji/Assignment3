using Assignment3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Assignment_3.RentalAgency
{
    class RentalAgency : Vehicle
    {
        Car car1 = new Car();
        Truck truck1 = new Truck();
        Motorcycle motorcycle1 = new Motorcycle();


        public double TotalRevenue;

        string[] fleet = new string[10];
        int count = 0;

        public void AddItems(string fleets)
        {
            fleet[count++] = fleets;

        }


        public void RemoveItem(string item)
        {
            int index = -1;
            for (int i = 0; i < count; i++)
            {
                if (fleet[i] == item)
                {
                    index = i;
                }

            }
            fleet[index] = null;
            for (int i = index; i < count - 1; i++)
            {
                fleet[i] = fleet[i + 1];

            }
            count--;
            Console.WriteLine("Vehicle list after removal");
            displayDetails();


        }

        public void RentItem(int a)
        {
            Console.WriteLine("****Choose the vehicle to be rented****\n 1. CAR \n 2. TRUCK \n 3. MOTORCYCLE");

            switch (a)
            {
                case 1:
                    car1.displayDetails();
                    break;
                case 2:
                    truck1.displayDetails();
                    break;
                case 3:
                    motorcycle1.displayDetails();
                    break;

            }

        }

        public override void displayDetails()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{fleet[i]}");
            }


        }
    }
}