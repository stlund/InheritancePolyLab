using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePolyLab
{
    abstract class Animal
    {
        public string Name;
        public Animal(string name) { Name = name; }

        public abstract void MakeSound();

        public virtual void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }
    }
}
