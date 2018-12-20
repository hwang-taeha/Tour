using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelPlan
{
    public partial class Main : UserControl
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnTraffic_Click_1(object sender, EventArgs e)
        {
            Sidepanel.Visible = true;
            Sidepanel.Height = btnTraffic.Height;
            traffic1.BringToFront();
        }

        private void btnFestival_Click(object sender, EventArgs e)
        {
            Sidepanel.Visible = true;
            Sidepanel.Height = btnTraffic.Height;
            festival1.BringToFront();
        }
    }
}
