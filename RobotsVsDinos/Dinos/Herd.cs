using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    class Herd
    {
        //member Variables 
        public List<Dino> herd;
        Dino dino1 = new Dino("Dr. Raptor\t");
        Dino dino2 = new Dino("T-Rob\t\t");
        Dino dino3 = new Dino("Sloth-A-Saurs\t");

        //Constructor
        public Herd()
        {
            herd = new List<Dino>();
            herd.Add(dino1);
            herd.Add(dino2);
            herd.Add(dino3);
        }

        //member methods
    }
}
