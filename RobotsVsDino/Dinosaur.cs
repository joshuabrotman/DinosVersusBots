using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDino
{
    class Dinosaur
    {
        public string dinoType;
        public int health;
        public int energy;
        public int attackPower;
        public bool alive;
        public Dinosaur(string typeOfDino)
        {
            health = 100;
            energy = 100;
            attackPower = 100;
            dinoType = typeOfDino;
            alive = true;

        }


        public void Attack(Robot Victim)
        {
            Victim.health -= Victim.health - 10;
        }

    }
}
