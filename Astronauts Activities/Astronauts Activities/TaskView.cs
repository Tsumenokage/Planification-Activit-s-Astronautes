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
    public partial class TaskView : Form
    {
        private ListViewItem listViewItem;

        public TaskView()
        {
            //Activity =
            InitializeComponent();
        }

        public TaskView(ListViewItem listViewItem)
        {
            this.listViewItem = listViewItem;
        }
    }
}
