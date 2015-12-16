using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Astronauts_Activities
{

    /// <summary>
    /// Classe Activity, servant à sauvegarder les activity depuis le fichier XML de mission. Une activité peut contenir d'autres activités,
    /// pour montrer les différents niveaux de hiérarchie entre les activités
    /// </summary>
    public class Activity
    {
        public List<Activity> Activities { get; protected set; }
        public string Name {get; private set;}
        public int Xposition { get; private set; }
        public int Yposition { get; private set; }
        private string Description;

        /// <summary>
        /// Constructeur pour la classe Activity
        /// </summary>
        /// <param name="Name">Le nom de l'activité sous forme de String</param>
        public Activity(string Name)
        {
            this.Name = Name;
        }
    }
}