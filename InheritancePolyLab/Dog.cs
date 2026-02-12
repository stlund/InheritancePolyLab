using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePolyLab
{
    class Dog : Animal
    {
        public Dog(string name) : base(name) { }
        public override void MakeSound()
        {
            base.Sleep(); // Call the base class's Sleep method
            Console.WriteLine($"{Name} says Woof!");
        }
    }
}
