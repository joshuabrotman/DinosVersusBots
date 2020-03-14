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
            Console.WriteLine("Press D for dinos to attack first, R for Robots.");
            Console.WriteLine(Petrolius.dinos[0]);
            Solaris.robots[0].Attack(Petrolius.dinos[0]);
            Console.WriteLine(Petrolius.dinos[0]);
            Console.ReadLine();
        }

    }
}
