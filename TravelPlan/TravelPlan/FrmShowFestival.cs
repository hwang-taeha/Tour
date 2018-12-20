using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelPlan
{
    public partial class FrmShowFestival : Form
    {
        private int startdate;
        private int enddate;

        public FrmShowFestival()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var url = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/searchFestival?ServiceKey=g0bFjmq9pmCLoJqvIGHUrWi%2FemZAn7PEDenAhZEGmwaL5DwzsEL%2FNV3gTWA8auCqFN2l7DzrKCuRMMD2FeSRSg%3D%3D&eventStartDate=" + startdate + "&eventEndDate=" + enddate + "&areaCode=&sigunguCode=&cat1=&cat2=&cat3=&listYN=Y&MobileOS=ETC&MobileApp=TourAPI3.0_Guide&_type=json&arrange=A&numOfRows=12&pageNo=1";
            
        }
    }
}
