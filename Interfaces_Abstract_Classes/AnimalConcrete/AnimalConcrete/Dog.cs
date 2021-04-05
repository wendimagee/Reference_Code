using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalConcrete
{
    class Dog : Animal
    {
        public Dog(string Name, int SocialSecurity) : base(Name, false, SocialSecurity)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine("Woof! Woof!");
        }
        public override void PrintTaxInfo()
        {
            base.PrintTaxInfo();
            Console.WriteLine($"{Name} is a productive member of society.");
        }
    }
}
