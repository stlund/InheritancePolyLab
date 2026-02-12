using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePolyLab
{
    class Vehicle2
    {
        public string Brand;
        public Vehicle2(string brand) { Brand = brand; }
        public virtual void Start()
        {
            Console.WriteLine($"{Brand} start.");
        }
    }
}
