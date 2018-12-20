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
        ImageList imageList = new ImageList();
        private void CompletePlan_Load(object sender, EventArgs e)
        {


        }
        private void TempListUpdate(int day)
        {
            lvPlan.View = View.Tile;
            imageList.Images.Clear();
            foreach (var item in Form1.DayPlan[day-1])
            {

                WebRequest req = WebRequest.Create(item.Image);
                WebResponse resp = req.GetResponse();

                imageList.ImageSize = new Size(64, 64);
                Stream stream = resp.GetResponseStream();
                Image img = Image.FromStream(stream);
                imageList.Images.Add(img);
            }

            lvPlan.LargeImageList = imageList;
            lvPlan.Columns.Add("그림", 200, HorizontalAlignment.Center);
            lvPlan.Columns.Add("설명", 200, HorizontalAlignment.Center);
            List<string[]> strArray = new List<string[]>();
            foreach (var item in Form1.DayPlan[day-1])
            {
                strArray.Add(new string[] { item.Name });
            }
            for (int i = 0; i < strArray.Count; i++)
            {
                ListViewItem listViewItem = new ListViewItem(strArray[i]);
                lvPlan.Items.Add(listViewItem);
                lvPlan.Items[i].ImageIndex = i;
            }
        }

        internal void Start()
        {
            cbDay.Text = "1";
            TempListUpdate(int.Parse(cbDay.Text));




            //동적으로 생성시켜주기 실패
            //ImageList imageList = new ImageList();
            ////ImageList imageList = new ImageList[Form1.DayPlan.Count];
            ////for (int i = 0; i < imageList.Length; i++)
            ////{
            ////    imageList[i].Images.Clear();
            ////}
            //DaysPlan[] days = new DaysPlan[Form1.DayPlan.Count];

            ////Day별로
            //for (int i = 0; i < Form1.DayPlan.Count; i++)
            //{


            //    days[i].Location = new Point(0,0);
            //    //days[i].Location = new Point(100, 175 * count);
            //    days[i].lblDay.Text = i + "Day";
            //    count++;
            //    //하루기준 아이템들보여주기
            //    foreach (var item in Form1.DayPlan[i])
            //    {
            //        WebRequest req = WebRequest.Create(item.Image);
            //        WebResponse resp = req.GetResponse();


            //        Stream stream = resp.GetResponseStream();

            //        Image img = Image.FromStream(stream);

            //        imageList.Images.Add(i+item.Name, img);
            //        imageList.ImageSize = new Size(64, 64);


            //    }
            //    days[i].lvPlans.LargeImageList = imageList;
            //    days[i].lvPlans.Columns.Add("그림", 200, HorizontalAlignment.Center);
            //    days[i].lvPlans.Columns.Add("설명", 200, HorizontalAlignment.Center);
            //    List<string[]> strArray = new List<string[]>();
            //    foreach (var item in Form1.DayPlan[i])
            //    {
            //        strArray.Add(new string[] { item.Name });
            //    }
            //    for (int j = 0; j < strArray.Count; j++)
            //    {
            //        ListViewItem listViewItem = new ListViewItem(strArray[j]);
            //        days[i].lvPlans.Items.Add(listViewItem);
            //        days[i].lvPlans.Items[j].ImageKey = j + Form1.DayPlan[i][j].Name;

            //    }
            //}
        }
    }
}
//static List<List<Planner>> dayPlan = new List<List<Planner>>();// db에 저장시킬 리스트
//static List<Planner> planners = new List<Planner>();//1일차 저장리스트
//static List<Planner> tempPlan = new List<Planner>();// 찜해놓은 정보들