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
    public partial class LoadMission : Form
    {

        public string fileXml;
        public string missionXml;

        public LoadMission()
        {
            fileXml = "";
            missionXml = "";
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if(fileXml != "" && missionXml != "")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

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
