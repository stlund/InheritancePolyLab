namespace InheritancePolyLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Vehicle("Volvo");
            car.Drive();
            Console.WriteLine();


            Car myCar = new Car("Saab");
            myCar.Drive();  // Inherited method from Vehicle
            myCar.Honk();   // Car's own method
            Console.WriteLine();



            Vehicle2 bike = new Motorcycle("Yamaha"); // Polymorphism: Vehicle2 reference to a Motorcycle object
            bike.Start(); // Calls the overridden Start method in Motorcycle
            Console.WriteLine();


            Animal cat = new Cat("Misse"); // Polymorphism: Animal reference to a Cat object
            cat.MakeSound(); // Calls the overridden MakeSound method in Cat
            Console.WriteLine();


            Dog fido = new Dog("Fido"); // Polymorphism: Animal reference to a Dog object
            fido.MakeSound();   // Calls the overridden MakeSound method in Dog
            Console.WriteLine();


            List<Animal> animals = new List<Animal> { cat, fido };

            foreach (Animal a in animals)
            {
                a.MakeSound(); // Polymorphism: Calls the appropriate MakeSound method for each animal
            }
        }
    }
}
