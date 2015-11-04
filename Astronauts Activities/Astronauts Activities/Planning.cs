using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Astronauts_Activities
{
    class Planning
    {
       public List<Day> Calendar { get; private set; }

        public Planning ()
        {
            Calendar = new List<Day>();
            for (int i = 0; i < 500; i++)
            {
                Day day = new Day(i + 1);
                Calendar.Add(day);
            }
        }
    }
}
