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
            lblFirstDay.Text = calFirstDay.SelectionRange.End.ToShortDateString();
            SubrtactDate();
        }

        private void calLastDay_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblLastDay.Text = calLastDay.SelectionEnd.ToShortDateString();
            SubrtactDate();
        }
    }
}
