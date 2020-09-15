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
        Armory weapons = new Armory();

        
       
        public List<Robot> fleet;
        
        Robot robot1 = new Robot("Mr. Stabby");
        Robot robot2 = new Robot("3-Sleepy-o");
        Robot robot3 = new Robot("Glitch");
        


        //Constructor
        public Fleet()
        {
            fleet = new List<Robot>();
            fleet.Add(robot1);
            fleet.Add(robot2);
            fleet.Add(robot3);
            
        }

        //member methods
    }
}
