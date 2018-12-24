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
    public partial class SearchHotel : UserControl
    {
        List<UserData> d = new List<UserData>();
        List<string[]> strList = new List<string[]>();
        string title = "";
        string addr1 = "";
        string firstimage = "";
        string tel = "";
        string url = "";
        string combo1 = "";
        string combo2 = "";
        int pageNo = 1;
        int totalCount = 1;

        public SearchHotel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "호텔을 클릭하면 상세정보를 확인하실 수 있습니다.";
            pictureBox1.ImageLocation = "http://api.visitkorea.or.kr/static/images/common/noImage.gif";
            lblinfo.Text = "";
            strList.Clear();
            d.Clear();
            listView1.Clear();
            imageList1.Images.Clear();

            listView1.BeginUpdate();
            listView1.View = View.Tile;

            if (comboBox1.Text == "지역선택") // 전체검색하기위한코드
            {
                combo1 = "";
            }
            else
            {
                combo1 = comboBox1.SelectedIndex.ToString(); //1~3
            }

            if (comboBox2.Text == "시군구 선택")
            {
                combo2 = "";
            }
            else
            {
                combo2 = comboBox2.SelectedIndex.ToString(); //
            }

            url = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/searchStay?ServiceKey=pqrGth9gpwF%2FwgDfnF%2BsGUaHY6ZpbTW5YX1Ylw9QDu8MTxh7GxNMqTSFqwmDTC0bJIq2LepwPWJpewR02P7Vqw%3D%3D&areaCode=" + combo1 + "&sigunguCode=" + combo2 + "&listYN=Y&MobileOS=ETC&MobileApp=TourAPI3.0_Guide&arrange=A&numOfRows=10&pageNo=" + pageNo + "&_type=json";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string status = response.StatusCode.ToString();

            if (status == "OK")
            {
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                string text = reader.ReadToEnd().Replace("<b>", "").Replace("</b>", "").Replace("|", ",");
                var jobj = JObject.Parse(text);

                if (Int32.Parse(jobj["response"]["body"]["totalCount"].ToString()) % 12 != 0)
                {
                    totalCount = (Int32.Parse(jobj["response"]["body"]["totalCount"].ToString()) / 12) + 1;
                }
                else
                {
                    totalCount = Int32.Parse(jobj["response"]["body"]["totalCount"].ToString()) / 12;
                }
                label3.Text = totalCount.ToString();
                try
                {

                    var jarray = jobj["response"]["body"]["items"]["item"] as JObject;
                    imageList1.ImageSize = new Size(64, 64);
                    listView1.LargeImageList = imageList1;
                    listView1.SmallImageList = imageList1;

                    for (int i = 0; i < jobj.Count; i++)
                    {
                        if (jarray.ContainsKey("firstimage"))
                        {
                            firstimage = jarray["firstimage"].ToString();
                        }
                        else if (jarray.ContainsKey("firstimage") == false)
                        {
                            firstimage = "http://api.visitkorea.or.kr/static/images/common/noImage.gif";
                        }
                        if (jarray.ContainsKey("title"))
                        {
                            title = jarray["title"].ToString();
                        }
                        else if (jarray.ContainsKey("title") == false)
                        {
                            title = "";
                        }
                        if (jarray.ContainsKey("addr1"))
                        {
                            addr1 = jarray["addr1"].ToString();
                        }
                        else if (jarray.ContainsKey("addr1") == false)
                        {
                            addr1 = "";
                        }
                        if (jarray.ContainsKey("tel"))
                        {
                            tel = jarray["tel"].ToString();
                        }
                        else if (jarray.ContainsKey("tel") == false)
                        {
                            tel = "";
                        }
                        d.Add(new UserData(addr1, firstimage, tel, title));

                        WebRequest req = WebRequest.Create(firstimage);
                        WebResponse resp = req.GetResponse();

                        Stream st = resp.GetResponseStream();
                        Image img = Image.FromStream(st);
                        imageList1.Images.Add(img);
                    }
                }
                catch (Exception)
                {
                    try
                    {
                        var jarray = JArray.Parse(jobj["response"]["body"]["items"]["item"].ToString());
                        imageList1.ImageSize = new Size(64, 64);
                        listView1.LargeImageList = imageList1;
                        listView1.SmallImageList = imageList1;

                        foreach (JObject item in jarray)
                        {
                            if (item.ContainsKey("firstimage"))
                            {
                                firstimage = item["firstimage"].ToString();
                            }
                            else if (item.ContainsKey("firstimage") == false)
                            {
                                firstimage = "http://api.visitkorea.or.kr/static/images/common/noImage.gif";
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
                            d.Add(new UserData(addr1, firstimage, tel, title));

                            WebRequest req = WebRequest.Create(firstimage);
                            WebResponse resp = req.GetResponse();

                            Stream st = resp.GetResponseStream();
                            Image img = Image.FromStream(st);
                            imageList1.Images.Add(img);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("정보가 존재하지 않습니다");
                    }

                }
            }

            foreach (var item in d)
            {
                strList.Add(new string[] { item.Title });
            }

            listView1.Columns.Add("사진", 200, HorizontalAlignment.Center);
            listView1.Columns.Add("이름", 200, HorizontalAlignment.Center);

            int a = 0;

            foreach (var item in strList)
            {
                ListViewItem lvi = new ListViewItem(item);
                listView1.Items.Add(lvi);
                listView1.Items[a].ImageIndex = a;
                a++;
            }

            listView1.EndUpdate();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (this.pageNo == 1)
            {
                MessageBox.Show("첫 페이지 입니다.");
            }
            else
            {
                this.pageNo--;
                label1.Text = pageNo.ToString();
                button1_Click(null, null);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pageNo == totalCount)
            {
                MessageBox.Show("마지막 페이지 입니다.");
            }
            else
            {
                this.pageNo++;
                label1.Text = pageNo.ToString();
                button1_Click(null, null);
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (pageNo == 1)
            {
                MessageBox.Show("첫 페이지 입니다.");
            }
            else
            {
                label1.Text = "1";
                pageNo = 1;
                button1_Click(null, null);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (label1.Text == totalCount.ToString())
            {
                MessageBox.Show("마지막 페이지입니다.");
            }
            else
            {
                label1.Text = totalCount.ToString();
                pageNo = totalCount;
                button1_Click(null, null);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            //switch (comboBox1.SelectedIndex) // 서울일때 인천일때 대전일때
            //{
            //    case 1:
            //        comboBox2.Items.Add("강남구");
            //        comboBox2.Items.Add("강동구");
            //        comboBox2.Items.Add("강북구");
            //        comboBox2.Items.Add("강서구");
            //        comboBox2.Items.Add("관악구");
            //        comboBox2.Items.Add("광진구");
            //        comboBox2.Items.Add("구로구");
            //        comboBox2.Items.Add("금천구");
            //        comboBox2.Items.Add("노원구");
            //        comboBox2.Items.Add("도봉구");
            //        comboBox2.Items.Add("동대문구");
            //        comboBox2.Items.Add("동작구");
            //        comboBox2.Items.Add("마포구");
            //        comboBox2.Items.Add("서대문구");
            //        comboBox2.Items.Add("서초");
            //        comboBox2.Items.Add("성동구");
            //        comboBox2.Items.Add("성북구");
            //        comboBox2.Items.Add("송파구");
            //        comboBox2.Items.Add("양천구");
            //        comboBox2.Items.Add("영등포구");
            //        comboBox2.Items.Add("용산구");
            //        comboBox2.Items.Add("은평구");
            //        comboBox2.Items.Add("종로구");
            //        comboBox2.Items.Add("중구");
            //        comboBox2.Items.Add("중랑구");
            //        break;
            //    case 2:
            //        comboBox2.Items.Add("강화군");
            //        comboBox2.Items.Add("계양구");
            //        comboBox2.Items.Add("남구");
            //        comboBox2.Items.Add("남동구");
            //        comboBox2.Items.Add("동구");
            //        comboBox2.Items.Add("부평구");
            //        comboBox2.Items.Add("서구");
            //        comboBox2.Items.Add("연수구");
            //        comboBox2.Items.Add("옹진군");
            //        comboBox2.Items.Add("중구");
            //        break;
            //    case 3:
            //        comboBox2.Items.Add("대덕구");
            //        comboBox2.Items.Add("동구");
            //        comboBox2.Items.Add("서구");
            //        comboBox2.Items.Add("유성구");
            //        comboBox2.Items.Add("중구");
            //        break;
            //}
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string name;
        string addr;
        string tele;
        string image;
        private void listView1_Click(object sender, EventArgs e)
        {
            name = listView1.SelectedItems[0].Text;
            addr = d[listView1.SelectedItems[0].Index].Addr1;
            tele = d[listView1.SelectedItems[0].Index].Tel;


            lblinfo.Text = "호텔명 : " + listView1.SelectedItems[0].Text + "\n\n 주소 : " + d[listView1.SelectedItems[0].Index].Addr1 + "\n\n 전화번호 : " + d[listView1.SelectedItems[0].Index].Tel;
            pictureBox1.Image = imageList1.Images[listView1.SelectedItems[0].Index];
        }

        private void SearchHotel_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox1.Items.Add("지역선택");
            comboBox2.Items.Add("시군구 선택");
            string areaurl = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/areaCode?ServiceKey=pqrGth9gpwF%2FwgDfnF%2BsGUaHY6ZpbTW5YX1Ylw9QDu8MTxh7GxNMqTSFqwmDTC0bJIq2LepwPWJpewR02P7Vqw%3D%3D&numOfRows=17&pageNo=1&MobileOS=ETC&MobileApp=TestApp&_type=json";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(areaurl);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string text = reader.ReadToEnd();
            JObject jobj = JObject.Parse(text);
            JArray jArray = JArray.Parse(jobj["response"]["body"]["items"]["item"].ToString());
            foreach (JObject item in jArray)
            {
                comboBox1.Items.Add(item["name"].ToString());
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Items.Add("시군구 선택");
            if (comboBox1.Text == "지역선택")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("시군구 선택");
            }
            else
            {
                combo1 = comboBox1.SelectedIndex.ToString();
                if (combo1 == "0")
                {
                    combo1 = "";
                }

                string areaurl = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/areaCode?ServiceKey=pqrGth9gpwF%2FwgDfnF%2BsGUaHY6ZpbTW5YX1Ylw9QDu8MTxh7GxNMqTSFqwmDTC0bJIq2LepwPWJpewR02P7Vqw%3D%3D&numOfRows=50&pageNo=1&MobileOS=ETC&MobileApp=TestApp&areaCode=" + combo1 + "&_type=json";

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(areaurl);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                string text = reader.ReadToEnd();
                JObject jobj = JObject.Parse(text);
                try
                {
                    JArray jArray = JArray.Parse(jobj["response"]["body"]["items"]["item"].ToString());
                    foreach (JObject item in jArray)
                    {
                        comboBox2.Items.Add(item["name"].ToString());
                    }
                }
                catch (Exception)
                {
                    var jarray = jobj["response"]["body"]["items"]["item"] as JObject;

                    for (int i = 0; i < jobj.Count; i++)
                    {
                        comboBox2.Items.Add(jarray["name"].ToString());
                    }
                }
            }
        }

        private void btnJJim_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                //List<UserData> ud = new List<UserData>();

                try
                {
                    //   Form1.TempPlan.Add(new Planner(name, 0, 0, addr, tel, image));
                    Form1.TempPlan.Add(new Planner());
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

