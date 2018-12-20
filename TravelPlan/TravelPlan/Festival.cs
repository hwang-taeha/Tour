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
    public partial class Festival : UserControl
    {

        List<FestivalInfo> lst = new List<FestivalInfo>();
        private string areaCode = "";
        private string sigunguCode = "";
        int pageNo = 1;
        int totalcount = 0;

        static string name;
        static string addr;
        static string tel;
        static string image;


        string contentid = "";
        string contenttypeid = "";


        public Festival()
        {
            InitializeComponent();
        }
        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int sDate = 0;
            int eDate = 0;

            if (startDate.Value <= endDate.Value)
            {
                sDate = Int32.Parse(startDate.Value.ToShortDateString().Replace("-", ""));
                eDate = Int32.Parse(endDate.Value.ToShortDateString().Replace("-", "")); 
            }
            else
            {
                sDate = Int32.Parse(endDate.Value.ToShortDateString().Replace("-", ""));
                eDate = Int32.Parse(startDate.Value.ToShortDateString().Replace("-", ""));
            }
            
            var url = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/searchFestival?ServiceKey=g0bFjmq9pmCLoJqvIGHUrWi%2FemZAn7PEDenAhZEGmwaL5DwzsEL%2FNV3gTWA8auCqFN2l7DzrKCuRMMD2FeSRSg%3D%3D&eventStartDate=" + sDate + "&eventEndDate=" + eDate + "&areaCode=&sigunguCode=&cat1=&cat2=&cat3=&listYN=Y&MobileOS=ETC&MobileApp=TourAPI3.0_Guide&_type=json&arrange=A&numOfRows=12&pageNo=" + pageNo;


            GetJson(url);
            Display(lst, url);
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

        private void Display(List<FestivalInfo> lst, string url)
        {
            lst.Clear();
            lvFestival.Clear();

            int i = 0;
            string image = "";
            string tel = "";
            string title = "";
            string addr1 = "";
            string eventstartdate = "";
            string eventenddate = "";

            string contentid = "";
            string contenttypeid = "";

            lvFestival.BeginUpdate();
            
            lvFestival.View = View.Tile;

            var jObj = JObject.Parse(GetJson(url));
            var itemsArr = JArray.Parse(jObj["response"]["body"]["items"]["item"].ToString());

            if (Int32.Parse(jObj["response"]["body"]["totalCount"].ToString()) % 12 != 0)
            {
                totalcount = (Int32.Parse(jObj["response"]["body"]["totalCount"].ToString()) / 12) + 1;
            }
            else
            {
                totalcount = Int32.Parse(jObj["response"]["body"]["totalCount"].ToString()) / 12;
            }
            lblNowPage.Text = pageNo.ToString();
            lblTotalPage.Text = totalcount.ToString();

            lblResultCount.Text = "검색결과 개수 : " + jObj["response"]["body"]["totalCount"].ToString() + " 개";

            ImageList imglist = new ImageList();
            imglist.ImageSize = new Size(64, 64);
            Stream stream;
            lvFestival.LargeImageList = imglist;
            lvFestival.SmallImageList = imglist;
            foreach (JObject item in itemsArr)
            {
                if (item.ContainsKey("firstimage"))
                {
                    image = item["firstimage"].ToString();
                }
                else if (item.ContainsKey("firstimage") == false)
                {
                    image = "http://api.visitkorea.or.kr/static/images/common/noImage.gif";
                }
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
                if (item.ContainsKey("tel"))
                {
                    tel = item["tel"].ToString();
                }
                else if (item.ContainsKey("tel") == false)
                {
                    tel = "";
                }
                if (item.ContainsKey("eventstartdate"))
                {
                    eventstartdate = item["eventstartdate"].ToString();
                }
                else if (item.ContainsKey("eventstartdate") == false)
                {
                    eventstartdate = "";
                }
                if (item.ContainsKey("eventenddate"))
                {
                    eventenddate = item["eventenddate"].ToString();
                }
                else if (item.ContainsKey("eventenddate") == false)
                {
                    eventenddate = "";
                }
                if (item.ContainsKey("contentid"))
                {
                    contentid = item["contentid"].ToString();
                }
                else if (item.ContainsKey("contentid") == false)
                {
                    contentid = "";
                }
                if (item.ContainsKey("contenttypeid"))
                {
                    contenttypeid = item["contenttypeid"].ToString();
                }
                else if (item.ContainsKey("contenttypeid") == false)
                {
                    contenttypeid = "";
                }
                WebRequest req = WebRequest.Create(image);
                WebResponse resp = req.GetResponse();

                stream = resp.GetResponseStream();
                Image img = Image.FromStream(stream);
                imglist.Images.Add(img);
                
                
                lst.Add(new FestivalInfo(image, title, addr1, contentid, contenttypeid, eventstartdate, eventenddate, tel));
                
            }
            
            List<string[]> strList = new List<string[]>();
            
            foreach (var item in lst)
            {
                strList.Add(new string[] { item.Title });
                
            }
           
            
            lvFestival.Columns.Add("사진", 200, HorizontalAlignment.Center);
            lvFestival.Columns.Add("이름", 200, HorizontalAlignment.Center);
            
            foreach (var item in strList)
            {
                
                ListViewItem lvi = new ListViewItem(item);
                
                lvFestival.Items.Add(lvi);
                lvFestival.Items[i].ImageIndex = i;
                i++;
            }
            
            lvFestival.EndUpdate();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pageNo == Int32.Parse(lblTotalPage.Text))
            {
                MessageBox.Show("마지막 페이지 입니다.");
            }
            else
            {
                this.pageNo++;
                btnSearch_Click(null, null);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (pageNo == 1)
            {
                MessageBox.Show("처음 페이지 입니다.");
            }
            else
            {
                pageNo--;
                btnSearch_Click(null, null);
            }
        }

        private void lvFestival_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (var item in lst)
            {
                if (item.Title == lvFestival.SelectedItems[0].SubItems[0].Text)
                {
                    contentid = item.Contentid;
                    contenttypeid = item.Contenttypeid;

                    
                }
            }
            FestivalDetails fd = new FestivalDetails(this, contentid, contenttypeid);
            fd.ShowDialog();
        }
        
        private void btnDib_Click(object sender, EventArgs e)
        {
            //Form1 f = new Form1();
            //MessageBox.Show(lvFestival.SelectedItems[0].SubItems[0].Text);


            if (lvFestival.SelectedItems.Count != 0)
            {
                foreach (var item in lst)
                {
                    //MessageBox.Show(item.Title);
                    if (lvFestival.SelectedItems[0].SubItems[0].Text == item.Title)
                    {
                        name = item.Title;
                        addr = item.Addr1;
                        tel = item.Tel;
                        image = item.Image;
                    }
                }
                try
                {
                    Form1.TempPlan.Add(new Planner(name, 0, 0, addr, tel, image));
                    MessageBox.Show("찜목록에 추가되었습니다.");
                }
                catch (Exception)
                {
                    MessageBox.Show("추가 실패");
                }
            }
            else
            {
                MessageBox.Show("축제를 선택해주세요");
            }
        }
    }
}
