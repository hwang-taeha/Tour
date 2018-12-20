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

namespace TravelPlan.Business_Logic_Layer
{
    public partial class CompletePlan : UserControl
    {
        public CompletePlan()
        {
            InitializeComponent();
        }
        int count = 1;
        int x = 100;
        int y = 35;

        private void CompletePlan_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.AutoScroll = true;

        }


        internal void Start()
        {
            // TempListUpdate(int.Parse(cbDay.Text));


            //for (int i = 0; i < imageList.Length; i++)
            //{
            //    imageList[i].Images.Clear();
            //}
            DaysPlan[] days = new DaysPlan[Form1.DayPlan.Count];

            //Day별로
            for (int i = 0; i < Form1.DayPlan.Count; i++)
            {
                //Form1.ImageList[i] = new ImageList();
                days[i] = new DaysPlan();
                flowLayoutPanel1.Controls.Add(days[i]);

                days[i].Location = new Point(0, 0);
                //days[i].Location = new Point(100, 35+ 175 * i);
                days[i].lblDay.Text = (i + 1) + "Day";
                // 하루기준 아이템들보여주기
                //foreach (var item in Form1.DayPlan[i])
                //{
                //    WebRequest req = WebRequest.Create(item.Image);
                //    WebResponse resp = req.GetResponse();


                //    Stream stream = resp.GetResponseStream();

                //    Image img = Image.FromStream(stream);

                //    Form1.ImageList[i].Images.Add(i + item.Name, img);
                //    Form1.ImageList[i].ImageSize = new Size(64, 64);


                //}
                days[i].lvPlans.LargeImageList = Form1.ImageList[i];
                days[i].lvPlans.Columns.Add("그림", 200, HorizontalAlignment.Center);
                days[i].lvPlans.Columns.Add("설명", 200, HorizontalAlignment.Center);
                List<string[]> strArray = new List<string[]>();
                foreach (var item in Form1.DayPlan[i])
                {
                    strArray.Add(new string[] { item.Name });
                }
                for (int j = 0; j < strArray.Count; j++)
                {
                    ListViewItem listViewItem = new ListViewItem(strArray[j]);
                    days[i].lvPlans.Items.Add(listViewItem);
                    //days[i].lvPlans.Items[j].ImageKey = j + Form1.DayPlan[i][j].Name;
                    days[i].lvPlans.Items[j].ImageIndex = j;

                }
            }
        }


    }
}
//static List<List<Planner>> dayPlan = new List<List<Planner>>();// db에 저장시킬 리스트
//static List<Planner> planners = new List<Planner>();//1일차 저장리스트
//static List<Planner> tempPlan = new List<Planner>();// 찜해놓은 정보들