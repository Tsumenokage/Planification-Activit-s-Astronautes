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
    /// Classe qui va afficher les détails lié à une tâche
    /// </summary>
    public partial class TaskView : Form
    {
        Task task;

        /// <summary>
        /// Constructeur de taskView va renseigner l'ensemble des champs en fonction de la tâche entré en paramètre
        /// </summary>
        /// <param name="task">Task : Tâche dont on veut connaitre les informations</param>
        public TaskView(Task task)
        {
            
            InitializeComponent();
            this.task = task;

            this.ActivityName.Text =  task.Name;
            this.richTextBoxDescription.Text = task.Description;

            int StartHour = task.StartHour / 60;
            int StartMinutes = task.StartHour % 60;

            if (StartHour == 0)
                this.StartHour.Text = "00";
            else
                this.StartHour.Text = StartHour.ToString();

            if (StartMinutes == 0)
                this.StartMinutes.Text = "00";
            else
                this.StartMinutes.Text = StartMinutes.ToString();

            int EndHour = (task.StartHour + task.DurationMinute) / 60;
            int EndMinutes = (task.StartHour + task.DurationMinute) % 60;

            if (EndHour == 0)
                this.EndHour.Text = "00";
            else
                this.EndHour.Text = EndHour.ToString();

            if (EndMinutes == 0)
                this.EndMinutes.Text = "00";
            else
                this.EndMinutes.Text = EndMinutes.ToString();

            foreach (Astronaut A in task.Astronauts)
            {
                AstronautView.Items.Add(A.Name);
            }

            
        }
    }
}
