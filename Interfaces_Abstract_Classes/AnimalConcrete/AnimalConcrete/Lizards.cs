using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalConcrete
{
    class Lizards : Animal
    {
        public Lizards(string Name, int SocialSecurity) : base(Name, false, SocialSecurity)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine("SSsssSSSsssnake");
        }
        public override void PrintTaxInfo()
        {
            base.PrintTaxInfo();
            Console.WriteLine($"{Name} snakes keep their money in offshore accounts.");
        }
    }
}
