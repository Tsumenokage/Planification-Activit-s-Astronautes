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
    public partial class TaskForm : Form
    {
        //Variable
        private List<Astronaut> Astronauts;
        private List<Category> Categories;
        public string TypeForm;

        //Constructeur
        public TaskForm(List<Astronaut> astro, List<Category> categ, string form)
        {
            InitializeComponent();

            //Initialisation des textbox
            textBoxStartHour.ForeColor = SystemColors.GrayText;
            textBoxDuration.ForeColor = SystemColors.GrayText;
            textBoxStartHour.Text = "Enter the hour like this : HH/MM/SS"; //A remplacer par le format de l'heure dont on aura besoin
            textBoxDuration.Text = "In minutes";
            this.textBoxStartHour.Leave += new System.EventHandler(this.textBoxStartHour_Leave);
            this.textBoxStartHour.Enter += new System.EventHandler(this.textBoxStartHour_Enter);
            this.textBoxDuration.Leave += new System.EventHandler(this.textBoxDuration_Leave);
            this.textBoxDuration.Enter += new System.EventHandler(this.textBoxDuration_Enter);
            
            //Initialisation astronautes
            foreach (Astronaut A in Astronauts)
            { MessageBox.Show(A.Name); }

            //Initialisation bouton fin
            TypeForm = form;
            if (TypeForm == "adding")
            {
                buttonAddActivity.Text = "Add Task";
            }
            else if (TypeForm == "editing")
            {
                    buttonAddActivity.Text = "Edit Task";
            }
            else
            {
                }

         }
            
         private void textBoxStartHour_Leave(object sender, EventArgs e)
            {
                if (textBoxStartHour.Text.Length == 0)
                {
                    textBoxStartHour.Text = "Enter the hour like this : HH/MM/SS"; //A remplacer par le format de l'heure dont on aura besoin
                    textBoxStartHour.ForeColor = SystemColors.GrayText;
                }
            }

          private void textBoxStartHour_Enter(object sender, EventArgs e)
            {
                if (textBoxStartHour.Text == "Enter the hour like this : HH/MM/SS")
                {
                    textBoxStartHour.Text = "";
                    textBoxStartHour.ForeColor = SystemColors.WindowText;
                }
            }

          private void textBoxDuration_Leave(object sender, EventArgs e)
            {
                if (textBoxDuration.Text.Length == 0)
                {
                    textBoxDuration.Text = "In minutes";
                    textBoxDuration.ForeColor = SystemColors.GrayText;
                }
            }

          private void textBoxDuration_Enter(object sender, EventArgs e)
            {
                if (textBoxDuration.Text == "In minutes")
                {
                    textBoxDuration.Text = "";
                    textBoxDuration.ForeColor = SystemColors.WindowText;
                }
            }

          private void buttonAddActivity_Click(object sender, EventArgs e)
          {
              if (TypeForm == "adding") //Le if est ici pour l'instant si le traitement diffère entre chaque possibilité
              {
                  DialogResult result = MessageBox.Show("Do you want to add this task ?", "Confirmation", MessageBoxButtons.YesNo);
                  if (result == DialogResult.Yes)
                  {
                      this.Close(); //Ajouter la tâche sur l'emploi
                  }
              }
              else if (TypeForm == "editing")
              {
                  DialogResult result = MessageBox.Show("Do you want to edit this task ?", "Confirmation", MessageBoxButtons.YesNo);
                  if (result == DialogResult.Yes)
                  {
                      this.Close(); //Ajouter la tâche sur l'emploi
                  }
              }
          }

          private void buttonCancel_Click(object sender, EventArgs e)
          {
              DialogResult result2 = MessageBox.Show("Do you want to cancel your work ?", "Confirmation", MessageBoxButtons.YesNo);
              if (result2 == DialogResult.Yes)
              {
                  this.Close();
              }
          }
        }
    }
