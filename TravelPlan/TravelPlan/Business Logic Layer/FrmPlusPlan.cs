using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.IO;
using Newtonsoft.Json.Linq;

namespace TravelPlan
{
    public partial class FrmPlusPlan : Form
    {
        public FrmPlusPlan()
        {
            InitializeComponent();

        }
        List<Planner> tempPlanners = new List<Planner>();
        ImageList imageList = new ImageList();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            imageList.Images.Clear();
            tempPlanners.Clear();
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                //string privateKey = ConfigurationManager.ConnectionStrings["APIKey"].ConnectionString;
                string privateKey = "g0bFjmq9pmCLoJqvIGHUrWi%2FemZAn7PEDenAhZEGmwaL5DwzsEL%2FNV3gTWA8auCqFN2l7DzrKCuRMMD2FeSRSg%3D%3D";
                string searchText = HttpUtility.UrlEncode(textBox1.Text, Encoding.UTF8);


                string url = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/searchKeyword?ServiceKey=" + privateKey + "&keyword=" + searchText + "&areaCode=&sigunguCode=&cat1=&cat2=&cat3=&listYN=Y&MobileOS=ETC&MobileApp=TourAPI3.0_Guide&arrange=A&numOfRows=12&pageNo=1&_type=json";
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Stream stream = response.GetResponseStream();
                StreamReader sr = new StreamReader(stream, Encoding.UTF8);

                //검색결과 전체의 json파일을 파싱
                JObject jObject = JObject.Parse(sr.ReadToEnd());
                var items = jObject["response"]["body"]["items"]["item"].ToString();
                JArray jArray = JArray.Parse(items);


                foreach (JObject item in jArray)
                {
                    //Pelanner객체를 위한 저장 변수
                    string image = "";
                    string tel = "";
                    string title = "";
                    string addr1 = "";
                    float mapX = 0;
                    float mapY = 0;

                    if (!item.ContainsKey("firstimage"))
                    {
                        image = "http://api.visitkorea.or.kr/static/images/common/noImage.gif";
                    }
                    else { image = item["firstimage"].ToString(); }
                    if (item.ContainsKey("title"))
                    {
                        title = item["title"].ToString();
                    }
                    if (item.ContainsKey("tel"))
                    {
                        tel = item["tel"].ToString();
                    }
                    if (item.ContainsKey("addr1"))
                    {
                        addr1 = item["addr1"].ToString();
                    }
                    if (item.ContainsKey("mapX"))
                    {
                        mapX = float.Parse(item["mapX"].ToString());
                    }
                    if (item.ContainsKey("mapY"))
                    {
                        mapY = float.Parse(item["mapY"].ToString());
                    }

                    tempPlanners.Add(new Planner(title, mapX, mapY, addr1, tel, image));
                    WebRequest req = WebRequest.Create(image);
                    WebResponse resp = req.GetResponse();

                    imageList.ImageSize = new Size(64, 64);
                    stream = resp.GetResponseStream();
                    Image img = Image.FromStream(stream);
                    imageList.Images.Add(img);

                }
                listView1.LargeImageList = imageList;
                listView1.SmallImageList = imageList;
                List<string[]> strArray = new List<string[]>();
                foreach (var item in tempPlanners)
                {
                    strArray.Add(new string[] { item.Name });
                }
                for (int i = 0; i < strArray.Count; i++)
                {
                    ListViewItem listViewItem = new ListViewItem(strArray[i]);
                    listView1.Items.Add(listViewItem);
                    listView1.Items[i].ImageIndex = i;
                } 
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                Form1.TempPlan.Add(tempPlanners[listView1.SelectedItems[0].Index]);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("관광지를 선택해주세요.");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
//static List<List<Planner>> dayPlan = new List<List<Planner>>();// db에 저장시킬 리스트
//static List<Planner> planners = new List<Planner>();//1일차 저장리스트
//static List<Planner> tempPlan = new List<Planner>();// 찜해놓은 정보들