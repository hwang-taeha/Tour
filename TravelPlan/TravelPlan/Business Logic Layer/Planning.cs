using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelPlan.Business_Logic_Layer
{
    public partial class Planning : UserControl
    {
        public Planning()
        {
            InitializeComponent();
            planDateControl1.BringToFront();
            btnpre.Enabled = false;
            btnDone.Visible = false;
        }
        int PageNumber=0;
        int day;
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (PageNumber==0)
            {
               
                Form1.DayPlan.Clear();
                planCheck.lblPlan.Text = planDateControl1.lblFirstDay.Text + "~" + planDateControl1.lblLastDay.Text;
                planCheck.cbTotalDays.Items.Clear();
                day = this.planDateControl1.days;
                //planDateControl1.Dispose();
                planCheck.BringToFront();
                Form1.ImageList = new ImageList[day];
                for (int i = 0; i < day; i++)
                {
                    planCheck.cbTotalDays.Items.Add(i + 1);
                    Form1.DayPlan.Add(new List<Planner>());
                    Form1.ImageList[i] = new ImageList();
                }
                planCheck.cbTotalDays.Text = planCheck.cbTotalDays.Items[0].ToString();
                btnpre.Enabled = true;
            }

            if (PageNumber==1)
            {
                completePlan.Start();
                completePlan.BringToFront();
                btnNext.Visible = false;
                btnDone.Visible = true;
                btnpre.Location = new Point(747, 369);
            }

            PageNumber++;


        }

        private void planCheck_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PageNumber==1)
            {
                planDateControl1.BringToFront();
                btnpre.Enabled = false;
            }
          
            if (PageNumber==2)
            {
                //foreach (var item in Form1.ImageList)
                //{
                //    item.Images.Clear();
                //}
                planCheck.BringToFront();
                btnpre.Location = new Point(666, 369);
                btnNext.Visible = true;
                btnDone.Visible = false;
            }
            PageNumber--;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            PlannerDAO plannerDAO = PlannerDAO.getInstance();

            foreach (var item in Form1.DayPlan)
            {
                for (int i = 0; i < item.Count; i++)
                {
                    Planner plan = new Planner(i, item[i].Name, item[i].MapX, item[i].MapY, item[i].Loc, item[i].Tel, item[i].Image);
                    plannerDAO.InsertPlanner(plan);
                }
            }
            //Form1.DayPlan.Clear();
            //Form1.TempPlan.Clear();
            MessageBox.Show("저장되었습니다");
            planDateControl1.BringToFront();
            
        }
    }
}
