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

            Robot OptimusPrime = new Robot("Optimus Prime", "Plasma Rifle");
            Robot Sentinel = new Robot("Sentinel", "Plasma Laser");
            Robot Gundam = new Robot("Gundam", "RailGun");

            

            robots.Add(Sentinel);
            robots.Add(OptimusPrime);
            robots.Add(Gundam);

            
        }
    }
}
