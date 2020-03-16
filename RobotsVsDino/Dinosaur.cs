using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RobotsVsDino
{
    class Dinosaur
    {
        public string dinoType;
        public int health;
        public int energy;
        public string[] attackType;
        public int attackPower;
        public bool alive;
        public Dinosaur(string typeOfDino)
        {
            health = 100;
            energy = 100;
            attackPower = 100;
            dinoType = typeOfDino;
            alive = true;
            attackType = new string[3] { "Hyper Claw", "Uber Bite", "Tail Bash" };

        }


        public void Attack(Robot Target, int attackType)
        {
            
            Random random = new Random();
            Thread.Sleep(750);
            attackType -= 1;
            switch (attackType)
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
