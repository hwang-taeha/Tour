using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace TravelPlan
{
    public partial class Traffic : UserControl
    {
        public Traffic()
        {
            InitializeComponent();
        }

        private void Traffic_Load(object sender, EventArgs e)
        {
            //string url = "http://127.0.0.1/Traffic.html";
            //webBrowser1.Navigate(url);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "http://192.168.0.242/Traffic.html";
            //string url = "http://127.0.0.1/Traffic.html";
            try
            {
                webBrowTraffic.Navigate(url);
                lblStatus.Text = "기준 : " + DateTime.Now.ToShortTimeString() + "  일부지역 및 도로구간에서는 교통정보가 제공되지 않을 수 있습니다.";
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("연결 실패");
            }
            
        }
    }
}
