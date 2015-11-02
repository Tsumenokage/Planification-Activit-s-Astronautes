using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Astronauts_Activities
{
    class Astronaut
    {
        private string Name { get; set; }
        private bool Available { get; set; } //Can be used to stop an astronaut from doing 2 tasks at once

        public Astronaut(string n)
        {
            Name = n;
            Available = true;
        }

        public override string ToString()
        {
            if (Available == true)
            { return Name + " is available"; }
            else
            { return Name + " is not available"; }
        }
    }
}
