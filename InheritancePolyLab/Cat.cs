using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePolyLab
{
    class Cat : Animal
    {
        public Cat(string name) : base(name) { }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says Meow!");
        }
    }
}
