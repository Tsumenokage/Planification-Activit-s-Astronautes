using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Astronauts_Activities
{

    /// <summary>
    /// Classe représentant les jours. Les objets de cette classe sont instanciées au lancement du fichier XML de mission. NumberDay correspond
    /// au numéro du jeu (de 1 à 500 ici), Report au compte-rendu quotidien, Tasks à la liste de tâche de la journée.
    /// </summary>
    public class Day
    {
        public int NumberDay { get; private set; }
        public string Report { get; set; }
        public List<Task> Tasks { get; private set; }
        private const int MINUTES = 1480; //Nombre de minutes dans une journée martienne

        /// <summary>
        /// Constructeur de la classe Jour  
        /// </summary>
        /// <param name="NumberDay">int : numéro du jour crée</param>
        public Day(int NumberDay)
        {
            Tasks = new List<Task>();
            this.NumberDay = NumberDay;
        }

        /// <summary>
        /// Constructeur de la classe jour utilisé lors du chargement d'une mission 
        /// </summary>
        /// <param name="NumberDay">int : numéro du jour crée</param>
        /// <param name="Report">String : Le rapport du jour</param>
        public Day(int NumberDay, string Report)
        {
            Tasks = new List<Task>();
            this.NumberDay = NumberDay;
            this.Report = Report;
        }

        /// <summary>
        /// Implémentation de la méthode ToString()
        /// </summary>
        /// <returns>Une châine caractères</returns>
        public override string ToString()
        {
            string s = "Day : " + this.NumberDay;
            return s;
        }

        /// <summary>
        /// Ajoute une tâche à la journée sélectionnée
        /// </summary>
        /// <param name="t">Task : La tâche que l'on souhaite ajouter</param>
        public void AddTask(Task t)
        {
            Tasks.Add(t);
            OrderTask();
        }

        /// <summary>
        /// Va ordonner les tâches de la journée par ordre chronologique en fonction de l'heure de début
        /// </summary>
        private void OrderTask()
        {
            this.Tasks = this.Tasks.OrderBy(x => x.StartHour).ToList();
        }

        /// <summary>
        /// Va retourner les infos d'une tâche sous forme de tableau,
        /// cela est utilisé pour l'affichage dans différents écrans.
        /// </summary>
        /// <param name="task">Task : Tâche dont on souhaite obtenir les informations</param>
        /// <returns>un tableau contenant le jour de la tâche, et les informations sur cette dernière</returns>
        public string[] TaskInfo(Task task)
        {
            string[] arr = new string[5];

            arr[0] = "";
            arr[1] = this.ToString();
            arr[2] = task.FormatHour(task.StartHour);
            int EndTask = task.StartHour + task.DurationMinute;
            arr[3] = task.FormatHour(EndTask);
            arr[4] = task.Name;
            return arr;
        }

    }
}
