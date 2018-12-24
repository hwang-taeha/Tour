using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using TravelPlan.Business_Logic_Layer;

namespace TravelPlan
{
    public partial class DBschedule : UserControl
    {
        List<Planner> planners = new List<Planner>();
        ImageList imageList = new ImageList();
        
        public DBschedule()
        {
            InitializeComponent();
            this.Location = new Point(0, 1);
            PlannerDAO plannerDAO = PlannerDAO.getInstance();


            planners = plannerDAO.SelectPlanner();

            foreach (var item in planners)
            {
                WebRequest req = WebRequest.Create(item.Image);
                WebResponse resp = req.GetResponse();

                imageList.ImageSize = new Size(64, 64);
                Stream stream = resp.GetResponseStream();
                Image img = Image.FromStream(stream);
                imageList.Images.Add(item.Day+item.Name,img);
            }
            listView1.LargeImageList = imageList;
            listView1.SmallImageList = imageList;
            listView1.View = View.SmallIcon;
            List<string[]> strArray = new List<string[]>();
            foreach (var item in planners)
            {
                strArray.Add(new string[] {item.Day+"일" ,item.Name });
            }
            for (int j = 0; j < strArray.Count; j++)
            {
                ListViewItem listViewItem = new ListViewItem(strArray[j]);
                listView1.Items.Add(listViewItem);
                listView1.Items[j].ImageIndex = j;
            }


        }

        private void listView1_Leave(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
