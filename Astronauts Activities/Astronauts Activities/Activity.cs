using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Astronauts_Activities
{
    public class Activity
    {
        public List<Activity> Activities { get; protected set; }
        public string Name {get; private set;}
        private string Description;

        public Activity(string Name)
        {
            this.Name = Name;
        }
    }
}