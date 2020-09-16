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
            string robot1 = "Mr. Stabby  ";
            string robot2 = "Glitch      ";
            string robot3 = "3-Sleepy-o  ";
            fleet = new List<Robot>();
            RobotWeaponChoice(robot1);
            RobotWeaponChoice(robot2);
            RobotWeaponChoice(robot3);
            fleet.Add(new Robot(robot1, weapon.weaponsChoice[0]));
            fleet.Add(new Robot(robot2, weapon.weaponsChoice[1]));
            fleet.Add(new Robot(robot3, weapon.weaponsChoice[2]));
        }

        //member methods
        public void RobotWeaponChoice(string name)
        {
            int choice = 0;
            Console.Clear();
            for (int i = 0; i < weapon.weaponsArray.Count; i++)
            {
                Console.WriteLine("   "+(i + 1) + "  " + weapon.weaponsArray[i].type);
            }
            
            Console.WriteLine(" Please type the number to select a weapon for robot " + name);
            choice = int.Parse(Console.ReadLine()) - 1;
            weapon.weaponsChoice.Add(weapon.weaponsArray[choice]);
            weapon.weaponsArray.RemoveAt(choice);

        }
    }
}
