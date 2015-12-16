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
    /// Cette fenêtre va permettre de renseigner les chemins des deux fichiers nécessaires au chargement d'une mission
    /// </summary>
    public partial class LoadMission : Form
    {

        public string fileXml;
        public string missionXml;

        //Constructeur par défaut de la classe LoadMission
        public LoadMission()
        {
            fileXml = "";
            missionXml = "";
            InitializeComponent();
        }

        /// <summary>
        /// Action qui fait suite au clique sur le bouton Load et qui ve fermer cette fenêtre si les deux chemins vers les fichiers sont bien entrés.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadButton_Click(object sender, EventArgs e)
        {
            if(fileXml != "" && missionXml != "")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        /// <summary>
        /// Action qui fait suite au clique de la souris sur le champs MissionText
        /// Va ouvrir une fenêtre modale pour choisir le bon fichier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MissionText_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "Text Files (.xml)|*.xml|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.MissionText.Text = openFileDialog1.FileName;
                this.missionXml = openFileDialog1.FileName;
            }
        }

        /// <summary>
        /// Action qui fait suite au clique de la souris sur le champs SaveText
        /// Va ouvrir une fenêtre modale pour choisir le bon fichier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveText_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "Text Files (.xml)|*.xml|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.SaveText.Text = openFileDialog1.FileName;
                this.fileXml = openFileDialog1.FileName;
            }
        }
    }
}
