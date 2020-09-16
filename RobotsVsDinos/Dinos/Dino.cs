using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    class Dino
    {
        //member Variables 
        public string type;
        public int health;
        public int energy;
        public int attackPower;

        //Constructor
        public Dino(string type)
        {
            // Every dino will start out with 100 percent health and energy. 
            //Attack power is set to 30.
            this.type = type;
            this.health = 100;
            this.energy = 100;
            this.attackPower = 102;
        }

        

        //member methods
    }
}
