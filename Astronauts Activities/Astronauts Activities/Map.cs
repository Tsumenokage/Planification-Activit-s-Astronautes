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
    public partial class Map : Form
    {
        private string MapString;
        public int sendX;
        public int sendY;

        public Map(string MapString)
        {
            InitializeComponent();
            this.MapString = MapString;
            Image img = Image.FromFile(MapString);
            MapPic.Size = img.Size;
            MapPic.Image = img;
        }

        private void MapPic_MouseUp(object sender, MouseEventArgs e)
        {
            sendX = e.X;
            sendY = e.Y;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
