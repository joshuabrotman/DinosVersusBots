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
            drawBorder();
            Console.SetCursorPosition(0, 30);
            int robotTarget = 0;
            int dinoTarget = 0;
            //robots attack first
            while (!IsThereAWinner())
            {

                // Petrolius.dinos.Count
                
                Console.WriteLine("Round Begins!");
                Petrolius.dinos[dinoTarget].drawDinosaur(dinoTarget);
                Solaris.robots[dinoTarget].Attack(Petrolius.dinos[dinoTarget]);


                Console.WriteLine(Solaris.robots[dinoTarget].name + " attacked " + Petrolius.dinos[dinoTarget].dinoType);

                Console.WriteLine(Petrolius.dinos[dinoTarget].dinoType + " has " + Petrolius.dinos[dinoTarget].health + " Heath Left.");
                if (CheckDinoLife(dinoTarget) == false) { dinoTarget++; }


                
                Petrolius.dinos[robotTarget].Attack(Solaris.robots[robotTarget]);

                Console.WriteLine(Petrolius.dinos[robotTarget].dinoType + " attacked " + Solaris.robots[robotTarget].name);

                Console.WriteLine(Solaris.robots[robotTarget].name + " has " + Solaris.robots[robotTarget].health + " health");


                Console.WriteLine(Solaris.robots[robotTarget].health);
                if (CheckDinoLife(robotTarget) == false) { robotTarget++; }

                Console.ReadLine();
                
            }

        }

        public bool IsThereAWinner()
        {
            if (Petrolius.dinos[0].alive == false && Petrolius.dinos[1].alive == false && Petrolius.dinos[2].alive == false)
            {

                Console.WriteLine("Team Petrolius Wins!");
                Console.ReadKey();
                return true;

            }
            else if(Solaris.robots[0].alive == false && Solaris.robots[1].alive == false && Solaris.robots[2].alive == false) 
            {

                Console.WriteLine("Team Solaris Wins!");
                Console.ReadKey();
                return true;
            }
            else { return false; }
        }

        public bool CheckRobotLife(int currentTarget)
        {
            
           
            if(Solaris.robots[currentTarget].health <= 0)
            {
                Console.WriteLine(Solaris.robots[currentTarget].name + "is now dead!");
                Solaris.robots[currentTarget].alive = false;
                return false;
            }
            else
            {
                return true;
            }
            
        }

        public bool CheckDinoLife(int currentTarget)
        {
            if (Petrolius.dinos[currentTarget].health <= 0)
            {
                Console.WriteLine(Petrolius.dinos[currentTarget].dinoType + " is now dead!");
                Petrolius.dinos[currentTarget].alive = false;
                return false;
            }
            else
            {
                return true;
            }
        }

        public void drawBorder()
        {
            Console.SetWindowSize(140,40);
            Console.WriteLine("+----------------------------------------------------------------+--------------------------------------------------------------+");
            Console.WriteLine("|                                                                |                                                              |");
            Console.WriteLine("|                                                                |                                                              |");
            Console.WriteLine("|                                                                |                                                              |");
            Console.WriteLine("|                                                                |                                                              |");
            Console.WriteLine("|                                                                |                                                              |");
            Console.WriteLine("|                                                                |                                                              |");
            Console.WriteLine("|                                                                |                                                              |");
            Console.WriteLine("|                                                                |                                                              |");
            Console.WriteLine("|                                                                |                                                              |");
            Console.WriteLine("|                                                                |                                                              |");
            Console.WriteLine("|                                                                |                                                              |");
            Console.WriteLine("|                                                                |                                                              |");
            Console.WriteLine("|                                                                |                                                              |");
            Console.WriteLine("|                                                                |                                                              |");
            Console.WriteLine("|                                                                |                                                              |");
            Console.WriteLine("|                                                                |                                                              |");
            Console.WriteLine("|                                                                |                                                              |");
            Console.WriteLine("|                                                                |                                                              |");
            Console.WriteLine("|                                                                |                                                              |");
            Console.WriteLine("|                                                                |                                                              |");
            Console.WriteLine("|                                                                |                                                              |");
            Console.WriteLine("|                                                                |                                                              |");
            Console.WriteLine("|                                                                |                                                              |");
            Console.WriteLine("+----------------------------------------------------------------+--------------------------------------------------------------+");
        }
}
}
