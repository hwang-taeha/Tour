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
using Newtonsoft.Json.Linq;

namespace TravelPlan
{
    public partial class FoundRoute : UserControl
    {
        public FoundRoute()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.AutoScroll = true;
            

            var url = "https://api.odsay.com/v1/api/searchPubTransPath?SX=126.9027279&SY=37.5349277&EX=126.9145430&EY=37.5499421&apiKey=Tl0g2UD/BIHTXw1TGmxPRoTycCdo09CaQT1V9ewh0No";

            //textBox3.Text = GetJson(url);
            var jObj = JObject.Parse(GetJson(url));

            //결과 총 개수
            int ResultCount = Int32.Parse(jObj["result"]["subwayCount"].ToString()) + Int32.Parse(jObj["result"]["busCount"].ToString()) + Int32.Parse(jObj["result"]["subwayBusCount"].ToString());

            //MessageBox.Show(ResultCount.ToString());

            //var itemInfo = JArray.Parse(jObj["result"]["path"]["pathType"].ToString());
            var infoitems = JArray.Parse(jObj["result"]["path"].ToString());

            //foreach (var item in infoitems)
            //{
            //    MessageBox.Show(item["info"]["totalWalk"].ToString());
            //}


            RouteInfo[] ri = new RouteInfo[ResultCount];
            //동적 유저컨트롤 생성
            for (int i = 0; i < ResultCount; i++)
            {
                ri[i] = new RouteInfo();
                ri[i].Location = new Point(0, 0);
                flowLayoutPanel1.Controls.Add(ri[i]);
                ri[i].lblCount.Text = "경로" + (i+1);
            }
            


            for (int i = 0; i < infoitems.Count; i++)
            {
                ri[i].lblTime.Text = "약 " + infoitems[i]["info"]["totalTime"].ToString() +"분";// + "(도보 " + infoitems[i]["info"]["totalWalk"].ToString() + "분)";

                //요금
                ri[i].lblPayment.Text = infoitems[i]["info"]["payment"].ToString() + "원";

                ri[i].lblStartStation.Text = infoitems[i]["info"]["firstStartStation"].ToString() + " 승차";
                ri[i].lblEndStation.Text = infoitems[i]["info"]["lastEndStation"].ToString() + " 하차";

                //버정, 역 개수
                ri[i].lblBusStationCount.Text = "버스정류장 " + infoitems[i]["info"]["busStationCount"].ToString() + "개";
                ri[i].lblSubStationCount.Text = "지하철역 " + infoitems[i]["info"]["subwayStationCount"].ToString() + "개";

                //총길이
                ri[i].lblDistance.Text = "총 " + double.Parse(infoitems[i]["info"]["totalDistance"].ToString())/ 1000 + "km";
            }


        }

        public string GetJson(string url)
        {
            string json = "";
            HttpWebRequest req = WebRequest.Create(url) as HttpWebRequest;
            HttpWebResponse resp = req.GetResponse() as HttpWebResponse;

            var statusCode = resp.StatusCode.ToString();

            if (statusCode == "OK")
            {
                Stream stream = resp.GetResponseStream();
                StreamReader sr = new StreamReader(stream, Encoding.UTF8);
                json = sr.ReadToEnd().Replace("<b>", "").Replace("</b>", "").Replace("|", ",");
            }

            return json;
        }
    }
}
