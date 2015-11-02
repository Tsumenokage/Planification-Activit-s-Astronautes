using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Astronauts_Activities
{
    class Task
    {
        //Variables
        private string Name;
        private Activity Activity;
        private List<Astronaut> Astronauts;
        private Place TaskPlace;
        private string Description;
        //Mettre une date de début et une date de fin selon nos définitions

        //Fonctions de base de gestion des astronautes
        public void AddAstronaut(Astronaut astronaut)
        {
            if (astronaut.Available == true)
            {
                Astronauts.Add(astronaut);
                astronaut.Available = false;
            }
            else
            {
                Console.WriteLine("This astronaut is not available");
            }
        }

        public void RemoveAstronaut(Astronaut astronaut)
        {
            try
            {
                Astronauts.Remove(astronaut);
                astronaut.Available = true;
            }
            catch
            { Console.WriteLine("{0} is not assigned to this task", astronaut.Name); }
        }
    }
}
