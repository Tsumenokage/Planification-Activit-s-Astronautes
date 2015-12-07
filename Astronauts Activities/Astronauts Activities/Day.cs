using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Astronauts_Activities
{
    // Classe représentant les jours. Les objets de cette classe sont instanciées au lancement du fichier XML de mission. NumberDay correspond
    // au numéro du jeu (de 1 à 500 ici), Report au compte-rendu quotidien, Tasks à la liste de tâche de la journée.
    public class Day
    {
        public int NumberDay { get; private set; }
        public string Report { get; set; }
        public List<Task> Tasks { get; private set; }
        private const int MINUTES = 1480; //Nombre de minutes dans une journée martienne

        public Day(int NumberDay)
        {
            Tasks = new List<Task>();
            this.NumberDay = NumberDay;
        }

        public override string ToString()
        {
            string s = "Day : " + this.NumberDay;
            return s;
        }

        public void AddTask(Task t)
        {
            Tasks.Add(t);
            OrderTask();
        }

        private void OrderTask()
        {
            this.Tasks = this.Tasks.OrderBy(x => x.StartHour).ToList();
        }

    }
}
