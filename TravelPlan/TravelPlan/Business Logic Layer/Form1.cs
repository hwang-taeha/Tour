using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelPlan.Business_Logic_Layer;

namespace TravelPlan
{
    public partial class Form1 : Form
    {
        static List<List<Planner>> dayPlan = new List<List<Planner>>();// db에 저장시킬 리스트
        static List<Planner> planners = new List<Planner>();//1일차 저장리스트
        static List<Planner> tempPlan = new List<Planner>();// 찜해놓은 정보들
        static ImageList[] imageList;//찜 이미지
        public static ImageList[] ImageList { get => imageList; set => imageList = value; }

        internal static List<List<Planner>> DayPlan { get => dayPlan; set => dayPlan = value; }
        internal static List<Planner> Planners { get => planners; set => planners = value; }
        internal static List<Planner> TempPlan { get => tempPlan; set => tempPlan = value; }

        public Form1()
        {
            InitializeComponent();
        //    PlanApp planApp = new PlanApp();
        //    this.Controls.Add(planApp);
        //    planApp.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //도움창(프로그램설명)
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            bottomPanel.Width = btnHome.Width;
            bottomPanel.Left = btnHome.Left;
            
            main1.BringToFront();
            pictureBox1.BringToFront();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bottomPanel.Width = btnSearch.Width;
            bottomPanel.Left = btnSearch.Left;
            totalSearch1.BringToFront();
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            bottomPanel.Width = btnPlan.Width;
            bottomPanel.Left = btnPlan.Left;
            planning.BringToFront();
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            bottomPanel.Width = btnMap.Width;
            bottomPanel.Left = btnMap.Left;
            foundRoute1.BringToFront();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bottomPanel.Width = btnHome.Width;
            bottomPanel.Left = btnHome.Left;
            main1.BringToFront();
            ttHome.SetToolTip(this.btnHome, "홈으로 이동하기");
            ttSearch.SetToolTip(this.btnSearch, "통합검색");
            ttPlan.SetToolTip(this.btnPlan,"여행 계획 짜기");
            ttmap.SetToolTip(this.btnMap, "지도 보기");

        }

        private void planning_Load(object sender, EventArgs e)
        {

        }

        private void ttHome_Popup(object sender, PopupEventArgs e)
        {

        }
        //ToolTip toolTip = new ToolTip();
        //Point mouse = new Point();
        private void btnHome_MouseMove(object sender, MouseEventArgs e)
        {
            //mouse.X = e.X;
            //mouse.Y = e.Y;
            
            //if ((btnHome.Location.X+btnHome.Width) >mouse.X || mouse.X > btnHome.Location.X && mouse.Y>btnHome.Location.Y || mouse.Y<btnHome.Location.Y +btnHome.Height )
            //{
            //    toolTip.Show("홈 화면으로 이동",btnHome , e.X, e.Y);
            //}
            //else
            //{
            //    toolTip.RemoveAll();
            //}
            
        }
    }
}
