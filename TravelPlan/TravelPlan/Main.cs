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
        DBschedule dBschedule;
        private void btnTraffic_Click_1(object sender, EventArgs e)
        {
            Sidepanel.Visible = true;
            Sidepanel.Height = btnTraffic.Height;
            traffic1.BringToFront();
            if (dBschedule != null)
            {
                dBschedule.Dispose();
            }
            
        }

        private void btnFestival_Click(object sender, EventArgs e)
        {
            Sidepanel.Visible = true;
            //Sidepanel.Height =btnFestival.Height;btnFestival.Location.Y
            Sidepanel.Location = new Point(Sidepanel.Location.X, btnFestival.Location.Y);
            festival1.BringToFront();
            if (dBschedule != null)
            {
                dBschedule.Dispose();
            }
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            dBschedule = new DBschedule();

            Sidepanel.Visible = true;
            Sidepanel.Height = btnPlan.Height;
            
            this.Controls.Add(dBschedule);
            dBschedule.BringToFront();
            
        }

        private void btnHotel_Click(object sender, EventArgs e)
        {
            SearchHotel searchHotel = new SearchHotel();
            this.Controls.Add(searchHotel);
            searchHotel.Show();
            searchHotel.BringToFront();
        }
    }
}
