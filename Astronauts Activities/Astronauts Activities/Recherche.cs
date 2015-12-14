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
    public partial class Recherche : Form
    {
        private Planning calendar;
        private List<Task> TaskFind;

        public Recherche(Planning calendar)
        {
            InitializeComponent();
            this.calendar = calendar;
            TaskFind = new List<Task>();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string search = SearchText.Text;
            DayActivities.Items.Clear();
            TaskFind.Clear();
            foreach (Day day in calendar.Calendar)
            {
                foreach (Task task in day.Tasks)
                {
                    if(Filter.SelectedIndex == 0)
                    {
                        if(task.Name == search)
                        {                           
                            ListViewItem itm = new ListViewItem(day.TaskInfo(task));
                            ListViewItem item = DayActivities.Items.Add(itm);
                            TaskFind.Add(task);
                        }
                    }
                    if (Filter.SelectedIndex == 1)
                    {
                        if(task.Description.Contains(search))
                        {
                            ListViewItem itm = new ListViewItem(day.TaskInfo(task));
                            ListViewItem item = DayActivities.Items.Add(itm);
                            TaskFind.Add(task);

                        }
                    }
                }

            }
        }

        private void DayActivities_DoubleClick(object sender, EventArgs e)
        {
            TaskView TV = new TaskView(TaskFind[DayActivities.SelectedIndices[0]]);
            TV.ShowDialog();
        }
    }
}
