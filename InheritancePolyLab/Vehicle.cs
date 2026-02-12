using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePolyLab
{
    class Vehicle
    {
        // A base class representing a generic vehicle
        public string Brand;

        // Constructor to initialize the brand of the vehicle
        public Vehicle(string brand)
        {
            Brand = brand;
            Console.WriteLine($"Creating a vehicle of brand {Brand}");
        }

        public void Drive()
        {
            Console.WriteLine($"{Brand} drives forward.");
        }
    }
}
