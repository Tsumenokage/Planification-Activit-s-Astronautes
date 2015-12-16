using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Astronauts_Activities
{
    /// <summary>
    /// Cette classe va ouvrir la fenêtre de recherche des tâches
    /// </summary>
    public partial class Recherche : Form
    {
        private Planning calendar;
        private List<Task> TaskFind;

        /// <summary>
        /// Constructeur de la classe Recherche
        /// </summary>
        /// <param name="calendar">Planning : Représente le planning de la mission (liste de jours)</param>
        public Recherche(Planning calendar)
        {
            InitializeComponent();
            this.calendar = calendar;
            TaskFind = new List<Task>();
        }

        /// <summary>
        /// Evenement qui se déclenche lors de l'appuie sur le bouton Search
        /// Va rechercher les tâches en fonction des informations entrées par l'utilisateur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Search_Click(object sender, EventArgs e)
        {
            string search = SearchText.Text;
            DayActivities.Items.Clear();
            TaskFind.Clear();
            foreach (Day day in calendar.Calendar)
            {
                foreach (Task task in day.Tasks)
                {
                    if(Filter.SelectedIndex == 0)
                    {
                        if(task.Name == search)
                        {                           
                            ListViewItem itm = new ListViewItem(day.TaskInfo(task));
                            ListViewItem item = DayActivities.Items.Add(itm);
                            TaskFind.Add(task);
                        }
                    }
                    if (Filter.SelectedIndex == 1)
                    {
                        if(task.Description.Contains(search))
                        {
                            ListViewItem itm = new ListViewItem(day.TaskInfo(task));
                            ListViewItem item = DayActivities.Items.Add(itm);
                            TaskFind.Add(task);

                        }
                    }
                }

            }
        }

        /// <summary>
        /// Cette fonction se déclenche lorsque l'on double clique sur une tâche trouvée lors de la recherche.
        /// Cela va afficher les détails de la tâche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DayActivities_DoubleClick(object sender, EventArgs e)
        {
            TaskView TV = new TaskView(TaskFind[DayActivities.SelectedIndices[0]]);
            TV.ShowDialog();
        }
    }
}
