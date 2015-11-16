using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Astronauts_Activities
{
    class Task
    {
        //Variables
        public string Name { get; private set; }
        private Activity Activity;
        public List<Astronaut> Astronauts { get; private set; }
        private Place TaskPlace;
        private string Description;
        private int StartHour;
        private int DureeMinute;

        public Task(Activity Tactivity, List<Astronaut> Tastronauts, Place Tplace, int DureeMinute, int StartHour) //ajouter dates
        {
            Name = Tactivity.Name;
            Activity = Tactivity;
            TaskPlace = Tplace;
            this.DureeMinute = DureeMinute;
            this.StartHour = StartHour;
        }

        public Task(Activity Tactivity, List<Astronaut> Tastronauts, int DureeMinute,int StartHour) //ajouter dates
        {
            Name = Tactivity.Name;
            Activity = Tactivity;
            this.DureeMinute = DureeMinute;
            this.StartHour = StartHour; 
        }

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
