using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace RobotsVsDinos
{
    class Battlefield
    {
        //member Variables 
        public Fleet fleet;
        public Herd herd;
        int attackDrain = 10;
        public Dino dinoAttack = new Dino();

        //consttructor
        public Battlefield()
        {
            fleet = new Fleet();
            herd = new Herd();
            bool battle = true;
            string winner = "";
            do
            {
                if (battle == true && fleet.fleet.Count >= 1 && herd.herd.Count >= 1)
                {
                    DislayBattle(fleet, herd);
                    DinoAttack(fleet, 0, herd, 0);
                }
                else if (battle == true && herd.herd.Count >= 1)
                {
                    battle = false;
                    winner = "The Dinos have Won!";
                }

                if (battle == true && herd.herd.Count >= 1 && fleet.fleet.Count >= 1)
                {
                    DislayBattle(fleet, herd);
                    RobotAttack(fleet, 0, herd, 0);
                }
                else if (battle == true && fleet.fleet.Count >= 1)
                {
                    battle = false;
                    winner = "The Robots have Won!";
                }
            } while (battle);
            
            DisplayWinner(winner);


        }
        //member methods
        public void DisplayWinner(string winner)
        {
            Console.Clear();
            Console.WriteLine("**************************");
            Console.WriteLine("*                        *");
            Console.WriteLine("   "+winner);
            Console.WriteLine("*                        *");
            Console.WriteLine("**************************");
            Console.ReadLine();
        }
        public void DislayBattle(Fleet robot, Herd dino)
        {
            Console.Clear();
            Console.WriteLine("\n\t-------- Dinos -----------\n");
            for (int i = 0; i < dino.herd.Count; i++)
            {
                Console.WriteLine("  " + dino.herd[i].type + "   Energy:" + dino.herd[i].energy + "  Health:" + dino.herd[i].health);
                
            }
            Console.WriteLine("\n\t---------------------------");
            Console.WriteLine("\t--- Battle Feild ----------");
            Console.WriteLine("\t---------------------------\n");
            Console.WriteLine("\t--------- Robots ----------\n");
            for (int i = 0; i < robot.fleet.Count; i++)
            {
                Console.Write("  " + robot.fleet[i].name + "   Power:" + robot.fleet[i].powerLevel + "  Health:" + robot.fleet[i].health);
                Console.WriteLine("   " + robot.fleet[i].weapon.type + " AttackPower:" + robot.fleet[i].weapon.attackPower);
            }
            Console.WriteLine("hit any key to continue to the next step.");
            Console.ReadLine();

        }
        
        //for the attacks I passed in an int to give the option to pick who would attack and who would defend for future upgrades
        // 0 is current passed in to default the the first attacker and first defender.
        public void DinoAttack(Fleet robot, int robotSelect, Herd dino, int dinoSelect) // ot sure if i should pass in a int valuen
        {
            int damage = dino.herd[dinoSelect].attackPower + dinoAttack.DinoAttackChoice();
            robot.fleet[robotSelect].health -= damage;
            dino.herd[dinoSelect].energy -= attackDrain;
            Console.WriteLine(Regex.Replace(dino.herd[dinoSelect].type+" attack "+robot.fleet[robotSelect].name +" for " + damage+" points of damage", " {2,}", " "));
            Console.WriteLine("any key to continue.");
            Console.ReadLine();
            RobotDeath(robot, robotSelect);
            


        }
        public void RobotAttack(Fleet robot, int robotSelect, Herd dino, int dinoSelect) // not sure if i should pass in a int value
        {
            int damage = robot.fleet[robotSelect].weapon.attackPower;
            dino.herd[dinoSelect].health -= damage;
            robot.fleet[robotSelect].powerLevel -= attackDrain;
            Console.WriteLine(Regex.Replace(robot.fleet[robotSelect].name + " attack " + dino.herd[dinoSelect].type + " for " + damage + " points of damage", " {2,}", " "));
            Console.WriteLine("any key to continue.");
            Console.ReadLine();
            DinoDeath(dino, dinoSelect);


        }
        public void RobotDeath(Fleet robot, int robotSelect)
        {
            if (robot.fleet[robotSelect].health <= 0)
            {
                
                Console.WriteLine(Regex.Replace("Robot " + robot.fleet[robotSelect].name + " Died", " {2,}", " "));
                Console.WriteLine("any key to continue.");
                Console.ReadLine();
                robot.fleet.RemoveAt(robotSelect);
            }
        }
        public void DinoDeath(Herd dino, int dinoSelect)
        {
            if (dino.herd[dinoSelect].health <= 0)
            {
                
                Console.WriteLine(Regex.Replace("Dino " + dino.herd[dinoSelect].type + " Died", " {2,}", " "));
                Console.WriteLine("any key to continue.");
                Console.ReadLine();
                dino.herd.RemoveAt(dinoSelect);
            }

        }
       
    }
}
