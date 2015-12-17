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
    /// Ce Windows Form est utilisé pour l'ajout, l'édition (et éventuellement la suppression) d'une tâche. Il est affiché différement selon que cela soit un
    /// ajout ou une édition.
    /// On peut y gérer les astronautes concernés, le nom de l'activité, la date de début et la durée de la tâche, la localisation de la tâche grâce à une carte
    /// de la région.
    /// </summary>
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

        /// <summary>
        /// Constructeur de la classe TaskForm
        /// </summary>
        /// <param name="astro">Les Astronautes de la missions</param>
        /// <param name="categ">Les catégories d'activités</param>
        /// <param name="form">Le type d'action (ajout ou édition)</param>
        /// <param name="day">Le jour ou est rajouté la tâche</param>
        /// <param name="MapString">Le chemin vers l'image de la carte</param>
        /// <param name="xOrigin">La position en X de la base</param>
        /// <param name="yOrigin">La position en Y de la base</param>
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

        /// <summary>
        /// Action qui se déclenche après le clique sur le bouton Add
        /// Va ajouter la tâche à l'emploi du temps de la journée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddActivity_Click(object sender, EventArgs e)
          {
              if (TypeForm == "adding") //Le if est ici pour l'instant si le traitement diffère entre chaque possibilité
              {
                  DialogResult result = MessageBox.Show("Do you want to add this task ?", "Confirmation", MessageBoxButtons.YesNo);
                  bool AllAstroFree = true;

                if (ActivityView.SelectedNode == null || ActivityView.SelectedNode.Parent == null)
                    MessageBox.Show("Select a correct activity");
                else if ((int)DurationHour.Value == 0 && (int)DurationMinute.Value==0)
                {
                    MessageBox.Show("Select a correct duration for this Task");
                }
                else if(AstronautView.CheckedIndices.Count == 0)
                {
                    MessageBox.Show("Select at least one astronaut");
                }
                else if (richTextBoxDescription.Text.Length > 400)
                {
                    MessageBox.Show("Error : The description is too long");
                }

                else
                {
                    if (result == DialogResult.Yes && ActivityView.SelectedNode != null)
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

        /// <summary>
        /// Action qui se déroule après le clic sur le bouton Cancel
        /// Va annuler l'ajout et gfermer la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Do you want to cancel your work ?", "Confirmation", MessageBoxButtons.YesNo);
            if (result2 == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Se produit lorsque l'on change la valeur de l'heure pour empécher de dépasser 40 minutes lorsque l'heure
        /// du début de mission est a 24 heures
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Va vérifier qu'un Astonaute est disponible
        /// </summary>
        /// <param name="A">astronaute dont on veut connaître la disponibilité</param>
        /// <returns></returns>
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

        /// <summary>
        /// Action qui se produit lorsque l'on clic sur la Map
        /// Va ouvrir une fenêtre Map afin de choisir le lieu de la tâche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                MessageBox.Show(miniX + "   " + miniY);
                graMap.DrawImage(imageCross, miniX-(imageCross.Width/2), miniY-(imageCross.Height));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActivityView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.graMap.DrawImage(Image.FromFile(MapString), 0, 0, MapPic.Width, MapPic.Height);
            int miniX = (MapPic.Width * this.xMap) / MapImage.Width;
            int miniY = (MapPic.Height * this.yMap) / MapImage.Height;
            this.graMap.DrawImage(imageCross, miniX - (imageCross.Width / 2), miniY - (imageCross.Height));
        }

        /// <summary>
        /// Evenement qui sera appelé à chaque fois qu'une modification sera faite graphiquement sur l'élément TaskForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskForm_Paint(object sender, PaintEventArgs e)
        {
            this.graMap.DrawImage(Image.FromFile(MapString), 0, 0, MapPic.Width, MapPic.Height);
            int miniX = (MapPic.Width * this.xMap) / MapImage.Width;
            int miniY = (MapPic.Height * this.yMap) / MapImage.Height;
            this.graMap.DrawImage(imageCross, miniX - (imageCross.Width / 2), miniY - (imageCross.Height));
        }
    }
}