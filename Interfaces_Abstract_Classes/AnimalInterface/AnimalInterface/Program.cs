using System;
using System.Collections.Generic;

namespace AnimalInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> Zoo = new List<IAnimal>();

            Cat c = new Cat("Skeezy", 930435732);
            c.MakeSound();
            c.PrintTaxInfo();
            c.CanFly();

            Dog a = new Dog("Gracie", 1234567890);
            a.MakeSound();
            a.PrintTaxInfo();
            a.CanFly();

            Zoo.Add(c);
            Zoo.Add(a);
            Console.WriteLine();
            Console.WriteLine("Zoo list example");
            foreach (IAnimal anim in Zoo)
            {
                Console.WriteLine(anim);
            }
        }
    }
}
