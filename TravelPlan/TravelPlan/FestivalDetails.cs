using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelPlan
{
    public partial class FestivalDetails : Form
    {
        bool check = false;
        JObject items;
        ImageList imgList = new ImageList();
        Image img;
        Festival f;
        string contentid;
        string contenttypeid;

        public FestivalDetails(Festival f, string contentid, string contenttypeid)
        {
            InitializeComponent();
            this.contentid = contentid;
            this.contenttypeid = contenttypeid;
            this.f = f;
        }

        private void FestivalDetails_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(contenttypeid, contentid);
            CommonInfo();
            IntroduceInfo();
            if (check)
            {
                MoreImage();
            }
            else
            {
                pboxMain.ImageLocation = "http://api.visitkorea.or.kr/static/images/common/noImage.gif";
            }
            
        }

        //공통정보
        private void CommonInfo()
        {
            var url = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/detailCommon?ServiceKey=g0bFjmq9pmCLoJqvIGHUrWi%2FemZAn7PEDenAhZEGmwaL5DwzsEL%2FNV3gTWA8auCqFN2l7DzrKCuRMMD2FeSRSg%3D%3D&contentTypeId=" + contenttypeid + "&contentId=" + contentid + "&MobileOS=ETC&MobileApp=TourAPI3.0_Guide&_type=json&defaultYN=Y&firstImageYN=Y&areacodeYN=Y&catcodeYN=Y&addrinfoYN=Y&mapinfoYN=Y&overviewYN=Y&transGuideYN=Y";

            var jObj = JObject.Parse(f.GetJson(url));

            items = jObj["response"]["body"]["items"]["item"] as JObject;

            if (items.ContainsKey("firstimage"))
            {
                pboxFirstPage.ImageLocation = items["firstimage"].ToString();
                check = true;
            }
            else
            {
                pboxFirstPage.ImageLocation = "http://api.visitkorea.or.kr/static/images/common/noImage.gif";
            }
            if (items.ContainsKey("addr1"))
            {
                lblAddr.Text = items["addr1"].ToString().Trim();
            }
            else
            {
                lblAddr.Text = "";
            }
            if (items.ContainsKey("telname"))
            {
                lblTelName.Text = items["telname"].ToString().Trim();
            }
            else
            {
                lblTelName.Text = "";
            }
            if (items.ContainsKey("tel"))
            {
                lblTel.Text = items["tel"].ToString().Trim();
            }
            else
            {
                lblTel.Text = "";
            }
            if (items.ContainsKey("zipcode"))
            {
                lblPostal.Text = items["zipcode"].ToString().Trim();
            }
            else
            {
                lblPostal.Text = "";
            }
            if (items.ContainsKey("overview"))
            {
                tboxDesc.Text = items["overview"].ToString().Replace("<strong>", "").Replace("</strong>", "").Replace("<br>", "").Replace("&nbsp", "").Replace("<br />", "").Replace("&gt;", "").Replace("&lt;", "");
            }
            else
            {
                tboxDesc.Text = "";
            }
            if (items.ContainsKey("title"))
            {
                lblTitle.Text = items["title"].ToString().Trim();
            }
            else
            {
                lblTitle.Text = "";
            }
        }

        //소개정보
        private void IntroduceInfo()
        {
            string spendtimefestival = "";

            var url = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/detailIntro?ServiceKey=g0bFjmq9pmCLoJqvIGHUrWi%2FemZAn7PEDenAhZEGmwaL5DwzsEL%2FNV3gTWA8auCqFN2l7DzrKCuRMMD2FeSRSg%3D%3D&contentTypeId="+contenttypeid+"&contentId="+contentid+"&MobileOS=ETC&MobileApp=TourAPI3.0_Guide&_type=json&introYN=Y";

            var jObj = JObject.Parse(f.GetJson(url));

            items = jObj["response"]["body"]["items"]["item"] as JObject;

            if (items.ContainsKey("spendtimefestival"))
            {
                tboxIntro.Text = "주최자 정보 : " + items["sponsor1"].ToString() + "\r\n\r\n";
                tboxIntro.Text += "주최자 연락처 : " + items["sponsor1tel"].ToString() + "\r\n\r\n";
                tboxIntro.Text += "행사시작일 : " + items["eventstartdate"].ToString() + "\r\n\r\n";
                tboxIntro.Text += "행사종료일 : " + items["eventenddate"].ToString() + "\r\n\r\n";
                tboxIntro.Text += "공연시간 : " + items["playtime"].ToString() + "\r\n\r\n";
                tboxIntro.Text += "행사장소 : " + items["eventplace"].ToString() + "\r\n\r\n";
                tboxIntro.Text += "관람소요시간 : " + items["spendtimefestival"].ToString() + "\r\n\r\n";
                tboxIntro.Text += "관람가능연령 : " + items["agelimit"].ToString();
            }
            else
            {
                tboxIntro.Text = "주최자 정보 : " + items["sponsor1"].ToString() + "\r\n\r\n";
                tboxIntro.Text += "주최자 연락처 : " + items["sponsor1tel"].ToString() + "\r\n\r\n";
                tboxIntro.Text += "행사시작일 : " + items["eventstartdate"].ToString() + "\r\n\r\n";
                tboxIntro.Text += "행사종료일 : " + items["eventenddate"].ToString() + "\r\n\r\n";
                tboxIntro.Text += "공연시간 : " + items["playtime"].ToString() + "\r\n\r\n";
                tboxIntro.Text += "행사장소 : " + items["eventplace"].ToString() + "\r\n\r\n";
                tboxIntro.Text += "관람가능연령 : " + items["agelimit"].ToString();
            }
        }

        //추가이미지
        private void MoreImage()
        {
            string imageUrl = "";
            var url = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/detailImage?ServiceKey=g0bFjmq9pmCLoJqvIGHUrWi%2FemZAn7PEDenAhZEGmwaL5DwzsEL%2FNV3gTWA8auCqFN2l7DzrKCuRMMD2FeSRSg%3D%3D&contentTypeId=" + contenttypeid + "&MobileOS=ETC&MobileApp=TourAPI3.0_Guide&_type=json&contentId=" + contentid + "&imageYN=Y";

            var jObj = JObject.Parse(f.GetJson(url));
            var items = JArray.Parse(jObj["response"]["body"]["items"]["item"].ToString());

            
            imgList.ImageSize = new Size(256, 256);
            Stream stream;

            //items = jObj["response"]["body"]["items"]["item"] as JObject;
            foreach (JObject item in items)
            {
                if (item.ContainsKey("originimgurl"))
                {
                    imageUrl = item["originimgurl"].ToString();
                }
                else
                {
                    imageUrl = "http://api.visitkorea.or.kr/static/images/common/noImage.gif";
                }

                WebRequest req = WebRequest.Create(imageUrl);
                WebResponse resp = req.GetResponse();

                stream = resp.GetResponseStream();
                Image img = Image.FromStream(stream);
                imgList.Images.Add(img);
                
            }
            pboxMain.Image = imgList.Images[0];
            pboxSide1.Image = imgList.Images[0];
            pboxSide2.Image = imgList.Images[1];
            pboxSide3.Image = imgList.Images[2];
            pboxSide4.Image = imgList.Images[3];
        }

        private void pboxSide1_Click(object sender, EventArgs e)
        {
            pboxMain.Image = pboxSide1.Image;
        }

        private void pboxSide2_Click(object sender, EventArgs e)
        {
            pboxMain.Image = pboxSide2.Image;
        }

        private void pboxSide3_Click(object sender, EventArgs e)
        {
            pboxMain.Image = pboxSide3.Image;
        }

        private void pboxSide4_Click(object sender, EventArgs e)
        {
            pboxMain.Image = pboxSide4.Image;
        }
        
    }
}
