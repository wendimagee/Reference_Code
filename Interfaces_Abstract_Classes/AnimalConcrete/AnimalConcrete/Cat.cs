using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalConcrete
{
    class Cat : Animal
    {
        //Base() calls the parents constructor and is needed when the parent constructor need parameters 
        public Cat(string Name, int SocialSecurity) : base(Name, false, SocialSecurity)
        {

        }

        //Cat is supplying its own version of make sound
        public override void MakeSound()
        {
            Console.WriteLine("Meow! Meow!");
        }

        //We're able to add onto what our parent has
        public override void PrintTaxInfo()
        {
            base.PrintTaxInfo();
            Console.WriteLine($"{Name} tends to dodge their taxes.");
        }
    }
}
