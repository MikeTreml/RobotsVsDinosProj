using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    class Battlefield
    {
        //member Variables 
        public Fleet fleet;
        public Herd herd;
        int attackDrain = 10;


        //consttructor
        public Battlefield()
        {
            fleet = new Fleet();
            herd = new Herd();
            while (fleet.fleet.Count!=0&&herd.herd.Count!=0)
            {
                DislayBattle(fleet, herd);
                DinoAttack(fleet, 0, herd, 0);
                //may need an if to break when all are dead
                DislayBattle(fleet, herd);
                RobotAttack(fleet, 0, herd, 0);
            }
            
        }

        public void DislayBattle(Fleet robot,Herd dino) 
        {
            Console.Clear();
            Console.WriteLine("-------- Dinos -----------\n");
            for (int i = 0; i < dino.herd.Count; i++)
            {
                Console.Write(" " + dino.herd[i].type + "   Energy:" + dino.herd[i].energy + "  Health:" + dino.herd[i].health);
                Console.WriteLine("   "+"Claw"+"  AttackPower:" + dino.herd[i].attackPower);
            }
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("--- Battle Feild ----------");
            Console.WriteLine("--------------------------\n");
            Console.WriteLine("--------- Robots ----------\n");
            for (int i = 0; i < robot.fleet.Count; i++)
            {
                Console.Write(" " + robot.fleet[i].name + "   Power:" + robot.fleet[i].powerLevel + "  Health:" + robot.fleet[i].health);
                Console.WriteLine("   " + robot.fleet[i].weapon.type + " AttackPower:" + robot.fleet[i].weapon.attackPower);
            }
            Console.ReadLine();
            
        }
        //member methods
        public void DinoAttack(Fleet robot, int robotSelect,Herd dino,int dinoSelect) // not sure if i should pass in a int value
        {
            robot.fleet[robotSelect].health -= dino.herd[dinoSelect].attackPower;
            dino.herd[dinoSelect].energy -= attackDrain;
            RobotDeath(robot, robotSelect);

        }
        public void RobotAttack(Fleet robot, int robotSelect, Herd dino, int dinoSelect) // not sure if i should pass in a int value
        {
            dino.herd[dinoSelect].health -= robot.fleet[robotSelect].weapon.attackPower;
            robot.fleet[robotSelect].powerLevel -= attackDrain;
            DinoDeath(dino, dinoSelect);


        }
        public void RobotDeath(Fleet robot, int robotSelect)
        {
           if(robot.fleet[robotSelect].health<=0)
            {
                Console.WriteLine("Robot "+robot.fleet[robotSelect].name+" Died");
                robot.fleet.RemoveAt(robotSelect);
            }
        }
        public void DinoDeath(Herd dino, int dinoSelect)
        {
            if (dino.herd[dinoSelect].health <= 0)
            {
                Console.WriteLine("Dino " + dino.herd[dinoSelect].type + " Died");
                dino.herd.RemoveAt(dinoSelect);
            }

        }

    }
}
