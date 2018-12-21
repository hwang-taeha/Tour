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
        }
        int PageNumber=0;
        int day;
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (PageNumber==0)
            {
                day = this.planDateControl1.days;
                planDateControl1.Dispose();
                planCheck.BringToFront();
                Form1.ImageList = new ImageList[day];
                for (int i = 0; i < day; i++)
                {
                    planCheck.cbTotalDays.Items.Add(i + 1);
                    Form1.DayPlan.Add(new List<Planner>());
                    Form1.ImageList[i] = new ImageList();

                }
                planCheck.cbTotalDays.Text = planCheck.cbTotalDays.Items[0].ToString();
            }

            if (PageNumber==1)
            {
                completePlan.Start();
                completePlan.BringToFront();
            }

            PageNumber++;


        }

        private void planCheck_Load(object sender, EventArgs e)
        {

        }
    }
}
