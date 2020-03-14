using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDino
{
    class Herd
    {
        public List<Dinosaur> dinos;

        public Herd()
        {
            dinos = new List<Dinosaur>();

            Dinosaur Tyrannosaurus = new Dinosaur("Tyrannosaurus");
            Dinosaur Triceratops = new Dinosaur("Triceratops");
            Dinosaur Velociraptor = new Dinosaur("Velociraptor");

            Tyrannosaurus.attackPower = 2500;
            Tyrannosaurus.energy = 1250;
            Tyrannosaurus.health = 1000;
            Triceratops.attackPower = 2000;
            Triceratops.energy = 1750;
            Triceratops.health = 1000;
            Velociraptor.attackPower = 2250;
            Velociraptor.energy = 1250;
            Velociraptor.health = 1000;

            dinos.Add(Tyrannosaurus);
            dinos.Add(Triceratops);
            dinos.Add(Velociraptor);

        }

        
    }
}
