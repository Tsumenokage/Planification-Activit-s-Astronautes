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
    public partial class DayReport : Form
    {

        private Day Today;
        public string Report { get; set; }

        public DayReport(Day daySelected)
        {
            InitializeComponent();
            Today = daySelected;
            Report = Today.ToString() + ".";
            if (Today.Report == null)
            {
                for (int i = 0; i < Today.Tasks.Count(); i++)
                {
                    Report = Report + "\n\n   Activity " + (i + 1) + ": " + Today.Tasks[i].Name + ". It will start at " + MartianTime(Today.Tasks[i].StartHour) + "\nIt concerns " + Today.Tasks[i].Astronauts.Count() + " astronauts.";
                }
            }
            else
            {
                Report = Today.Report;
            }
            richTextBoxReport.Text = Report;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Gestion erreur et données TODO
            Today.Report = Report; 
            MessageBox.Show("Successfully saved.", "Saved", MessageBoxButtons.OK);
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to cancel your work ?", "Confirmation", MessageBoxButtons.OK);
        }

        private string MartianTime(double SecondsBegin)
        {
            string Date;
            double Hour = 0;
            double Minute = 0;
            double Second = 0;
            //Nombre de seconde dans une seule journée : 88 800

            Hour = Math.Truncate(SecondsBegin / 60);
            Minute = Math.Truncate((SecondsBegin % 60) / 60);
            Second = Math.Truncate((SecondsBegin % 60) % 60);

            Date = Hour + ":" + Minute + ":" + Second;
            return Date;
        }
    }
}
