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
    /// Cette classe va permettre de sélectionner les astronautes à supprimer d'une tâche
    /// </summary>
    public partial class SelectAstroDelete : Form
    {
        private List<Astronaut> AstronautTask;
        public List<Astronaut> SelectedAstronaut;

        /// <summary>
        /// Constructeur de la classe Astronaut
        /// </summary>
        /// <param name="AstronautsTask"> Liste des Astronautes</param>
        public SelectAstroDelete(List<Astronaut> AstronautsTask)
        {
            InitializeComponent();
            this.AstronautTask = AstronautsTask;
            SelectedAstronaut = new List<Astronaut>();
            foreach (Astronaut A in AstronautsTask)
            {
                AstronautView.Items.Add(A.Name);
            }

            
        }

        /// <summary>
        /// Action effectuer lorsque l'on clique sur OK
        /// Va fermer la fenêtre en renvoyant le résultat OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkButton_Click(object sender, EventArgs e)
        {
            foreach (int indice in AstronautView.CheckedIndices)
            {
                Astronaut A = AstronautTask.Find(x => x.Name == AstronautView.Items[indice].Text);
                SelectedAstronaut.Add(A);
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Action effectuer lorsque l'on clique sur Cancel
        /// Va fermer la fenêtre en renvoyant le résultat Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void AstronautView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
