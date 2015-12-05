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
    public partial class MissionMap : Form
    {
        List<Day> SelectedDay;
        Graphics MapGraph;
        Image imageCross;
        String MapString;
        Mission mission;

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
        }

        private void MapPic_Paint()
        {
            List<Task> DrawTask = new List<Task>();

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
                        DrawTask.Add(t);
                    }
                }
            }

            MessageBox.Show(DrawTask.Count.ToString());

            this.MapGraph.DrawImage(Image.FromFile(MapString), 0, 0, MapPic.Width, MapPic.Height);

            foreach (Task t in DrawTask)
            {
                int miniX = (MapPic.Width * t.Xposition) / MapPic.Width;
                int miniY = (MapPic.Height * t.Yposition) / MapPic.Height;
                MessageBox.Show(miniX.ToString() + "  " + miniY.ToString());
                this.MapGraph.DrawImage(imageCross, miniX - (imageCross.Width / 2), miniY - (imageCross.Height));
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.MapPic_Paint();
        }
    }
}
