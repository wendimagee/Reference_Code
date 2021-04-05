using System;
using System.Collections.Generic;

namespace AnimalConcrete
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> Zoo = new List<Animal>();

            Cat c = new Cat("Skeezy", 930435732);
            c.MakeSound();
            c.PrintTaxInfo();
            c.CanFly();

            Animal a = new Dog("Gracie", 1234567890);
            a.MakeSound();
            a.PrintTaxInfo();
            a.CanFly();
            Bird b = new Bird("Rooster", 1207361287);

            Zoo.Add(c);
            Zoo.Add(a);
            Zoo.Add(b);
            Console.WriteLine();
            Console.WriteLine("Zoo list example");
            foreach(Animal anim in Zoo)
            {
                Console.WriteLine(anim);
            }
        }
    }
}
