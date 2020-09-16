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
        //don't think these need to be public since the value is being saved to a list
        //public Weapon sword;
        //public Weapon blaster; 
        //public Weapon bat; 
        //Constructor
        public Armory()
        {
            //bat = new Weapon("Bat", 5);
            //blaster = new Weapon("Blaster", 20);
            //sword = new Weapon("Sword", 10);
            weaponsArray = new List<Weapon>();
            weaponsChoice = new List<Weapon>();
            weaponsArray.Add(new Weapon("Sword  ", 20));
            weaponsArray.Add(new Weapon("Blaster", 40));
            weaponsArray.Add(new Weapon("Bat\t  ", 10));
        }
        //member methods
    }
}
