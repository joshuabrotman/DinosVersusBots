using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDino
{
    class Fleet
    {
        public List<Robot> robots;

        public Fleet()
        {
            robots = new List<Robot>();

            Robot OptimusPrime = new Robot("Optimus Prime");
            Robot Sentinel = new Robot("Sentinel");
            Robot Gundam = new Robot("Gundam");

            OptimusPrime.health = 100;
            OptimusPrime.powerLevel = 100;
            OptimusPrime.attackPower = 100;
            Sentinel.health = 100;
            Sentinel.powerLevel = 100;
            Sentinel.attackPower = 100;
            Gundam.health = 100;
            Gundam.powerLevel = 100;
            Gundam.attackPower = 100;


            robots.Add(Sentinel);
            robots.Add(OptimusPrime);
            robots.Add(Gundam);

            
        }
    }
}
