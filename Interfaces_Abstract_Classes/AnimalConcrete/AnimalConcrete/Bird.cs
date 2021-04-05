using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalConcrete
{
    class Bird : Animal
    {
        public Bird(string Name, int SocialSecurity) : base(Name, true, SocialSecurity)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine("Tweet! Tweet!");
        }
        public override void PrintTaxInfo()
        {
            base.PrintTaxInfo();
            Console.WriteLine("Birds avoid taxes by flying away.");
        }
    }
}
