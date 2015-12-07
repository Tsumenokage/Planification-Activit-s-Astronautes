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
    // Ce Windows Form est utilisé pour l'ajout, l'édition (et éventuellement la suppression) d'une tâche. Il est affiché différement selon que cela soit un
    // ajout ou une édition.
    // On peut y gérer les astronautes concernés, le nom de l'activité, la date de début et la durée de la tâche, la localisation de la tâche grâce à une carte
    // de la région.

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
        public int xMap;
        public int yMap;
        private Day ActualDay;
        private string MapString;
        private Image MapImage;
        private Image imageCross;
        private Graphics graMap;

        //Constructeur
        public TaskForm(List<Astronaut> astro, List<Category> categ, string form, Day day, string MapString, int xOrigin, int yOrigin)
        {
            InitializeComponent();
            Astronauts = astro;
            Categories = categ;
            this.ActualDay = day;
            this.MapString = MapString;
            this.MapImage = Image.FromFile(this.MapString);            
            Image img = Image.FromFile(MapString);
            imageCross = Astronauts_Activities.Properties.Resources.crossImage;     
            this.graMap = MapPic.CreateGraphics();
            this.xMap = xOrigin;
            this.yMap = yOrigin;
            MapPic.Invalidate();

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
                  bool AllAstroFree = true;
                  if (result == DialogResult.Yes && ActivityView.SelectedNode.Nodes.Count == 0)
                  {
                      MinuteStartSend = (int)StartHour.Value * 60 + (int)MinutesStart.Value;
                      MinuteDurationSend = (int)DurationHour.Value * 60 + (int)DurationMinute.Value;

                      if (MinuteStartSend + MinuteDurationSend <= 1480)
                      {
                          String NodeCategory = ActivityView.SelectedNode.Parent.Text;
                          Category category = Categories.Find(x => x.Name == NodeCategory);

                          ActivitySend = category.Activities.Find(x => x.Name == ActivityView.SelectedNode.Text);
                          SelectedAstronaut = new List<Astronaut>();


                          foreach (int indice in AstronautView.CheckedIndices)
                          {
                              Astronaut A = Astronauts.Find(x => x.Name == AstronautView.Items[indice].Text);

                              if (AstronautIsFree(A))
                                  SelectedAstronaut.Add(A);
                              else
                              {
                                  MessageBox.Show(A.Name + " is not available for this task on this period");
                                  AllAstroFree = false;
                              }
                          }

                          Description = richTextBoxDescription.Text;

                          if (AllAstroFree)
                          {
                              DialogResult = DialogResult.OK;
                              this.Close();
                          }
                      }
                      else
                      {
                          MessageBox.Show("Error : End of the task exceed 24h40, you can't add a task on 2 days.");
                      }
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

        private bool AstronautIsFree(Astronaut A)
        {
            List<Task> AstroTask;
            AstroTask = ActualDay.Tasks.FindAll(x => x.Astronauts.Contains(A));
            int EndNewTask = MinuteStartSend + MinuteDurationSend;
            int EndTask;
            bool AstronautFree = true;

            foreach (Task task in AstroTask)
            {
                EndTask = task.DurationMinute + task.StartHour;
                if((MinuteStartSend > task.StartHour && MinuteStartSend < EndTask) || (EndNewTask > task.StartHour && EndNewTask < EndTask))
                {
                    AstronautFree = false;
                }
            }

            return AstronautFree;
        }

        private void MapPic_DoubleClick(object sender, EventArgs e)
        {
            Map mapForm = new Map(this.MapString);

            if (mapForm.ShowDialog() == DialogResult.OK)
            {
                this.xMap = mapForm.sendX;
                this.yMap = mapForm.sendY;

                //On affiche sur la miniMap
                graMap.DrawImage(Image.FromFile(MapString), 0, 0, MapPic.Width, MapPic.Height);

                int miniX = (MapPic.Width * this.xMap) / MapImage.Width;
                int miniY = (MapPic.Height * this.yMap) / MapImage.Height;
                graMap.DrawImage(imageCross, miniX-(imageCross.Width/2), miniY-(imageCross.Height));
            }
        }

        private void ActivityView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.graMap.DrawImage(Image.FromFile(MapString), 0, 0, MapPic.Width, MapPic.Height);
            int miniX = (MapPic.Width * this.xMap) / MapImage.Width;
            int miniY = (MapPic.Height * this.yMap) / MapImage.Height;
            this.graMap.DrawImage(imageCross, miniX - (imageCross.Width / 2), miniY - (imageCross.Height));
        }

        private void TaskForm_Paint(object sender, PaintEventArgs e)
        {
            this.graMap.DrawImage(Image.FromFile(MapString), 0, 0, MapPic.Width, MapPic.Height);
            int miniX = (MapPic.Width * this.xMap) / MapImage.Width;
            int miniY = (MapPic.Height * this.yMap) / MapImage.Height;
            this.graMap.DrawImage(imageCross, miniX - (imageCross.Width / 2), miniY - (imageCross.Height));
        }
    }
}