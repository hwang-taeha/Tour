using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace TravelPlan
{
    public partial class PlanCheck : UserControl
    {
        public PlanCheck()
        {
            InitializeComponent();
            
        }
        ImageList imageList = new ImageList();
        ImageList imageListForPlan = new ImageList();
        private void PlanCheck_Load(object sender, EventArgs e)
        {
            TempListUpdate();
        }
        /// <summary>
        /// 찜리스트뷰를 최신화시켜준다.
        /// </summary>
        private void TempListUpdate()
        {
            listView2.View = View.Tile;
            imageList.Images.Clear();
            foreach (var item in Form1.TempPlan)
            {

                WebRequest req = WebRequest.Create(item.Image);
                WebResponse resp = req.GetResponse();

                imageList.ImageSize = new Size(64, 64);
                Stream stream = resp.GetResponseStream();
                Image img = Image.FromStream(stream);
                imageList.Images.Add(img);
                
            }

            listView2.LargeImageList = imageList;
            listView2.Columns.Add("그림", 200, HorizontalAlignment.Center);
            listView2.Columns.Add("설명", 200, HorizontalAlignment.Center);
            List<string[]> strArray = new List<string[]>();
            foreach (var item in Form1.TempPlan)
            {
                strArray.Add(new string[] { item.Name });
            }
            for (int i = 0; i < strArray.Count; i++)
            {
                ListViewItem listViewItem = new ListViewItem(strArray[i]);
                listView2.Items.Add(listViewItem);
                listView2.Items[i].ImageIndex = i;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FrmPlusPlan frmPlusPlan = new FrmPlusPlan();
            frmPlusPlan.Show();
        }

        private void btnCurrentJJim_Click(object sender, EventArgs e)
        {
            listView2.Clear();
            TempListUpdate();

        }

        private void cbTotalDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlanList();
        }
        /// <summary>
        /// PlanList 추가
        /// </summary>
        private void PlanList()
        {
            listView1.Clear();
            imageListForPlan.Images.Clear();
            //cbTotalDays.SelectedIndex
            foreach (var item in Form1.DayPlan[cbTotalDays.SelectedIndex])
            {

                WebRequest req = WebRequest.Create(item.Image);
                WebResponse resp = req.GetResponse();

                imageListForPlan.ImageSize = new Size(64, 64);
                Stream stream = resp.GetResponseStream();
                Image img = Image.FromStream(stream);
                imageListForPlan.Images.Add(img);
            }

            listView1.LargeImageList = imageListForPlan;
            listView1.Columns.Add("그림", 200, HorizontalAlignment.Center);
            listView1.Columns.Add("설명", 200, HorizontalAlignment.Center);
            List<string[]> strArray = new List<string[]>();
            foreach (var item in Form1.DayPlan[cbTotalDays.SelectedIndex])
            {
                strArray.Add(new string[] { item.Name });
            }
            for (int i = 0; i < strArray.Count; i++)
            {
                ListViewItem listViewItem = new ListViewItem(strArray[i]);
                listView1.Items.Add(listViewItem);
                listView1.Items[i].ImageIndex = i;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                Form1.DayPlan[cbTotalDays.SelectedIndex].Add(Form1.TempPlan[listView2.SelectedItems[0].Index]);
                string imgStr = Form1.TempPlan[listView2.SelectedItems[0].Index].Image;

                WebRequest req = WebRequest.Create(imgStr);
                WebResponse resp = req.GetResponse();

                Stream stream = resp.GetResponseStream();

                Image img = Image.FromStream(stream);

                Form1.ImageList[cbTotalDays.SelectedIndex].Images.Add(img);
                Form1.ImageList[cbTotalDays.SelectedIndex].ImageSize = new Size(64, 64);



                PlanList();


            }
            catch (ArgumentOutOfRangeException)
            {

                MessageBox.Show("추가할 관광지를 선택하세요!");
            }
            
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.DayPlan[cbTotalDays.SelectedIndex].RemoveAt(listView1.SelectedItems[0].Index);
                //listView1.LargeImageList.Images[listView1.SelectedItems[0].Index].
                listView1.LargeImageList.Images.RemoveAt(listView1.SelectedItems[0].Index);
                PlanList();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("삭제할 관광지를 선택해주세요.");
            }
        }
    }
}
//static List<List<Planner>> dayPlan = new List<List<Planner>>();// db에 저장시킬 리스트
//static List<Planner> planners = new List<Planner>();//1일차 저장리스트
//static List<Planner> tempPlan = new List<Planner>();// 찜해놓은 정보들