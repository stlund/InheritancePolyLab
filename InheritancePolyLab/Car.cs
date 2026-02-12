using System;
using System.Collections.Generic;
using System.Text;


namespace InheritancePolyLab
{
    class Car : Vehicle
    {
        public Car(string brand) : base(brand)
        {
        }

        public void Honk()
        {
            Console.WriteLine($"{Brand} honks: Beep beep!");
        }
    }
}
