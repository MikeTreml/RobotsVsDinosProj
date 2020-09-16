using RobotsVsDinos.Robots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    class Robot
    {
        //member Variables 
        public string name;
        public int health;
        public int powerLevel;
        //public Weapon weapon;
        public Weapon weapon;

        //Constructor
        public Robot(string name, Weapon weapon)
        {
            // Every robots will start out with 100 percent health and powerlevel. 
            this.name = name;
            this.health = 100;
            this.powerLevel = 100;
            this.weapon = weapon;
        }
        


        //member methods
    }
}
