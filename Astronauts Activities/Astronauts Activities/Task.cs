using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Astronauts_Activities
{
    public class Task
    {
        //Variables
        public string Name { get; private set; }
        private Activity Activity;
        public List<Astronaut> Astronauts { get; private set; }
        public Place TaskPlace {get; private set;}
        private string Description;
        public int StartHour {get; private set;}
        public int DurationMinute {get; private set;}

        public Task(Activity Tactivity, List<Astronaut> Tastronauts, Place Tplace, int DureeMinute, int StartHour) //ajouter dates
        {
            Name = Tactivity.Name;
            Activity = Tactivity;
            TaskPlace = Tplace;
            this.DurationMinute = DureeMinute;
            this.StartHour = StartHour;
            Astronauts = Tastronauts;
        }

        public Task(Activity Tactivity, List<Astronaut> Tastronauts, int DureeMinute, int StartHour) //ajouter dates
        {
            Name = Tactivity.Name;
            Activity = Tactivity;
            this.DurationMinute = DureeMinute;
            this.StartHour = StartHour;
            Astronauts = Tastronauts;
        }

        public Task(Activity Tactivity, List<Astronaut> Tastronauts, Place Tplace, int DureeMinute, int StartHour, string Description) //ajouter dates
        {
            Name = Tactivity.Name;
            Activity = Tactivity;
            TaskPlace = Tplace;
            this.DurationMinute = DureeMinute;
            this.StartHour = StartHour;
            Astronauts = Tastronauts;
            this.Description = Description;
        }

        public Task(Activity Tactivity, List<Astronaut> Tastronauts, int DureeMinute, int StartHour, string Description) //ajouter dates
        {
            Name = Tactivity.Name;
            Activity = Tactivity;
            this.DurationMinute = DureeMinute;
            this.StartHour = StartHour;
            Astronauts = Tastronauts;
            this.Description = Description;
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

        public string[] getInfo()
        {
            string[] arr = new string[4];

            arr[0] = "";
            //arr[1] = this.StartHour.ToString();
            arr[1] = FormatHour(this.StartHour);
            int EndTask = StartHour + DurationMinute;
            //arr[2] = EndTask.ToString();
            arr[2] = FormatHour(EndTask);
            arr[3] = this.Name;
            return arr;

        }

        private string FormatHour(int Time)
        {
            string HourFormat;
            int Minutes = Time % 60;
            Time = Time - Minutes;
            int Hours = Time / 60;

            
            HourFormat = Hours.ToString() + "H" + Minutes.ToString();
            if (Minutes == 0)
                HourFormat += "0";
            return HourFormat;

        }
    }

    /*Note pour la calcul des correspondance entre Heure Terrestre et Martienne  : 
        1) Calculer le nombre de secondes depuis le lancement sur Terre à l'heure 00
        2) Calculer le nombre de Jour, Heures, Minutes, secondes écoulés depuis ce moment*/
}
