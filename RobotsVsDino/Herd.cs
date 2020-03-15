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

            Tyrannosaurus.attackPower = 100;
            Tyrannosaurus.energy = 100;
            Tyrannosaurus.health = 100;
            Triceratops.attackPower = 100;
            Triceratops.energy = 100;
            Triceratops.health = 100;
            Velociraptor.attackPower = 100;
            Velociraptor.energy = 100;
            Velociraptor.health = 100;

            dinos.Add(Tyrannosaurus);
            dinos.Add(Triceratops);
            dinos.Add(Velociraptor);

        }

        
    }
}
