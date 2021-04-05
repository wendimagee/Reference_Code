using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalInterface
{
    class Dog : IAnimal
    {
        public string Name { get { return _name; } set { _name = value; } }
        private string _name;
        public bool HasFeathers { get { return _hasFeathers; } set { _hasFeathers = value; } }
        private bool _hasFeathers;

        public int SocialSecurity { get { return _socialSecurity; } set { _socialSecurity = value; } }
        private int _socialSecurity;

        public Dog(string Name, int SocialSecurity)
        {
            this.Name = Name;
            this.HasFeathers = false;
            this.SocialSecurity = SocialSecurity;
        }

        public bool CanFly()
        {
            Console.WriteLine("Dogs can't fly");
            return false;
        }

        public void PrintTaxInfo()
        {
            Console.WriteLine($"{Name} doesn't do their taxes");
        }

        public void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }
}