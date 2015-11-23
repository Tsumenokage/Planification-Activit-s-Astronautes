using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Astronauts_Activities
{
    public partial class Mission : Form
    {
        private List<Astronaut> Astronauts;
        private String Map;
        private List<Category> Categories;
        private Planning PlanningMission;
        private DateTime StartMission;
        Timer bg = new Timer();

        public Mission()
        {
            InitializeComponent();
            Astronauts = new List<Astronaut>();
            Categories = new List<Category>();

            bg.Tick += (s, e) => { EarthHour.Text = DateTime.Now.ToString(); };
            bg.Tick += (s, e) => { MajTime(); };
            bg.Interval = 500;
            bg.Start();
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MajTime()
        {
            if(StartMission != null)
            {
                double TicksPass;
                TimeSpan ts = DateTime.Now - StartMission;
                TicksPass = Math.Floor(ts.TotalSeconds);
                MissionTime.Text = MartianTime(TicksPass).ToString();
            }
        }

        private string MartianTime(double SecondsBegin)
        {
            string Date;
            double Day = 0;
            double Hour = 0;
            double Minute = 0;
            double Second = 0;
            //Nombre de secondes dans une seule journée : 88 800

            Day = Math.Truncate(SecondsBegin / 88800);
            SecondsBegin = SecondsBegin % 88800;

            Hour = Math.Truncate(SecondsBegin / 3600);
            Minute = Math.Truncate((SecondsBegin % 3600) / 60);
            Second = Math.Truncate((SecondsBegin % 3600) % 60);

            Date = "Day : " + Day + "  " + Hour + ":" + Minute + ":" + Second;
            return Date;


            
        }

        private void newPlanningToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            PlanningMission = new Planning();

            NewPlanning newPlan = new NewPlanning();

            newPlan.ShowDialog();

            LoadXml();

            foreach (Astronaut a in Astronauts)
            {
                AstronautList.Items.Add(a.Name);
                AstronautList.SelectedIndex = 0;
            }

            if (newPlan.DialogResult == DialogResult.OK)
            {
                foreach (Day day in PlanningMission.Calendar)
                {
                    listCalendar.Nodes.Add(day.ToString());

                    List<Activity> Activities = Categories.Find(x => x.Name == "Living").Activities;

                    Activity sleep = Activities.Find(x => x.Name == "Sleeping");
                    Activity eat = Activities.Find(x => x.Name == "Eating");
                    Activity privateActivity = Activities.Find(x => x.Name == "Private");

                    Task sleep1 = new Task(sleep,Astronauts,420,0);
                    Task eat1 = new Task(eat, Astronauts, 60, 420);
                    Task private1 = new Task(privateActivity, Astronauts, 240, 480);
                    Task eat2 = new Task(eat, Astronauts, 120 , 720 );
                    Task private2 = new Task(privateActivity, Astronauts, 300, 840);
                    Task eat3 = new Task(eat, Astronauts, 120, 1140);
                    Task private3 = new Task(privateActivity, Astronauts, 120, 1260);
                    Task sleep2 = new Task(sleep, Astronauts, 100, 1380);

                    day.AddTask(sleep1);
                    day.AddTask(eat1);
                    day.AddTask(private1);
                    day.AddTask(eat2);
                    day.AddTask(private2);
                    day.AddTask(eat3);
                    day.AddTask(private3);
                    day.AddTask(sleep2);
                }
            }

            listCalendar.SelectedNode = listCalendar.Nodes[0];
            //ViewDayPlanning();

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlDocument file = new XmlDocument();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "Text Files (.xml)|*.xml|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    file.Load(openFileDialog1.OpenFile());
                    XmlNode noeud = file.DocumentElement;
                    XmlNodeList nomMission = noeud.SelectNodes("Name");
                    this.Text = nomMission[0].InnerText;

                    XmlNode AstronautXml = noeud.SelectSingleNode("Astronauts");
                    XmlNodeList AstronautsXml = AstronautXml.SelectNodes("Astronaut");

                    foreach (XmlNode nodeAstro in AstronautsXml)
                    {
                        Astronaut A = new Astronaut(nodeAstro.InnerText);
                        Astronauts.Add(A);
                    }

                    XmlNodeList ActivitiesXml = noeud.ChildNodes;
                    foreach (XmlNode category in ActivitiesXml)
                    {
                        Category c = new Category(category.Name);
                        XmlNodeList Activities = category.ChildNodes;

                        foreach (XmlNode activity in Activities)
                        {
                            if (activity.Name == "Activity")
                            {
                                Activity a = new Activity(activity.InnerText);
                                c.addActivity(a);
                            }
                            else
                            {
                                Category c2 = new Category(activity.Name);
                                c.addActivity(c2);
                                XmlNodeList SecondaryActivity = activity.ChildNodes;

                                foreach (XmlNode SubActivity in SecondaryActivity)
                                {
                                    Activity a2 = new Activity(SubActivity.InnerText);
                                    c2.addActivity(a2);
                                }
                            }
                        }
                        
                    }                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void LoadXml()
        {
            XmlDocument file = new XmlDocument();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog1.Filter = "Text Files (.xml)|*.xml|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    file.Load(openFileDialog1.OpenFile());
                    XmlNode noeud = file.DocumentElement;
                    XmlNodeList nomMission = noeud.SelectNodes("Name");
                    this.Text = nomMission[0].InnerText;

                    XmlNode AstronautXml = noeud.SelectSingleNode("Astronauts");
                    XmlNodeList AstronautsXml = AstronautXml.SelectNodes("Astronaut");

                    foreach (XmlNode nodeAstro in AstronautsXml)
                    {
                        Astronaut A = new Astronaut(nodeAstro.InnerText);
                        Astronauts.Add(A);
                    }

                    XmlNode DateMissionXml = noeud.SelectSingleNode("BeginMission");
                    string Day = DateMissionXml.SelectSingleNode("Day").InnerText;
                    string Month = DateMissionXml.SelectSingleNode("Month").InnerText;
                    string Year = DateMissionXml.SelectSingleNode("Year").InnerText;

                    this.StartMission = new DateTime(int.Parse(Year),int.Parse(Month), int.Parse(Day), 0, 0, 0);

                    XmlNode ActivityXml = noeud.SelectSingleNode("Activities");
                    XmlNodeList ActivitiesXml = ActivityXml.ChildNodes;
                    
                    foreach (XmlNode category in ActivitiesXml)
                    {
                        Category c = new Category(category.LocalName);
                        Categories.Add(c);
                        XmlNodeList Activities = category.ChildNodes;

                        foreach (XmlNode activity in Activities)
                        {
                            if (activity.LocalName == "Activity")
                            {
                                Activity a = new Activity(activity.InnerText);
                                c.addActivity(a);
                            }
                            else
                            {
                                Category c2 = new Category(activity.Name);
                                c.addActivity(c2);
                                XmlNodeList SecondaryActivity = activity.ChildNodes;

                                foreach (XmlNode SubActivity in SecondaryActivity)
                                {
                                    Activity a2 = new Activity(SubActivity.InnerText);
                                    MessageBox.Show(SubActivity.InnerText);
                                    c2.addActivity(a2);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void infoSurLaMissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Astronaut A in Astronauts)
                MessageBox.Show(A.Name);
        }

        private void Mission_Load(object sender, EventArgs e)
        {

        }

        private void listCalendar_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        //Suppression de la tâche
        private void buttonRemoveTask_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this task ?","Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //Ajouter nouvelle boite si l'activité est présente dans le planning de plusieurs astronautes
            }
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            TaskForm addingTask = new TaskForm(Astronauts, Categories,"adding");
            addingTask.Show();
        }

        private void buttonEditTask_Click(object sender, EventArgs e)
        {
            TaskForm modifyingTask = new TaskForm(Astronauts, Categories,"editing");
            modifyingTask.Show();
        }


        private void ViewDayPlanning(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show("Jour modifié");
            DayActivities.Items.Clear();
            int numDay = listCalendar.SelectedNode.Index;
            Day day = PlanningMission.Calendar[numDay];
            Astronaut astronautSelected = Astronauts.Find(x => x.Name == AstronautList.SelectedItem.ToString());

            List<Task> AstronautDailyPlanning = new List<Task>();

            foreach (Task t in day.Tasks)
            {
                if (t.Astronauts.Contains(astronautSelected))
                {
                    AstronautDailyPlanning.Add(t);
                }
            }

            foreach (Task t in AstronautDailyPlanning)
            {
                //MessageBox.Show(t.Name);
                ListViewItem itm = new ListViewItem(t.getInfo());
                DayActivities.Items.Add(itm);

            }
        }

        private void ViewDayPlanning(object sender, EventArgs e)
        {
            if (listCalendar.SelectedNode != null)//Sécurité, on ne met pas à jour si aucun jour n'est sélectionné
            {
                MessageBox.Show("Astronaute modifié");
                DayActivities.Items.Clear();
                int numDay = listCalendar.SelectedNode.Index;
                Day day = PlanningMission.Calendar[numDay];
                Astronaut astronautSelected = Astronauts.Find(x => x.Name == AstronautList.SelectedItem.ToString());

                List<Task> AstronautDailyPlanning = new List<Task>();

                foreach (Task t in day.Tasks)
                {
                    if (t.Astronauts.Contains(astronautSelected))
                    {
                        AstronautDailyPlanning.Add(t);
                    }
                }

                foreach (Task t in AstronautDailyPlanning)
                {
                    //MessageBox.Show(t.Name);
                    ListViewItem itm = new ListViewItem(t.getInfo());
                    DayActivities.Items.Add(itm);

                }
            }
        }

        private void buttonAddTask_Click_1(object sender, EventArgs e)
        {
            TaskForm AddTask = new TaskForm(Astronauts, Categories,"adding");

            if(AddTask.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("TODO : Ajouter l'ajout de la tâche");
            }
        }

        private void buttonShowReport_Click(object sender, EventArgs e)
        {
            if (listCalendar.SelectedNode != null)
            {
                DayReport dayReporting = new DayReport(PlanningMission.Calendar[listCalendar.SelectedNode.Index]);
                dayReporting.Show();
            }
            //Retour des données TODO
        }
    }
}
