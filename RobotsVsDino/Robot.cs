using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RobotsVsDino
{
    class Robot
    {
        public string name;
        public int health;
        public int powerLevel;
        public string[] weapon;
        public int attackPower;
        public bool alive;
        

        public Robot(string robotName)
        {
            name = robotName;
            health = 100;
            powerLevel = 100;
            attackPower = 100;
            weapon = new string[3] { "Plasma Rifle", "Gauss Cannon", "Rail Gun"};
            alive = true;

        }

        public void Attack(Dinosaur Target, int weaponType)
        {
            Random random = new Random();
            Thread.Sleep(750);
            weaponType -= 1;
            switch (weaponType)
            {
                case 0:
                    Target.health -= random.Next(random.Next(0, 1), random.Next(50, 75));
                    break;
                case 1:
                    Target.health -= random.Next(random.Next(30, 40), random.Next(50, 75));
                    break;
                case 2:
                    Target.health -= random.Next(random.Next(70, 75), random.Next(75, 100));
                    break;
                default:
                    Console.WriteLine("The weapon is unknown! turn lost!");
                    break;
            }
        }

    }
}
