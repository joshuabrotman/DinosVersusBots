using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDino
{
    class Herd
    {

        public Herd(Dinosaur[] dinos)
        {
            Dinosaur Tyrannosaurus = new Dinosaur("Tyrannosaurus");
            Dinosaur Triceratops = new Dinosaur("Triceratops");
            Dinosaur Velociraptor = new Dinosaur("Velociraptor");

            Tyrannosaurus.attackPower = 250;
            Tyrannosaurus.energy = 125;
            Tyrannosaurus.health = 100;
            Triceratops.attackPower = 200;
            Triceratops.energy = 175;
            Triceratops.health = 100;
            Velociraptor.attackPower = 225;
            Velociraptor.energy = 125;
            Velociraptor.health = 100;
        }
    }
}
