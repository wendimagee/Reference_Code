using System;
using System.Collections.Generic;

namespace Assessment3a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program tests to see if your shuttle has enough crew members and fuel to take off");
            SpaceShuttle s = new SpaceShuttle();
            s.Launch();
        }
    }
}
