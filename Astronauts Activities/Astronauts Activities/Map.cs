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
    /// Classe qui va afficher la Map avec sa résolution correcte
    /// </summary>
    public partial class Map : Form
    {
        private string MapString;
        public int sendX;
        public int sendY;

        /// <summary>
        /// Constructeur de la classe Map
        /// </summary>
        /// <param name="MapString">Chaîne de caractère indiquant le chemin de la Map</param>
        public Map(string MapString)
        {
            InitializeComponent();
            this.MapString = MapString;
            Image img = Image.FromFile(MapString);
            MapPic.Size = img.Size;
            MapPic.Image = img;
        }

        /// <summary>
        /// Action qui suit le clic de la souris, va sélectionner un point de la carte et fermer cette fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MapPic_MouseUp(object sender, MouseEventArgs e)
        {
            sendX = e.X;
            sendY = e.Y;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
