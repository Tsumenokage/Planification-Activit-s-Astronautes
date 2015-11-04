using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Astronauts_Activities
{
    class OutsideActivity : Activity
    {
        private Place place;

        public OutsideActivity(String Name, Place place) : base(Name)
        {
            this.place = place;
        }
    }
}
