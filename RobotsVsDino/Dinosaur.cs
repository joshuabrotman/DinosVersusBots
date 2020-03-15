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

        public void drawDinosaur(int DinosaurType)
        {
            Console.SetCursorPosition(2, 2);
            switch (DinosaurType)
            {
                case 2:

                    Console.WriteLine(@"|                                                     ___._      ");
                    Console.WriteLine(@"|                                                   .'  <0>'-.._ ");
                    Console.WriteLine(@"|                                                  /  /.--.____')");
                    Console.WriteLine(@"|                                                 |   \   __.-'~ ");
                    Console.WriteLine(@"|                                                 |  :  -'/    ");
                    Console.WriteLine(@"|                                                /:.  :.-'     ");
                    Console.WriteLine(@"|__________                                     | : '. |       ");
                    Console.WriteLine(@"|'--.____  '--------.______       _.----.-----./      :/       ");
                    Console.WriteLine(@"|        '--.__            `'----/       '-.      __ :/        ");
                    Console.WriteLine(@"|              '-.___           :           \   .'  )/         ");
                    Console.WriteLine(@"|                    '---._           _.-'   ] /  _/           ");
                    Console.WriteLine(@"|                         '-._      _/     _/ / _/             ");
                    Console.WriteLine(@"|                             \_ .-'____.-'__< |  \___         ");
                    Console.WriteLine(@"|                               < _______.\    \_\_---.7       ");
                    Console.WriteLine(@"|                              |   /'=r_.-'     _\\ =/         ");
                    Console.WriteLine(@"|                          .--'   /            ._/'>           ");
                    Console.WriteLine(@"|                        .'   _.-'                             ");
                    Console.WriteLine(@"|                       / .--'                                 ");
                    Console.WriteLine(@"|                      /,/                                     ");
                    Console.WriteLine(@"|                      |/`)                                    ");
                    Console.WriteLine(@"|                      'c=,                                    ");
                    break;
                case 0:
                    Console.WriteLine(@"|                                              ____           ");
                    Console.WriteLine(@"|  ___                                      .-~    '.         ");
                    Console.WriteLine(@"| `-._~-.                                  / /  ~@\   )       ");
                    Console.WriteLine(@"|      \  \                               | /  \~\.  `\       ");
                    Console.WriteLine(@"|      ]  |                              /  |  |< ~\(..)      ");
                    Console.WriteLine(@"|     /   !                        _.--~T   \  \<   .,,       ");
                    Console.WriteLine(@"|    /   /                 ____.--~ .    _  /~\ \< /          ");
                    Console.WriteLine(@"|  /   /             .-~~'        /|   /o\ /-~\ \_|           ");
                    Console.WriteLine(@"|  /   /             /     )      |o|  / /|o/_   '--'         ");
                    Console.WriteLine(@"|  /   /           .-'(     l__   _j \_/ / /\|~    .          ");
                    Console.WriteLine(@"| /    l          /    \       ~~~|    `/ / / \.__/l_         ");
                    Console.WriteLine(@"| |     \     _.-'      ~-\__     l      /_/~-.___.--~        ");
                    Console.WriteLine(@"| |      ~---~           /   ~~'---\_    __[o,                ");
                    Console.WriteLine(@"| l  .                _.    ___     _>-/~                     ");
                    Console.WriteLine(@"| \  \     .      .-~   .-~   ~>--'  /                        ");
                    Console.WriteLine(@"|  \  ~---'            /         _.-'                         ");
                    Console.WriteLine(@"|   '-.,_____.,_  _.--~\     _.-~                             ");
                    Console.WriteLine(@"|               ~~     (   _}                                 ");
                    Console.WriteLine(@"|                      `. ~(                                  ");
                    Console.WriteLine(@"|                        )  \                                 ");
                    Console.WriteLine(@"|                  /,`--'~\--'~\                              ");
                    break;
                case 1:
                    Console.WriteLine(@"
|                      . - ~ ~ ~ - .
|                  .-~               ~-.      _     ..      
|                 .`                      ~..'/     |\\     
|                /  /       \             {  {     | ||    
|               /  {         |                 '..^~\ \\   /)
|              /    \        |       }       \      o  ~-.`/ 
|            .`      \       |        \       |          __) 
|          .`      _ -\      |^ ~ ~ - _\      |_.- ~ ~ - -`  
|     _ -~     .-~     \     |          \     |              
|\_-_~_ _ . - ~         |_____|          |_____|  
|                                                          
|                                            
|                                                          ");
                    break;
            }
        }
        

    }
}
