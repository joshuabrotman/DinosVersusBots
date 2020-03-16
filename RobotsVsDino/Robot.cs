using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDino
{
    class Robot
    {
        public string name;
        public int health;
        public int powerLevel;
        public string weapon;
        public int attackPower;
        public bool alive;

        public Robot(string robotName, string weaponName)
        {
            name = robotName;
            health = 100;
            powerLevel = 100;
            weapon = weaponName;
            attackPower = 100;
            alive = true;

        }

        public void Attack(Dinosaur Target)
        {
            Random random = new Random();
            Target.health -= random.Next(0, 50);
        }

    }
}
