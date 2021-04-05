using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalInterface
{
        public interface IAnimal
        {
        public string Name { get; set; }
        public bool HasFeathers { get; set; }
        public int SocialSecurity { get; set; }
        //We can't make a constructor
//We have to store our children in an IAnimal for them to use makesound
        public void MakeSound();
        public bool CanFly();
        public void PrintTaxInfo();
        }
    }
   