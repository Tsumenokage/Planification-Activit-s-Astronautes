using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Astronauts_Activities
{
    /// <summary>
    /// Classe principale de l'application. Les objets sont instanciés à des valeurs par défaut mais ils peuvent être supprimés, édités et / ou ajoutés.
    /// Ils sont liés à une activité (Activity). Astronauts définit les astronautes réalisant la tâche. Description le descriptif de 400 caractères.
    /// StartHour et DurationMinute définissent la plage horaire de la tâche. Cette solution a été choisie au lieu d'un StartHour et d'un EndHour pour faciliter les calculs.
    /// Les coordonnées Xposition et Yposition permettent le répérage sur la carte.
    /// </summary>

    public class Task
    {
        //Variables
        public string Name { get; private set; }
        private Activity Activity;
        public List<Astronaut> Astronauts { get; private set; }
        public string Description { get; private set; }
        public int StartHour {get; private set;}
        public int DurationMinute {get; private set;}
        public int Xposition { get; private set; }
        public int Yposition { get; private set; }

        /// <summary>
        /// Constructeur de la classe Task
        /// </summary>
        /// <param name="Tactivity">Activité relative à la tâche</param>
        /// <param name="Tastronauts">Liste des astronautes qui effectue la tâche</param>
        /// <param name="DureeMinute">Durée de la tâche</param>
        /// <param name="StartHour">Début de la tâche</param>
        /// <param name="X">Position X</param>
        /// <param name="Y">Position Y</param>
        public Task(Activity Tactivity, List<Astronaut> Tastronauts, int DureeMinute, int StartHour, int X, int Y) //ajouter dates
        {
            Name = Tactivity.Name;
            Activity = Tactivity;
            this.DurationMinute = DureeMinute;
            this.StartHour = StartHour;
            Astronauts = Tastronauts;
            this.Xposition = X;
            this.Yposition = Y;
        }

        /// <summary>
        /// Constructeur de la classe Task
        /// </summary>
        /// <param name="Tactivity">Activité relative à la tâche</param>
        /// <param name="Tastronauts">Liste des astronautes qui effectue la tâche</param>
        /// <param name="DureeMinute">Durée de la tâche</param>
        /// <param name="StartHour">Début de la tâche</param>
        /// <param name="Description">Description de la tâche</param>
        /// <param name="X">Position X</param>
        /// <param name="Y">Position Y</param>
        public Task(Activity Tactivity, List<Astronaut> Tastronauts, int DureeMinute, int StartHour, string Description, int X, int Y)
        {
            Name = Tactivity.Name;
            Activity = Tactivity;
            this.DurationMinute = DureeMinute;
            this.StartHour = StartHour;
            Astronauts = Tastronauts;
            this.Description = Description;
            this.Xposition = X;
            this.Yposition = Y;
        }

        /// <summary>
        /// Fonction qui va ajouter un astronaute à la tâche
        /// </summary>
        /// <param name="astronaut">Astronaute à ajouter</param>
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

        /// <summary>
        /// Fonction qui va supprimer un Astronaute de la tâche
        /// </summary>
        /// <param name="astronaut">Astronaute à supprimmer</param>
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


        /// <summary>
        /// Va retourner les informations de la tâches sous formes de tableau
        /// </summary>
        /// <returns>Détails de la tâche sous forme de tableau</returns>
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


        /// <summary>
        /// Transforme une durée en minute en affichage de l'heure sous la forme suivante : Heure H Minute
        /// </summary>
        /// <param name="Time">Une durée (ou une heure) en minute</param>
        /// <returns>Un string de la forme Heure H Minute</returns>
        public string FormatHour(int Time)
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
}
