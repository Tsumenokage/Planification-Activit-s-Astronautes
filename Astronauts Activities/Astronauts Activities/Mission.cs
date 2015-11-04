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

        public Mission()
        {
            InitializeComponent();
            Astronauts = new List<Astronaut>();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newPlanningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            PlanningMission = new Planning();

            NewPlanning newPlan = new NewPlanning();

            newPlan.ShowDialog();

            if (newPlan.DialogResult == DialogResult.OK)
            {
                foreach (Day day in PlanningMission.Calendar)
                {
                    listCalendar.Nodes.Add(day.ToString());
                }
            }




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

                    XmlNode ActivitiesXml = noeud.SelectSingleNode("Activities");
                    XmlNode LivingActiviies = ActivitiesXml.SelectSingleNode("Living");
                    
                    
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
    }
}
