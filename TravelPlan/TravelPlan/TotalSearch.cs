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
    public partial class TotalSearch : UserControl
    {
        public TotalSearch()
        {
            InitializeComponent();
        }

        List<SearchResult> lst = new List<SearchResult>();
        private int areaCode;
        private int sigunguCode;
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            gvTotalSearch.DataSource = "";
            lst.Clear();


            string keyword = ConvertToHex(tboxSearch.Text);

            var url = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/searchKeyword?ServiceKey=g0bFjmq9pmCLoJqvIGHUrWi%2FemZAn7PEDenAhZEGmwaL5DwzsEL%2FNV3gTWA8auCqFN2l7DzrKCuRMMD2FeSRSg%3D%3D&keyword=" + keyword + "&areaCode=&sigunguCode=&cat1=&cat2=&cat3=&listYN=Y&MobileOS=ETC&MobileApp=TourAPI3.0_Guide&_type=json&arrange=A&numOfRows=12&pageNo=1";

            GetJson(url);
            Display(lst, url);
        }

        private string ConvertToHex(string inputtext)
        {
            byte[] utf16 = Encoding.Unicode.GetBytes(inputtext);
            byte[] utf8 = Encoding.Convert(Encoding.Unicode, Encoding.UTF8, utf16);

            string hexStr = "";
            for (int i = 0; i < utf8.Length; i++)
            {
                var hexnum = Convert.ToString((int)utf8[i], 16);
                hexStr += "%" + hexnum.ToUpper();
            }
            return hexStr;
        }

        private void Display(List<SearchResult> lst, string url)
        {
            var jObj = JObject.Parse(GetJson(url));
            var itemsArr = JArray.Parse(jObj["response"]["body"]["items"]["item"].ToString());

            string addr1 = "";
            string addr2 = "";
            int areacode = 0;
            int booktour = 0;
            string cat1 = "";
            string cat2 = "";
            string cat3 = "";
            int contentid = 0;
            int contenttypeid = 0;
            string createdtime = null;
            string firstimage = "";
            string firstimage2 = "";
            string mapx = "";
            string mapy = "";
            int mlevel = 0;
            string modifiedtime = null;
            int readcount = 0;
            int sigungucode = 0;
            string tel = "";
            string title = "";
            int zipcode = 0;

            foreach (JObject item in itemsArr)
            {
                if (item.ContainsKey("title"))
                {
                    title = item["title"].ToString();
                }
                else if (item.ContainsKey("title") == false)
                {
                    title = "";
                }
                if (item.ContainsKey("addr1"))
                {
                    addr1 = item["addr1"].ToString();
                }
                else if (item.ContainsKey("addr1") == false)
                {
                    addr1 = "";
                }
                if (item.ContainsKey("addr2"))
                {
                    addr2 = item["addr2"].ToString();
                }
                else if (item.ContainsKey("addr2") == false)
                {
                    addr2 = "";
                }
                if (item.ContainsKey("areacode"))
                {
                    areacode = Int32.Parse(item["areacode"].ToString());
                }
                else if (item.ContainsKey("areacode") == false)
                {
                    areacode = 0;
                }
                if (item.ContainsKey("booktour"))
                {
                    booktour = Int32.Parse(item["booktour"].ToString());
                }
                else if (item.ContainsKey("booktour") == false)
                {
                    booktour = 0;
                }
                if (item.ContainsKey("cat1"))
                {
                    cat1 = item["cat1"].ToString();
                }
                else if (item.ContainsKey("cat1") == false)
                {
                    cat1 = "";
                }
                if (item.ContainsKey("cat2"))
                {
                    cat2 = item["cat2"].ToString();
                }
                else if (item.ContainsKey("cat2") == false)
                {
                    cat2 = "";
                }
                if (item.ContainsKey("cat3"))
                {
                    cat3 = item["cat3"].ToString();
                }
                else if (item.ContainsKey("cat3") == false)
                {
                    cat3 = "";
                }
                if (item.ContainsKey("contentid"))
                {
                    contentid = Int32.Parse(item["contentid"].ToString());
                }
                else if (item.ContainsKey("contentid") == false)
                {
                    contentid = 0;
                }
                if (item.ContainsKey("contenttypeid"))
                {
                    contenttypeid = Int32.Parse(item["contenttypeid"].ToString());
                }
                else if (item.ContainsKey("contenttypeid") == false)
                {
                    contenttypeid = 0;
                }
                if (item.ContainsKey("createdtime"))
                {
                    createdtime = item["createdtime"].ToString();
                }
                else if (item.ContainsKey("createdtime") == false)
                {
                    createdtime = null;
                }
                if (item.ContainsKey("firstimage"))
                {
                    firstimage = item["firstimage"].ToString();
                }
                else if (item.ContainsKey("firstimage") == false)
                {
                    firstimage = "";
                }
                if (item.ContainsKey("firstimage2"))
                {
                    firstimage2 = item["firstimage2"].ToString();
                }
                else if (item.ContainsKey("firstimage2") == false)
                {
                    firstimage2 = "";
                }
                if (item.ContainsKey("mapx"))
                {
                    mapx = item["mapx"].ToString();
                }
                else if (item.ContainsKey("mapx") == false)
                {
                    mapx = "";
                }
                if (item.ContainsKey("mapy"))
                {
                    mapy = item["mapy"].ToString();
                }
                else if (item.ContainsKey("mapy") == false)
                {
                    mapy = "";
                }
                if (item.ContainsKey("mlevel"))
                {
                    mlevel = Int32.Parse(item["mlevel"].ToString());
                }
                else if (item.ContainsKey("mlevel") == false)
                {
                    mlevel = 0;
                }
                if (item.ContainsKey("modifiedtime"))
                {
                    modifiedtime = item["modifiedtime"].ToString();
                }
                else if (item.ContainsKey("modifiedtime") == false)
                {
                    modifiedtime = null;
                }
                if (item.ContainsKey("readcount"))
                {
                    readcount = Int32.Parse(item["readcount"].ToString());
                }
                else if (item.ContainsKey("readcount") == false)
                {
                    readcount = 0;
                }
                if (item.ContainsKey("sigungucode"))
                {
                    sigungucode = Int32.Parse(item["sigungucode"].ToString());
                }
                else if (item.ContainsKey("sigungucode") == false)
                {
                    sigungucode = 0;
                }
                if (item.ContainsKey("tel"))
                {
                    tel = item["tel"].ToString();
                }
                else if (item.ContainsKey("tel") == false)
                {
                    tel = "";
                }
                if (item.ContainsKey("title"))
                {
                    title = item["title"].ToString();
                }
                else if (item.ContainsKey("title") == false)
                {
                    title = "";
                }
                if (item.ContainsKey("zipcode"))
                {
                    zipcode = Int32.Parse(item["zipcode"].ToString());
                }
                else if (item.ContainsKey("zipcode") == false)
                {
                    zipcode = 0;
                }
                lst.Add(new SearchResult(title, addr1, addr2, areacode, booktour, cat1, cat2, cat3, contentid, contenttypeid, createdtime, firstimage, firstimage2, mapx, mapy, mlevel, modifiedtime, readcount, sigungucode, tel, zipcode));
            }
            gvTotalSearch.DataSource = lst;
        }


        private string GetJson(string url)
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
            textBox1.Text = json;
            return json;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmShowFestival sf = new FrmShowFestival();
            sf.Show();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {

        }
    }
}
