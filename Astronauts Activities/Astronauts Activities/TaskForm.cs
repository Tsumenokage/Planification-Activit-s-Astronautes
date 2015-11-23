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
        public int MinuteStartSend;
        public int MinuteDurationSend;
        public List<Astronaut> SelectedAstronaut;
        public Activity ActivitySend;
        public String Description;

        //Constructeur
        public TaskForm(List<Astronaut> astro, List<Category> categ, string form)
        {
            InitializeComponent();
            Astronauts = astro;
            Categories = categ;
            
            //Initialisation astronautes
            foreach (Astronaut A in Astronauts)
            {
                AstronautView.Items.Add(A.Name);
            }

            foreach (Category c in Categories)
            {
                TreeNode n = ActivityView.Nodes.Add(c.Name);

                foreach (Activity Act in c.Activities)
                {
                    TreeNode NiveauSup = n.Nodes.Add(Act.Name);
                    if(Act.Activities != null)
                    {
                        foreach (Activity Act2 in Act.Activities)
                        {
                            NiveauSup.Nodes.Add(Act2.Name);
                        }
                    }
                }
            
            }

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

         }

          private void buttonAddActivity_Click(object sender, EventArgs e)
          {
              if (TypeForm == "adding") //Le if est ici pour l'instant si le traitement diffère entre chaque possibilité
              {
                  DialogResult result = MessageBox.Show("Do you want to add this task ?", "Confirmation", MessageBoxButtons.YesNo);
                  
                  if (result == DialogResult.Yes && ActivityView.SelectedNode.Nodes.Count == 0)
                  {
                      MinuteStartSend = (int)StartHour.Value * 60 + (int)MinutesStart.Value;
                      MinuteDurationSend = (int)DurationHour.Value * 60 + (int)DurationMinute.Value;

                      String NodeCategory = ActivityView.SelectedNode.Parent.Text;
                      MessageBox.Show(NodeCategory);
                      Category category = Categories.Find(x => x.Name == NodeCategory);
                      
                      ActivitySend = category.Activities.Find(x => x.Name == ActivityView.SelectedNode.Text);
                      SelectedAstronaut = new List<Astronaut>();               
                      

                      foreach (int indice in AstronautView.CheckedIndices)
                      {
                          Astronaut A = Astronauts.Find(x => x.Name == AstronautView.Items[indice].Text);
                          SelectedAstronaut.Add(A);
                          MessageBox.Show(A.Name);
                      }

                      Description = richTextBoxDescription.Text;
                
                      DialogResult = DialogResult.OK;
                      this.Close();
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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (StartHour.Value == 24)
            {
                MinutesStart.Maximum = 40;
                if (MinutesStart.Value > 40)
                    MinutesStart.Value = 40;
            }
            else
                MinutesStart.Maximum = 59;
        }
    }
}
