using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalConcrete
{
    class Animal
    {
        public string Name { get; set; }
        protected bool HasFeathers { get; set; }
        private int SocialSecurity { get; set; }

        public Animal(string Name, bool HasFeathers, int SocialSecurity)
        {
            this.Name = Name;
            this.HasFeathers = HasFeathers;
            this.SocialSecurity = SocialSecurity;
        }

        //Children will need to override this method 
        public virtual void MakeSound()
        {
            Console.WriteLine("We don't know what sound this animal makes");
        }

        //This method doesn't need to change between children 
        //So we do NOT make it virtual
        public bool CanFly()
        {
            if (HasFeathers)
            {
                Console.WriteLine($"{Name} can fly!");
                return true;
            }
            else
            {
                Console.WriteLine($"{Name} may not fly!");
                return false;
            }
        }

        //This we like what the parent has, but children will need to add more
        public virtual void PrintTaxInfo()
        {
            Console.WriteLine("Social Security NO: " + SocialSecurity);
        }

        public override string ToString()
        {
            string info = "";
            info += $"Name: {Name}\n";
            info += $"Has Feathers: {HasFeathers}\n";
            info += $"Social Security No: {SocialSecurity}\n";

            return info;
            
        }
    }
}
