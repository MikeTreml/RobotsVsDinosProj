using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos.Robots
{
    class Armory
    {
        //member Variables 
        public List<Weapon> armory;
        //don't think these need to be public since the value is being saved to a list
        Weapon sword = new Weapon("Sword", 15);
        Weapon blaster = new Weapon("Solo's Blaster", 5);// careful it has a hair trigger
        Weapon bat = new Weapon("Baseball Bat", 5);
        //Constructor
        public Armory()
        {
            armory = new List<Weapon>();
            armory.Add(sword);
            armory.Add(blaster);
            armory.Add(bat);

        }
        //member methods
    }
}
