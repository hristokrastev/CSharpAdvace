using System;
using System.Collections.Generic;
using System.Text;

namespace Three
{
    public class Rabbit
    {
        public string Name { get; set; }

        public string Species { get; set; }

        public bool Available { get; set; }

        public Rabbit()
        {
            this.Available = true;
        }
        public Rabbit(string name, string species)
            :this()
        {
            this.Name = name;
            this.Species = species;
        }
        public override string ToString()
        {
            return $"Rabbit ({this.Species}): {this.Name}";
            
        }
    }
}
