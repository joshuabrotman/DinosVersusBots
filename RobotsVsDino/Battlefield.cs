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
            for (int currentVictim = 0; currentVictim <= Petrolius.dinos.Count; currentVictim++)
            {

                Console.WriteLine("Attack Begin");
                Console.WriteLine(Petrolius.dinos[currentVictim].health);
                Solaris.robots[0].Attack(Petrolius.dinos[currentVictim]);
                checkLife(currentVictim);
                Console.WriteLine(Petrolius.dinos[currentVictim].health);

                Console.WriteLine(Solaris.robots[currentVictim].health);
                Petrolius.dinos[currentVictim].Attack(Solaris.robots[currentVictim]);
                checkLife(currentVictim);
                Console.WriteLine(Solaris.robots[currentVictim].health);
                Console.ReadLine();
            }

        }

        public void checkLife(int i)
        {
            
            if (Petrolius.dinos[i].health <=0)
            {
                Console.WriteLine(Petrolius.dinos[i].dinoType + " is now dead!");
            }
        }


    }
}
