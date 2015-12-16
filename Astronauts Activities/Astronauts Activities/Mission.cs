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

    /// <summary>
    /// Fenêtre principal du programme
    /// Cette classe regroupe les niveaux 1 et 2 définis dans le cahier des charges du projet. A gauche, la liste des jours correspond au niveau 1 : les jours sont affichés
    /// différement selon leur position par rapport au jour actuel.
    /// Sélectionner un jour modifie le contenu du panel de droite, qui correspond au niveau 2. Ce panel affiche les activités du jour sélectionné, les boutons de gestion
    /// comme l'ajout ou l'édition d'une tâche. On peut aussi afficher le compte-rendu, ou naviguer vers les jours suivants / précédents.
    /// Double-cliquer sur une tâche affiche le niveau 3.
    /// Le contenu de la mission est initialisé ici, par l'ouverture du fichier XML de mission.
    /// </summary>
    public partial class Mission : Form
    {
        private List<Astronaut> Astronauts;
        public String Map { get; private set; }
        private List<Category> Categories;
        public Planning PlanningMission { get; private set; }
        private DateTime StartMission;
        public int xOrigin { get; private set; }
        public int yOrigin { get; private set; }
        private int CurrentDay;
        Timer bg = new Timer();

        /// <summary>
        /// Constructeur de la classe Mission
        /// </summary>
        public Mission()
        {
            InitializeComponent();
            Astronauts = new List<Astronaut>();
            Categories = new List<Category>();

            bg.Tick += (s, e) => { EarthHour.Text = DateTime.Now.ToString(); };
            bg.Tick += (s, e) => { CurrentDay = MajTime(); };
            bg.Interval = 500;
            bg.Start();
            
            
        }

        /// <summary>
        /// Fonction qui va mettre à jour la date martienne
        /// </summary>
        /// <returns>Le nombre de jour depuis le début de la mission</returns>
        private int MajTime()
        {
            int nbDay = 0;
            if(StartMission != null)
            {
                double TicksPass;
                TimeSpan ts = DateTime.Now - StartMission;
                TicksPass = Math.Floor(ts.TotalSeconds);
                MissionTime.Text = MartianTime(TicksPass, out nbDay).ToString();
            }
            return nbDay;
        }

        /// <summary>
        /// Foncton qui va calculer la date et l'heure martienne en fonction de la date de début de la mission
        /// </summary>
        /// <param name="SecondsBegin">La nombre de seconde depuis la date terrestre de lancement de la mission</param>
        /// <param name="nbDay">Le nombre de jour écoulé depuis le début de la mission</param>
        /// <returns></returns>
        private string MartianTime(double SecondsBegin, out int nbDay)
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
            nbDay = (int)Day;
            return Date;
          
        }

        /// <summary>
        /// Action qui se lance après avoir cliqué sur New dans la barre de menu en haut
        /// Va lancer le processus nécessaire à une nouvelle mission
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newPlanningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            PlanningMission = new Planning();


            if(NewMission())
            {
                foreach (Astronaut a in Astronauts)
                {
                    AstronautList.Items.Add(a.Name);
                    AstronautList.SelectedIndex = 0;
                }

                CurrentDay = MajTime();
                foreach (Day day in PlanningMission.Calendar)
                {
                    TreeNode MyNode;
                    if (day.NumberDay < CurrentDay)
                    {
                        MyNode = listCalendar.Nodes.Add(day.ToString());

                        MyNode.BackColor = Color.LightGray;
                    }
                    else if (day.NumberDay == CurrentDay + 1)
                    {
                        MyNode = listCalendar.Nodes.Add(day.ToString());

                        MyNode.BackColor = Color.Green;
                    }
                    else
                    {
                        MyNode = listCalendar.Nodes.Add(day.ToString());

                        MyNode.BackColor = Color.LightBlue;
                    }

                    List<Activity> Activities = Categories.Find(x => x.Name == "Living").Activities;

                    Activity sleep = Activities.Find(x => x.Name == "Sleeping");
                    Activity eat = Activities.Find(x => x.Name == "Eating");
                    Activity privateActivity = Activities.Find(x => x.Name == "Private");


                    List<Astronaut> astroSleep1 = Astronauts.ToList();
                    Task sleep1 = new Task(sleep, astroSleep1, 420, 0, this.xOrigin, this.yOrigin);

                    List<Astronaut> astroEat = Astronauts.ToList();
                    Task eat1 = new Task(eat, astroEat, 60, 420, this.xOrigin, this.yOrigin);

                    List<Astronaut> astroPV1 = Astronauts.ToList();
                    Task private1 = new Task(privateActivity, astroPV1, 240, 480, this.xOrigin, this.yOrigin);

                    List<Astronaut> astroEat2 = Astronauts.ToList();
                    Task eat2 = new Task(eat, astroEat2, 120, 720, this.xOrigin, this.yOrigin);

                    List<Astronaut> astroPV2 = Astronauts.ToList();
                    Task private2 = new Task(privateActivity, astroPV2, 300, 840, this.xOrigin, this.yOrigin);

                    List<Astronaut> astroEat3 = Astronauts.ToList();
                    Task eat3 = new Task(eat, astroEat3, 120, 1140, this.xOrigin, this.yOrigin);

                    List<Astronaut> astroPV3 = Astronauts.ToList();
                    Task private3 = new Task(privateActivity, astroPV3, 120, 1260, this.xOrigin, this.yOrigin);

                    List<Astronaut> astroSleep2 = Astronauts.ToList();
                    Task sleep2 = new Task(sleep, astroSleep2, 100, 1380, this.xOrigin, this.yOrigin);


                    day.AddTask(sleep1);
                    day.AddTask(eat1);
                    day.AddTask(private1);
                    day.AddTask(eat2);
                    day.AddTask(private2);
                    day.AddTask(eat3);
                    day.AddTask(private3);
                    day.AddTask(sleep2);
                }

                listCalendar.SelectedNode = listCalendar.Nodes[0];
            }
            
                    
            
        }

        /// <summary>
        /// Action qui se lance après avoir cliqué sur load dans la barre de menu en haut
        /// Va lancer le processus nécessaire au chargement d'une ancienne mission
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadMission load = new LoadMission();

            if(load.ShowDialog() == DialogResult.OK)
            {
                this.AstronautList.Items.Clear();
                this.Astronauts.Clear();
                this.Categories.Clear();

                if (LoadMissionXml(load.missionXml))
                    LoadMission(load.fileXml);

                saveToolStripMenuItem.Enabled = true;
            }
        }

        /// <summary>
        /// Va lire le fichier Xml lancé par l'utilisateur pour une nouvelle mission
        /// </summary>
        /// <returns>Un booléen indiquant si le chargement c'est bien passé</returns>
        private bool NewMission()
        {
            this.Astronauts.Clear();
            this.Categories.Clear();
            this.AstronautList.Items.Clear();
            saveToolStripMenuItem.Enabled = true;
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

                    this.StartMission = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                    file.Load(openFileDialog1.OpenFile());
                    XmlNode noeud = file.DocumentElement;
                    XmlNodeList nomMission = noeud.SelectNodes("Name");
                    this.Text = nomMission[0].InnerText;


                    XmlNodeList MapMars = noeud.SelectNodes("Map");
                    this.Map = MapMars[0].InnerText;

                    try
                    {
                        Image.FromFile(this.Map);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Unable to find Map picture : " + this.Map);
                        return false;                        
                    }


                    XmlNodeList XMap = noeud.SelectNodes("X");
                    this.xOrigin = int.Parse(XMap[0].InnerText);

                    XmlNodeList YMap = noeud.SelectNodes("Y");
                    this.yOrigin = int.Parse(YMap[0].InnerText);


                    XmlNode AstronautXml = noeud.SelectSingleNode("Astronauts");
                    XmlNodeList AstronautsXml = AstronautXml.SelectNodes("Astronaut");

                    foreach (XmlNode nodeAstro in AstronautsXml)
                    {
                        Astronaut A = new Astronaut(nodeAstro.InnerText);
                        Astronauts.Add(A);
                    }


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
                                    c2.addActivity(a2);
                                }
                            }
                        }
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    return false;
                }
            }
            else
                return false;
        }

        /// <summary>
        /// Va lire un fichier Xml contenant un planning de mission enregistré
        /// </summary>
        /// <param name="Path">Le chemin vers le fichier Xml</param>
        private void LoadMission(string Path)
        {
            XmlDocument file = new XmlDocument();
            this.PlanningMission = new Planning();
            PlanningMission.Calendar.Clear();

            try
            {
                file.Load(Path);

                XmlNode root = file.DocumentElement;

                XmlNode Start = root.SelectSingleNode("StartMission");
                XmlNode Year = Start.SelectSingleNode("Year");
                XmlNode Month = Start.SelectSingleNode("Month");
                XmlNode Day = Start.SelectSingleNode("Day");


                this.StartMission = new DateTime(int.Parse(Year.InnerText), int.Parse(Month.InnerText), int.Parse(Day.InnerText));

                XmlNodeList Days = root.SelectNodes("Day");

                foreach (XmlNode d in Days)
                {
                    XmlNode Number = d.SelectSingleNode("Number");
                    XmlNode ReportDay = d.SelectSingleNode("Report");
                    String Report = ReportDay.InnerText;


                    Day newDay = new Day(int.Parse(Number.InnerText),Report);

                    XmlNodeList Tasks = d.SelectNodes("Task");

                    foreach (XmlNode n in Tasks)
                    {
                        XmlNode LoadActivity = n.SelectSingleNode("TaskName");
                        String ActivityName = LoadActivity.InnerText;
                        Activity newActivity = null;

                        XmlNode StartHourLoad = n.SelectSingleNode("StartHour");
                        int StartHour = int.Parse(StartHourLoad.InnerText);

                        XmlNode DurationLoad = n.SelectSingleNode("Duration");
                        int Duration = int.Parse(DurationLoad.InnerText);

                        XmlNode PositionXLoad = n.SelectSingleNode("PositionX");
                        int PositionX = int.Parse(PositionXLoad.InnerText);

                        XmlNode PositionYLoad = n.SelectSingleNode("PositionY");
                        int PositionY = int.Parse(PositionYLoad.InnerText);

                        foreach (Activity c in this.Categories)
                        {
                            if(newActivity == null)                            
                                newActivity = c.Activities.Find(x => x.Name == ActivityName);
                            
                        }

                        XmlNode AstronautsXml = n.SelectSingleNode("Astronauts");
                        XmlNodeList AstronautsListXml = AstronautsXml.SelectNodes("Astronaut");


                        List<Astronaut> newAstronaut = new List<Astronaut>();
                        foreach (XmlNode astro in AstronautsListXml)
                        {
                            Astronaut a = this.Astronauts.Find(x => x.Name == astro.InnerText);
                            if(a != null)
                            {
                                newAstronaut.Add(a);
                            }
                        }

                        XmlNode DescriptionTask = n.SelectSingleNode("Description");
                        String Description = DescriptionTask.InnerText;

                        if(newActivity == null)
                        {
                            MessageBox.Show("No Activity Found");
                        }

                        Task newTask = new Task(newActivity, newAstronaut, Duration, StartHour, Description, PositionX, PositionY);
                        //MessageBox.Show(StartHour.ToString() + " " + Duration.ToString());
                        newDay.AddTask(newTask);
                    }
                    PlanningMission.Calendar.Add(newDay);
                }

                foreach (Astronaut a in Astronauts)
                {
                    AstronautList.Items.Add(a.Name);
                    AstronautList.SelectedIndex = 0;
                }
                CurrentDay = MajTime();
                MessageBox.Show(CurrentDay.ToString());
                foreach (Day day in PlanningMission.Calendar)
                {
                    TreeNode MyNode;
                    if (day.NumberDay < CurrentDay)
                    {
                        MyNode = listCalendar.Nodes.Add(day.ToString());

                        MyNode.BackColor = Color.LightGray;
                    }
                    else if (day.NumberDay == CurrentDay)
                    {
                        MyNode = listCalendar.Nodes.Add(day.ToString());

                        MyNode.BackColor = Color.Green;
                    }
                    else
                    {
                        MyNode = listCalendar.Nodes.Add(day.ToString());

                        MyNode.BackColor = Color.LightBlue;
                    }
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            listCalendar.SelectedNode = listCalendar.Nodes[CurrentDay-1];
        }

        /// <summary>
        /// Va lire un fichier Xml décrivant la mission (Activité, Map...)
        /// </summary>
        /// <param name="Path">Le chemin vers un fichier Xml</param>
        /// <returns>Un booléen indiquant si le chargement c'est bien passé</returns>
        private bool LoadMissionXml(string Path)
        {
            XmlDocument file = new XmlDocument();

                try
                {
                    file.Load(Path);
                    XmlNode noeud = file.DocumentElement;
                    XmlNodeList nomMission = noeud.SelectNodes("Name");
                    this.Text = nomMission[0].InnerText;


                    XmlNodeList MapMars = noeud.SelectNodes("Map");
                    this.Map = MapMars[0].InnerText;

                    try
                    {
                        Image.FromFile(this.Map);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Unable to find Map picture : " + this.Map);
                        return false;
                    }

                XmlNodeList XMap = noeud.SelectNodes("X");
                    this.xOrigin = int.Parse(XMap[0].InnerText);

                    XmlNodeList YMap = noeud.SelectNodes("Y");
                    this.yOrigin = int.Parse(YMap[0].InnerText);


                    XmlNode AstronautXml = noeud.SelectSingleNode("Astronauts");
                    XmlNodeList AstronautsXml = AstronautXml.SelectNodes("Astronaut");

                    foreach (XmlNode nodeAstro in AstronautsXml)
                    {
                        Astronaut A = new Astronaut(nodeAstro.InnerText);
                        Astronauts.Add(A);
                    }


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
                                    c2.addActivity(a2);
                                }
                            }
                        }
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    return false;
                }
            
            
        }

        /// <summary>
        /// Se déroule après avoir cliqué sur le bouton Delete
        /// Va lancer le processus de suppresion de tâche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemoveTask_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this task ?","Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //Comme on ne peut sélectionner qu'un seul index, sait qu'il s'agit du premier
                int indexTask = DayActivities.SelectedItems[0].Index;
                MessageBox.Show(indexTask.ToString());
                Day day = PlanningMission.Calendar[listCalendar.SelectedNode.Index];
                Task t = day.Tasks[indexTask];

                foreach (Task ta in day.Tasks)
                {
                    String[] info = ta.getInfo();

                    if (info[1] == DayActivities.SelectedItems[0].SubItems[1].Text &&
                        info[2] == DayActivities.SelectedItems[0].SubItems[2].Text &&
                        info[3] == DayActivities.SelectedItems[0].SubItems[3].Text)
                    {
                        t = ta;
                    }
                }

                SelectAstroDelete delete = new SelectAstroDelete(t.Astronauts);

                if (delete.ShowDialog() == DialogResult.OK)
                {
                    this.Delete(t, delete.SelectedAstronaut);
                }

                if (t.Astronauts.Count == 0)
                {
                    day.Tasks.Remove(t);
                }
                this.majDayPlanning();
            }
        }

        /// <summary>
        /// Va retirer les Astronaute d'une tâche
        /// </summary>
        /// <param name="t">Tâche dont on souhaite enlever des astronautes</param>
        /// <param name="Astronauts">Astronautes à retirer</param>
        private void Delete (Task t, List<Astronaut> Astronauts)
        {
            foreach (Astronaut A in Astronauts)
	        {
                t.Astronauts.Remove(A);
	        }
        }

        /// <summary>
        /// Va mettre à jour l'affichage de l'emploi du temps de la journée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewDayPlanning(object sender, TreeViewEventArgs e)
        {
            
            DayActivities.Items.Clear();
            int numDay = listCalendar.SelectedNode.Index;

            if (numDay < CurrentDay - 1)
            {
                buttonAddTask.Enabled = false;
                SearchButton.Enabled = false;
                buttonRemoveTask.Enabled = false;
            }
            else
            {
                buttonAddTask.Enabled = true;
                SearchButton.Enabled = true;
                buttonRemoveTask.Enabled = true;
            }

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

                ListViewItem itm = new ListViewItem(t.getInfo());


                ListViewItem item = DayActivities.Items.Add(itm);

                if (t.Xposition != xOrigin || t.Yposition != yOrigin)
                {
                    item.ImageIndex = 0;
                }

            }
        }

        /// <summary>
        /// Va mettre à jour l'affichage de l'emploi du temps de la journée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewDayPlanning(object sender, EventArgs e)
        {
            if (listCalendar.SelectedNode != null)//Sécurité, on ne met pas à jour si aucun jour n'est sélectionné
            {
                int numDay = listCalendar.SelectedNode.Index;
                DayActivities.Items.Clear();
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
                    ListViewItem itm = new ListViewItem(t.getInfo());
                    DayActivities.Items.Add(itm);

                }
            }
        }

        /// <summary>
        /// Va mettre à jour l'affichage de l'emploi du temps de la journée
        /// </summary>
        private void majDayPlanning()
        {
            DayActivities.Items.Clear();
            int numDay = listCalendar.SelectedNode.Index;

            if (numDay < CurrentDay - 1)
            {
                buttonAddTask.Enabled = false;
                SearchButton.Enabled = false;
                buttonRemoveTask.Enabled = false;
            }
            else
            {
                buttonAddTask.Enabled = true;
                SearchButton.Enabled = true;
                buttonRemoveTask.Enabled = true;
            }

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

                ListViewItem itm = new ListViewItem(t.getInfo());


                ListViewItem item = DayActivities.Items.Add(itm);

                if (t.Xposition != xOrigin || t.Yposition != yOrigin)
                {
                    item.ImageIndex = 0;
                }

            }
        }


        /// <summary>
        /// Se déclenche après le clic sur le bouton Addtask
        /// Va lancer le processus pour ajouter une tâche à une journée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddTask_Click_1(object sender, EventArgs e)
        {
            int jour = listCalendar.SelectedNode.Index;
            TaskForm AddTask = new TaskForm(Astronauts, Categories, "adding", PlanningMission.Calendar[jour],Map, this.xOrigin, this.yOrigin);
            


            if(AddTask.ShowDialog() == DialogResult.OK)
            {
                Activity newAct = AddTask.ActivitySend;
                List<Astronaut> AstronautNew = AddTask.SelectedAstronaut;
                int Duration = AddTask.MinuteDurationSend;
                int startHour = AddTask.MinuteStartSend;
                string DescriptionTask = AddTask.Description;
                int XPosition = AddTask.xMap;
                int YPosition = AddTask.yMap;


                Task newTask = new Task(newAct, AstronautNew, Duration, startHour,DescriptionTask,XPosition,YPosition);
                int numDay = listCalendar.SelectedNode.Index;
                PlanningMission.Calendar[numDay].AddTask(newTask);
                this.majDayPlanning();

            }
        }

        /// <summary>
        /// Va afficher le rapport de la journée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowReport_Click(object sender, EventArgs e)
        {
            if (listCalendar.SelectedNode != null)
            {
                int numDay = listCalendar.SelectedNode.Index;
                DayReport DayReporting = new DayReport(PlanningMission.Calendar[numDay]);
                if (DayReporting.ShowDialog() == DialogResult.OK)
                {
                    PlanningMission.Calendar[numDay].Report = DayReporting.Report;
                }
            }
        }

        /// <summary>
        /// Permet de se déplacer au jour précédent au clic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPreviousDay_Click(object sender, EventArgs e)
        {
            int numDay = listCalendar.SelectedNode.Index;
            listCalendar.SelectedNode = listCalendar.Nodes[numDay - 1];
        }

        /// <summary>
        /// Permet de se déplacer au jour précédent au clic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNextDay_Click(object sender, EventArgs e)
        {
            int numDay = listCalendar.SelectedNode.Index;
            listCalendar.SelectedNode = listCalendar.Nodes[numDay + 1];
        }

        /// <summary>
        /// Va afficher les détails d'une tâche pour afficher le troisième niveau (détails de la tâche)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DayActivities_DoubleClick(object sender, EventArgs e)
        {
            if (DayActivities.SelectedItems != null)
            {
                int numDay = listCalendar.SelectedNode.Index;
                Day day = PlanningMission.Calendar[numDay];
                int numActivity = DayActivities.SelectedIndices[0];
                Task t = day.Tasks[numActivity];


                foreach (Task ta in day.Tasks)
                {
                    String[] info = ta.getInfo();

                    if(info[1] == DayActivities.SelectedItems[0].SubItems[1].Text &&
                        info[2] == DayActivities.SelectedItems[0].SubItems[2].Text &&
                        info[3] == DayActivities.SelectedItems[0].SubItems[3].Text)
                    {
                        t = ta;
                    }
                }
                          
                
                TaskView TaskViewing = new TaskView(t);
                TaskViewing.ShowDialog();
            }
        }

        /// <summary>
        /// Va afficher la fenêtre permettant de voir la Map de mission globale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuMissionMap_Click(object sender, EventArgs e)
        {
            MissionMap mM = new MissionMap(this);

            if(mM.ShowDialog() == DialogResult.OK)
            {

            }
        }

        /// <summary>
        /// Va sauvegarder les différentes options de la missions dans un fichier Xml
        /// </summary>
        private void SaveMission()
        {


            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "xml files (*.xml)|*.txt";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    XmlNode rootNode = xmlDoc.CreateElement("Mission");
                    xmlDoc.AppendChild(rootNode);

                    XmlNode Start = xmlDoc.CreateElement("StartMission");
                    XmlNode StartYear = xmlDoc.CreateElement("Year");
                    StartYear.InnerText = this.StartMission.Year.ToString();

                    XmlNode StartMonth = xmlDoc.CreateElement("Month");
                    StartMonth.InnerText = this.StartMission.Month.ToString();

                    XmlNode StartDay = xmlDoc.CreateElement("Day");
                    StartDay.InnerText = this.StartMission.Day.ToString();

                    Start.AppendChild(StartYear);
                    Start.AppendChild(StartMonth);
                    Start.AppendChild(StartDay);

                    rootNode.AppendChild(Start);

                    foreach (Day d in PlanningMission.Calendar)
                    {
                        XmlNode day = xmlDoc.CreateElement("Day");
                        rootNode.AppendChild(day);

                        XmlNode NumberDay = xmlDoc.CreateElement("Number");
                        NumberDay.InnerText = d.NumberDay.ToString();
                        day.AppendChild(NumberDay);

                        foreach (Task t in d.Tasks)
                        {
                            XmlNode task = xmlDoc.CreateElement("Task");

                            XmlNode TaskName = xmlDoc.CreateElement("TaskName");
                            TaskName.InnerText = t.Name;

                            XmlNode StartHour = xmlDoc.CreateElement("StartHour");
                            StartHour.InnerText = t.StartHour.ToString();

                            XmlNode Duration = xmlDoc.CreateElement("Duration");
                            Duration.InnerText = t.DurationMinute.ToString();

                            XmlNode PositionX = xmlDoc.CreateElement("PositionX");
                            PositionX.InnerText = t.Xposition.ToString();

                            XmlNode PositionY = xmlDoc.CreateElement("PositionY");
                            PositionY.InnerText = t.Yposition.ToString();

                            task.AppendChild(TaskName);
                            task.AppendChild(StartHour);
                            task.AppendChild(Duration);
                            task.AppendChild(PositionX);
                            task.AppendChild(PositionY);

                            XmlNode Astronauts = xmlDoc.CreateElement("Astronauts");

                            foreach (Astronaut a in t.Astronauts)
                            {
                                XmlNode Astro = xmlDoc.CreateElement("Astronaut");
                                Astro.InnerText = a.Name;
                                Astronauts.AppendChild(Astro);
                            }
                            task.AppendChild(Astronauts);

                            XmlNode Description = xmlDoc.CreateElement("Description");
                            Description.InnerText = t.Description;

                            task.AppendChild(Description);

                            day.AppendChild(task);
                        }

                        XmlNode ReportDay = xmlDoc.CreateElement("Report");
                        ReportDay.InnerText = d.Report;

                        day.AppendChild(ReportDay);
                    }


                    xmlDoc.Save(saveFileDialog1.OpenFile());
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);

                }
            }
        }

        /// <summary>
        /// Va lancer le processus de sauvegarde de la mission en cours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveMission();
        }

        /// <summary>
        /// Va ouvrir la fenêtre permettant de faire une recherche de tâche sur la Mission
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            Recherche search = new Recherche(this.PlanningMission);

            search.ShowDialog();
        }
    }
}
