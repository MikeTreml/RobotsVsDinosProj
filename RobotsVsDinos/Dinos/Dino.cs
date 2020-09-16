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
        public string[] attackNames = { "Drool","Roar", "Tail", "Claw", "Bite" };
        public int[] attackDamage = { 2, 6, 10, 20, 30 };
        
        //Constructor
        public Dino(string type)
        {
            // Every dino will start out with 100 percent health and energy. 
            //Attack power is set to 30.
            this.type = type;
            this.health = 100;
            this.energy = 100;
            this.attackPower = 0;
        }
        public Dino()
        {

        }

        //member methods
        public int DinoAttackChoice()
        {
            Console.Clear();
            for (int i = 0; i < attackNames.Length; i++)
            {
                Console.WriteLine((i + 1) + "  " + attackNames[i] + "    damage: " + attackDamage[i]);
            }
            Console.WriteLine("Please type the number to pick the Dino attack:");
            
            return attackDamage[int.Parse(Console.ReadLine()) - 1];
        }
    }
}
