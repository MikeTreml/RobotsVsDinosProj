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
        public List<Weapon> weaponsArray;
        public List<Weapon> weaponsChoice;
      
        //Constructor
        public Armory()
        {
            weaponsArray = new List<Weapon>();
            weaponsChoice = new List<Weapon>();
            weaponsArray.Add(new Weapon("Missle  ", 100));
            weaponsArray.Add(new Weapon("Sword  ", 30));
            weaponsArray.Add(new Weapon("Blaster", 50));
            weaponsArray.Add(new Weapon("Bat    ", 20));
            weaponsArray.Add(new Weapon("Banana ", 1));
            weaponsArray.Add(new Weapon("Whip   ", 10));

        }
        //member methods
    }
}
