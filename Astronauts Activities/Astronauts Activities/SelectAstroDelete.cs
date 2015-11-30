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
    public partial class SelectAstroDelete : Form
    {
        private List<Astronaut> AstronautTask;
        public List<Astronaut> SelectedAstronaut;

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

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void DeleteAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in AstronautView.Items)
            {
                item.Checked = true;
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AstronautView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
