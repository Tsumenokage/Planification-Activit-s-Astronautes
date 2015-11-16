using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Astronauts_Activities
{
    class Activity
    {
        public string Name {get; private set;}
        private string Description;

        public Activity(string Name)
        {
            this.Name = Name;
        }
    }
}