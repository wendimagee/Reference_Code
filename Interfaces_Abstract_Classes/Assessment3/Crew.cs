using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment3a
{
    public class Crew
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public Crew(string Name, string Role)
        {
            this.Name = Name;
            this.Role = Role;
        }
    }
}