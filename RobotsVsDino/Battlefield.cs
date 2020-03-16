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
            drawLogo();
            Console.SetCursorPosition(0, 0);
            Console.Clear();
            
            int robotTarget = 0;
            int dinoTarget = 0;
            int robotAttacker = 0;
            int dinoAttacker = 0;
            int weaponChoice = 0;
            //robots attack first
            while (!IsThereAWinner())
            {

                // Petrolius.dinos.Count
                
                Console.WriteLine("Round Begins!");

                //robots attack first
                if (CheckDinoLife(dinoAttacker ) == false && dinoAttacker < 2) { dinoAttacker++; }
                if (CheckRobotLife(robotAttacker ) == false && robotAttacker < 2) { robotAttacker++; }
                Console.WriteLine("Choose the weapon of " + Solaris.robots[robotAttacker].name + ": ");
                Console.WriteLine("Enter 1 - Plasma Rifle, 2 - Gauss Cannon, 3 - RailGun:");
                weaponChoice = Convert.ToInt32( Console.ReadLine());
                Solaris.robots[robotAttacker].Attack(Petrolius.dinos[dinoTarget],weaponChoice);

                Console.WriteLine(Solaris.robots[robotAttacker].name + " attacked " + Petrolius.dinos[dinoTarget].dinoType);
                Console.WriteLine(Petrolius.dinos[dinoTarget].dinoType + " has " + Petrolius.dinos[dinoTarget].health + " Heath Left.");
                if (CheckDinoLife(dinoTarget) == false) { dinoTarget++; }


                //dinosaurs attack second
                if (CheckDinoLife(dinoAttacker) == false && dinoAttacker < 2) { dinoAttacker++; }
                if (CheckRobotLife(robotAttacker) == false && robotAttacker < 2) { robotAttacker++; }
                Console.WriteLine("Choose the attack of " + Petrolius.dinos[dinoAttacker].dinoType + ": ");
                Console.WriteLine("Enter 1 - Hyper Claw, 2 - Uber Bite, 3 - Tail Bash:");
                weaponChoice = Convert.ToInt32(Console.ReadLine());
                Petrolius.dinos[dinoAttacker].Attack(Solaris.robots[robotTarget],weaponChoice);

                Console.WriteLine(Petrolius.dinos[dinoAttacker].dinoType + " attacked " + Solaris.robots[robotTarget].name);

                Console.WriteLine(Solaris.robots[robotTarget].name + " has " + Solaris.robots[robotTarget].health + " health left.");


                
                if (CheckRobotLife(robotTarget) == false) { robotTarget++; }

                Console.ReadLine();
                
            }

        }

        public bool IsThereAWinner()
        {
            if (Petrolius.dinos[0].alive == false && Petrolius.dinos[1].alive == false && Petrolius.dinos[2].alive == false)
            {

                Console.WriteLine("Team Solaris Wins!");
                Console.ReadKey();
                return true;

            }
            else if(Solaris.robots[0].alive == false && Solaris.robots[1].alive == false && Solaris.robots[2].alive == false) 
            {

                Console.WriteLine("Team Petrolius Wins!");
                Console.ReadKey();
                return true;
            }
            else { return false; }
        }

        public bool CheckRobotLife(int currentTarget)
        {
            
           
            if(Solaris.robots[currentTarget].health <= 0)
            {
                Console.WriteLine(Solaris.robots[currentTarget].name + " is now dead!");
                Solaris.robots[currentTarget].alive = false;
                Console.WriteLine("Press enter to continue:");
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
                Console.WriteLine("Press enter to continue:");
                Petrolius.dinos[currentTarget].alive = false;
                return false;
            }
            else
            {
                return true;
            }
        }

        public void drawLogo()
        {
            Console.SetWindowSize(140,40);
            Console.WriteLine(@"                  ____  _                      _    _______       ____        __          __      
                 / __ \(_)___  ____  _____    | |  / / ___/      / __ \____  / /_  ____  / /______
                / / / / / __ \/ __ \/ ___/____| | / /\__ \______/ /_/ / __ \/ __ \/ __ \/ __/ ___/
               / /_/ / / / / / /_/ (__  )_____/ |/ /___/ /_____/ _, _/ /_/ / /_/ / /_/ / /_(__  ) 
              /_____/_/_/ /_/\____/____/      |___//____/     /_/ |_|\____/_.___/\____/\__/____/ 


+--------------------------------------------------------------------+---------------------------------------------------+
|                                                      ___._         |                          /[-])//  ___             |
|                                                    .'  <0>'-.._    |                     __ --\ `_/~--|  / \           |
|                                                   /  /.--.____')   |                   /_-/~~--~~ /~~~\\_\ /\          |
|                                                  |   \   __.-'~    |                   |  |___|===|_-- | \ \ \         |
|                                                  |  :  -'/         | _/~~~~~~~~|~~\,   ---|---\___/----|  \/\-\        |
|                                                 /:.  :.-'          | ~\________|__/   / // \__ |  ||  / | |   | |      |
| __________                                     | : '. |            |          ,~-|~~~~~\--, | \|--|/~|||  |   | |      |
| '--.____  '--------.______       _.----.-----./      :/            |          [3-|____---~~ _--'==;/ _,   |   |_|      |
|         \                 \      /                   /             |                      /   /\__|_/  \  \__/--/      |
|         '--.__            `'----/       '-.      __ :/             |                     /  /\/~--|   | |  \///        |
|               '-.___           :           \   .'  )/              |                    /  / |-__ \    |/              |
|                     '---._           _.-'   ] /  _/                |                   |--/ /      |-- | \             |
|                          '-._      _/     _/ / _/                  |                  \^~~\\/\      \   \/- _          |
|                              \_ .-'____.-'__< |  \___              |                   \    |  \     |~~\~~| \         |
|                                <_______.\    \_\_---.7             |                    \    \  \     \   \  | \       |
|                               |   /'=r_.-'     _\\ =/              |                      \    \ |     \   \    \      |
|                           .--'   /            ._/'>                |                       |~~|\/\|     \   \   |      |
|                         .'   _.-'                                  |                      |   |/         \_--_- |\     |
|                        / .--'                                      |                      |  /            /   |/\/     |
|                       /,/                                          |                       ~~             /  /         |
|                       |/`)                                         |                                     |__/          |
|                       'c=,                                         |                                                   |
|                                                                    |                                                   |
+--------------------------------------------------------------------+---------------------------------------------------+

                                                    
                                                       --==[ Press Enter ]==--
      
      
                                      +--------------------------------------------------------+
                                      |      __         _____        __    _____               |
                                      |  ___/ /__ _  __/ ___/__  ___/ /__ / ___/__ ___ _  ___  |
                                      | / _  / -_) |/ / /__/ _ \/ _  / -_) /__/ _ `/  ' \/ _ \ |
                                      | \_,_/\__/|___/\___/\___/\_,_/\__/\___/\_,_/_/_/_/ .__/ |
                                      |                                                /_/     |
                                      +--------------------------------------------------------+");
            Console.ReadKey();
        }
}
}
