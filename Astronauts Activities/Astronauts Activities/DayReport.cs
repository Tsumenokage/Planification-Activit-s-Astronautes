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
    /// Windows Form du compte-rendu quotidien, il est donc lié à un jour. Long de 1000 caractères au maximum.
    /// </summary>
    public partial class DayReport : Form
    {
        //Variables
        private Day Today;
        public string Report { get; set; }

        //Méthodes

            /// <summary>
            /// Constructeur de la classe DayReport
            /// </summary>
            /// <param name="daySelected">Le jour sélectionné pour écrire le rapport</param>
        public DayReport(Day daySelected)
        {
            InitializeComponent();
            Today = daySelected;
            Report = daySelected.Report;
            if (Report == null)
            {
                Report = Today.ToString() + ".";
                for (int i = 0; i < Today.Tasks.Count(); i++)
                {
                    Report = Report + "\n\n   Activity " + (i + 1) + ": " + Today.Tasks[i].Name + ". It will start at " + FormatHour(Today.Tasks[i].StartHour) + "\nIt concerns " + Today.Tasks[i].Astronauts.Count() + " astronauts.";
                }
            }
            else
            {
            }
            richTextBoxReport.Text = Report;
        }

        /// <summary>
        /// Evenement associé au bouton Save, va sauvegarder le rapport dans le jour concerné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (richTextBoxReport.Text.Length <= 1000)
            {
                MessageBox.Show("Successfully saved.", "Saved", MessageBoxButtons.OK);
                Report = richTextBoxReport.Text;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Reports can't exceed 1000 characters.", "Error", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Action associés au bouton cancel, va annuler l'enrehistrement du rapport
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to cancel your work ?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }


        public string FormatHour(int Time)
        {
            string HourFormat;
            int Minutes = Time % 60;
            Time = Time - Minutes;
            int Hours = Time / 60;


            HourFormat = Hours.ToString() + "H" + Minutes.ToString();
            if (Minutes == 0)
                HourFormat += "0";
            return HourFormat;

        }

        private void DayReport_Load(object sender, EventArgs e)
        {

        }
    }
}
