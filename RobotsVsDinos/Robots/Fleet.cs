using RobotsVsDinos.Robots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    class Fleet
    {
        //member Variables 

        public List<Robot> fleet;
        Armory weapon;
        //Robot robot1;
        //Robot robot2;
        //Robot robot3;

        //Constructor
        public Fleet()
        {
            weapon = new Armory();
            //robot2 = new Robot("Mr. Stabby", weapon.sword));
            //robot2 = new Robot("3-Sleepy-o", weapon.bat);
            //robot3 = new Robot("Glitch", weapon.blaster);
            fleet = new List<Robot>();
            fleet.Add(new Robot("Mr. Stabby\t", weapon.weaponsArray[0]));
            fleet.Add(new Robot("Glitch\t\t", weapon.weaponsArray[1]));
            fleet.Add(new Robot("3-Sleepy-o\t", weapon.weaponsArray[2])); 
        }

        //member methods
    }
}
