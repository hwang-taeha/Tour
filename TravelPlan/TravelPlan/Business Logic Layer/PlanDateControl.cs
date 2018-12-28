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
    public partial class PlanDateControl : UserControl
    {
        public PlanDateControl()
        {
            InitializeComponent();
            lblFirstDay.Text = calFirstDay.SelectionRange.End.ToShortDateString();
            lblLastDay.Text = calLastDay.SelectionEnd.ToShortDateString();
        }
        public int days = 1;
        private void SubrtactDate()
        {

            var dtp = calLastDay.SelectionEnd.Subtract(calFirstDay.SelectionRange.End);

            days = Math.Abs(int.Parse(dtp.Days.ToString())) + 1;


        }
        private void calFirstDay_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (calFirstDay.SelectionEnd < DateTime.Now)
            {
                MessageBox.Show("계획일정은 지난일이 될 수 없습니다.");
                calFirstDay.SelectionEnd = DateTime.Now;
            }
            else
            {
                lblFirstDay.Text = calFirstDay.SelectionRange.End.ToShortDateString();
                SubrtactDate();
            }
            if (calFirstDay.SelectionEnd>calLastDay.SelectionEnd)
            {
                calLastDay.SelectionEnd = calFirstDay.SelectionEnd;
            }
            
        }

        private void calLastDay_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (calLastDay.SelectionEnd < calFirstDay.SelectionEnd)
            {
                MessageBox.Show("도착일이 시작일보다 작을 수 없습니다");
                calLastDay.SelectionEnd = calFirstDay.SelectionEnd;
            }
            else
            {
                lblLastDay.Text = calLastDay.SelectionEnd.ToShortDateString();
                SubrtactDate();
            }
            
        }
    }
}
