using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment3a
{
    public class SpaceShuttle
    {

        public int Fuel { get; set; }
        public List<Crew> Team { get; set; }

        public SpaceShuttle()
        {
            //this is creating an instance of an object, in this case a space shuttle with 3 crew and 0 fuel 
            this.Fuel = 0;
            List<Crew> Team = new List<Crew>();
            Team.Add(new Crew("John", "Captain"));
            Team.Add(new Crew("Diddy", "Chimp"));
            Team.Add(new Crew("Hannah", "Navigator"));
        }
        public bool Launch()
        {
            if (Fuel>5 && Team.Count == 3)
            {
                Console.WriteLine("You made it to space!");
                return true;
            }
            else
            {
                Console.WriteLine("You're not ready for takeoff! Check your fuel levels and make sure you have exactly 3 crew members");
                return false; 
            }
        }
    }
}
