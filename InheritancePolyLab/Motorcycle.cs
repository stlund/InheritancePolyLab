using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePolyLab
{
    class Motorcycle : Vehicle2
    {
        public Motorcycle(string brand) : base(brand) { }
        public override void Start()
        {
            Console.WriteLine($"{Brand} roars as a motorcycle!");
        }
    }
}
