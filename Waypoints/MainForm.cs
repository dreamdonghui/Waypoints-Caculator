using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waypoints
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_load(object sender, EventArgs e)
        {
            this.Text = "航路规划" + "V" + "0.0.0.0";


        }

        private readonly List<AreaPointList> areaPointLists = new List<AreaPointList>();
        private void addNew_button_Click(object sender, EventArgs e)
        {
            areaPointLists.Add(new AreaPointList() { Lat = 121, Lon = 1234 , index = 1});
        }

        private void uTMToGPSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gPSToUTMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gpsToUTMForm = new GPSTOUTM();
            gpsToUTMForm.Show();
        }
    }
}
