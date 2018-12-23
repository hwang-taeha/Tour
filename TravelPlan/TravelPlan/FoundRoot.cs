using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;

namespace TravelPlan
{
    public partial class FoundRoute : UserControl
    {
        double startmapX = 0;
        double startmapY = 0;
        double endmapX = 0;
        double endmapY = 0;


        public FoundRoute()
        {
            InitializeComponent();
        }

        private void btnFoundRoute_Click(object sender, EventArgs e)
        {

            if (startmapX != 0 && startmapY != 0 && endmapX != 0 && endmapY != 0)
            {


                flowLayoutPanel1.AutoScroll = true;

                var url = "https://api.odsay.com/v1/api/searchPubTransPath?SX=" + startmapX + "&SY=" + startmapY + "&EX=" + endmapX + "&EY=" + endmapY + "&apiKey=Tl0g2UD/BIHTXw1TGmxPRoTycCdo09CaQT1V9ewh0No";

                //textBox3.Text = GetJson(url);
                var jObj = JObject.Parse(GetJson(url));

                //결과 총 개수
                int ResultCount = Int32.Parse(jObj["result"]["subwayCount"].ToString()) + Int32.Parse(jObj["result"]["busCount"].ToString()) + Int32.Parse(jObj["result"]["subwayBusCount"].ToString());

                var infoitems = JArray.Parse(jObj["result"]["path"].ToString());



                RouteInfo[] ri = new RouteInfo[ResultCount];
                //동적 유저컨트롤 생성
                for (int i = 0; i < ResultCount; i++)
                {
                    ri[i] = new RouteInfo();
                    ri[i].Location = new Point(0, 0);
                    flowLayoutPanel1.Controls.Add(ri[i]);
                    ri[i].lblCount.Text = "경로" + (i + 1);
                }

                for (int i = 0; i < infoitems.Count; i++)
                {
                    ri[i].lblTime.Text = infoitems[i]["info"]["totalTime"].ToString() + "분";

                    //요금
                    ri[i].lblPayment.Text = infoitems[i]["info"]["payment"].ToString() + "원";

                    ri[i].lblStartStation.Text = infoitems[i]["info"]["firstStartStation"].ToString() + " 승차";
                    ri[i].lblEndStation.Text = infoitems[i]["info"]["lastEndStation"].ToString() + " 하차";

                    //버정, 역 개수
                    ri[i].lblBusStationCount.Text = "버스정류장 " + infoitems[i]["info"]["busStationCount"].ToString() + "개";
                    ri[i].lblSubStationCount.Text = "지하철역 " + infoitems[i]["info"]["subwayStationCount"].ToString() + "개";

                    //총길이
                    ri[i].lblDistance.Text = "총 " + double.Parse(infoitems[i]["info"]["totalDistance"].ToString()) / 1000 + "km";
                }
            }
            else
            {
                MessageBox.Show("출발지와 도착지를 선택해주세요.");
            }


        }

        public string GetJson(string url)
        {
            string json = "";
            HttpWebRequest req = WebRequest.Create(url) as HttpWebRequest;
            // req.Headers.Add("X-Naver-Client-Id", "2iWRSvguN8fz2JcphTOK");
            req.Headers.Add("Authorization", "KakaoAK 6d50d882ef31843f50c32af093a7f8d0");
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

        private void tboxStart_Click(object sender, EventArgs e)
        {
            tboxStart.Text = "";
        }

        private void tboxEnd_Click(object sender, EventArgs e)
        {
            tboxEnd.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                GetXY(tboxStart.Text);
            }
            catch (WebException)
            {
                MessageBox.Show("출발지를 설정해주세요");
            }
        }

        private void btnEndSearch_Click(object sender, EventArgs e)
        {

            try
            {
                GetXY(tboxEnd.Text);
            }
            catch (WebException)
            {
                MessageBox.Show("도착지를 설정해주세요");
            }
        }

        private void GetXY(string text)
        {
            lvSearchResult.Clear();

            lvSearchResult.View = View.List;


            string query = text;

            var url = "https://dapi.kakao.com/v2/local/search/keyword.json?query=" + query;


            var jObj = JObject.Parse(GetJson(url));
            var itemsArr = JArray.Parse(jObj["documents"].ToString());
            foreach (var item in itemsArr)
            {
                lvSearchResult.Items.Add(new ListViewItem(new string[] { item["place_name"].ToString(), item["x"].ToString(), item["y"].ToString() }));
            }
        }

        private void btnStartSet_Click(object sender, EventArgs e)
        {
            if (lvSearchResult.SelectedItems.Count != 0)
            {
                tboxStart.Text = lvSearchResult.SelectedItems[0].SubItems[0].Text;

                startmapX = double.Parse(lvSearchResult.SelectedItems[0].SubItems[1].Text);
                startmapY = double.Parse(lvSearchResult.SelectedItems[0].SubItems[2].Text);
                MessageBox.Show("완료");
            }
            else
            {
                MessageBox.Show("출발지를 선택해주세요.");
            }
        }

        private void btnEndSet_Click(object sender, EventArgs e)
        {
            if (lvSearchResult.SelectedItems.Count != 0)
            {
                tboxEnd.Text = lvSearchResult.SelectedItems[0].SubItems[0].Text;

                endmapX = double.Parse(lvSearchResult.SelectedItems[0].SubItems[1].Text);
                endmapY = double.Parse(lvSearchResult.SelectedItems[0].SubItems[2].Text);
                MessageBox.Show("완료");
            }
            else
            {
                MessageBox.Show("도착지를 선택해주세요.");
            }
        }


    }
}
