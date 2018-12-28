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
    public partial class PlanApp : UserControl
    {
        public PlanApp()
        {
            InitializeComponent();
            this.AdjustFormScrollbars(this.VScroll);
            this.AutoScroll = true;
            
            
        }
    }
}
