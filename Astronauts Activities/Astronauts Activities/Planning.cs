using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Astronauts_Activities
{
    // La classe regroupant les différents jours. C'est ce qui est affiché dans le niveau 1 (Mission.cs) de l'application.
    public class Planning
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
