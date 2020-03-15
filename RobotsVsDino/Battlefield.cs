using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDino
{
    class Battlefield
    {
        Herd Petrolius;
        Fleet Solaris;

        public Battlefield()
        {
            Petrolius = new Herd();
            Solaris = new Fleet();
        }
 

        public void Fight()
        {
            
            for (int target = 0; target < Petrolius.dinos.Count; target++)
            {

                Console.WriteLine("Attack Begin");
                Console.WriteLine(Petrolius.dinos[target].health);
                Solaris.robots[0].Attack(Petrolius.dinos[target]);
                checkLife(target);
                Console.WriteLine(Petrolius.dinos[target].health);

            }

            for (int target = 0; target < Solaris.robots.Count; target++)
            {


                Console.WriteLine(Solaris.robots[target].name + " has " + Solaris.robots[target].health + " health");
                Petrolius.dinos[target].Attack(Solaris.robots[target]);
                checkLife(target);
                Console.WriteLine(Solaris.robots[target].health);
                Console.ReadLine();
            }

        }

        public void checkLife(int i)
        {
            
            if (Petrolius.dinos[i].health <=0)
            {
                Console.WriteLine(Petrolius.dinos[i].dinoType + " is now dead!");
                Petrolius.dinos[i].alive = false;
            }
            if(Solaris.robots[i].health <= 0)
            {
                Console.WriteLine(Solaris.robots[i].name + "is now dead!");
                Solaris.robots[i].alive = false;
            }
            
        }


    }
}
