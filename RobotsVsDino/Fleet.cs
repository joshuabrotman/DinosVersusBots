using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDino
{
    class Fleet
    {
        Fleet(Robot[] robos)
        {
            Robot OptimusPrime = new Robot("Optimus Prime", "Plasma Rifle");
            Robot Sentinel = new Robot("Sentinel", "Plasma Laser");
            Robot Gundam = new Robot("Gundam", "RailGun");

            OptimusPrime.attackPower = 3000;
            OptimusPrime.health = 3450;
            OptimusPrime.powerLevel = 3640;
            Sentinel.attackPower = 1300;
            Sentinel.health = 4050;
            Sentinel.powerLevel = 495;
            Gundam.attackPower = 3050;
            Gundam.health = 4090;
            Gundam.powerLevel = 3750;
        }
    }
}
