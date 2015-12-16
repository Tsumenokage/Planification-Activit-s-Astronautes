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
    /// Fenêtre qui va afficher la Map avec les différents pointeurs en fonction des données par l'utilisateur
    /// </summary>
    public partial class MissionMap : Form
    {
        List<Day> SelectedDay;
        Graphics MapGraph;
        Image imageCross;
        String MapString;
        Mission mission;
        List<Task> Marqueurs;
        Image MapImage;
        List<Rectangle> rectangles;

        /// <summary>
        /// Constructeur de la classe Map
        /// </summary>
        /// <param name="mission">Mission : Objet représenter la mission compléte en cours</param>
        public MissionMap(Mission mission)
        {
            InitializeComponent();

            this.mission = mission;
            MapString = mission.Map;
            SelectedDay = new List<Day>();
            for (int i = (int)StartDaySelector.Value; i <= EndDaySelector.Value; i++)
            {
                SelectedDay.Add(mission.PlanningMission.Calendar[i - 1]);
            }
            MapGraph = MapPic.CreateGraphics();
            imageCross = Astronauts_Activities.Properties.Resources.crossImage;

            Marqueurs = new List<Task>();
            MapImage = Image.FromFile(MapString);
            rectangles = new List<Rectangle>();

        }

        /// <summary>
        /// Evenement qui sera appelé à chaque fois qu'une modification sera faite graphiquement sur l'élément MapPic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MapPic_Paint(object sender, PaintEventArgs e)
        {
            rectangles.Clear();
            e.Graphics.DrawImage(Image.FromFile(MapString), 0, 0, MapPic.Width, MapPic.Height);
            
            int cpt = 0;
            foreach (Task t in Marqueurs)
            {
                int miniX = (MapPic.Width * t.Xposition) / MapImage.Width;
                int miniY = (MapPic.Height * t.Yposition) / MapImage.Height;
                e.Graphics.DrawImage(imageCross, miniX - (imageCross.Width / 2), miniY - (imageCross.Height));
                Rectangle r = new Rectangle(miniX-(imageCross.Width/2), miniY-imageCross.Height, imageCross.Width, imageCross.Height);
                rectangles.Add(r);
            }
        }

        /// <summary>
        /// Evènement qui intervient après le clic qur le bouton Afficher, va appeler la méthode MapPic_Paint()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.MapPic_Paint();
        }


        /// <summary>
        /// Cette méthode va trouver les différentes tâche qui s'éxécutent en dehors de la Map et va les indiquer sur la carte.
        /// </summary>
        private void MapPic_Paint()
        {
            
            Marqueurs.Clear();
            SelectedDay.Clear();
            for (int i = (int)StartDaySelector.Value; i <= EndDaySelector.Value; i++)
            {
                SelectedDay.Add(mission.PlanningMission.Calendar[i - 1]);
            }

            foreach (Day d in SelectedDay)
            {
                foreach (Task t in d.Tasks)
                {
                    if(t.Xposition != mission.xOrigin && t.Yposition != mission.yOrigin )
                    {
                        Marqueurs.Add(t);
                    }
                }
            }
            MapPic.Invalidate();
        }
        
        /// <summary>
        /// Cette fonction va afficher les détails relatif à une tâche lorsque l'on clique sur un pointeur de la carte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MapPic_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (Rectangle r in rectangles)
            {
                if (r.Contains(e.X, e.Y))
                {
                    TaskView TV = new TaskView(Marqueurs[rectangles.IndexOf(r)]);
                    TV.ShowDialog();
                }
            }
        }

    }
}
