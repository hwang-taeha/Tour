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
using _181211projectTour;
using System.Web;

namespace TravelPlan
{
    public partial class TotalSearch : UserControl
    {

        string areaCode = "";

        List<Area> areaList = new List<Area>();
        List<Area> sigunguList = new List<Area>();
        List<Area> Cat1List = new List<Area>();
        List<Area> Cat2List = new List<Area>();
        List<Area> Cat3List = new List<Area>();

        public TotalSearch()
        {
            InitializeComponent();
            cmbArea.Items.Add("지역 선택");
            ParsingAreaSigungu("", cmbArea);
            ParsingCat("", "", "");

        }
        private static JObject ReceiveWebSourse(string urlString)
        {
            string s = "";
            var request = (HttpWebRequest)WebRequest.Create(urlString);
            var response = (HttpWebResponse)request.GetResponse();
            var statusCode = response.StatusCode.ToString();
            if (statusCode == "OK")
            {
                var stream = response.GetResponseStream();
                var sr = new StreamReader(stream, Encoding.UTF8);
                s = sr.ReadToEnd().Replace("<b>", "").Replace("</b>", "");
            }
            JObject jObject = JObject.Parse(s);


            return jObject;
        }

        /// <summary>
        /// 지역코드를 받아서 지역과 해당 지역에 대해 웹에서 Parsing하여 찾아내는 method
        /// </summary>
        /// <param name="areaCode">지역코드 ""일때는 지역 찾기, not null 일때는 시군구 찾기</param>
        /// <param name="combobox"></param>
        public void ParsingAreaSigungu(string areaCode, ComboBox combobox)
        {
            string areaStr = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/areaCode?serviceKey=g0bFjmq9pmCLoJqvIGHUrWi%2FemZAn7PEDenAhZEGmwaL5DwzsEL%2FNV3gTWA8auCqFN2l7DzrKCuRMMD2FeSRSg%3D%3D&numOfRows=50&pageSize=50&pageNo=1&startPage=1&MobileOS=ETC&MobileApp=AppTest&_type=json&areaCode=" + areaCode + "&_type=json";


            JObject jObject = ReceiveWebSourse(areaStr);

            JArray jArray = JArray.Parse(jObject["response"]["body"]["items"]["item"].ToString());

            if (areaCode != "")
            {
                sigunguList.Clear();
            }
            foreach (var item in jArray)
            {
                Area a = new Area();
                a.Name = item["name"].ToString();
                a.Code = item["code"].ToString();
                if (areaCode == "")
                {
                    areaList.Add(a);
                }
                else if (areaCode != "")
                {
                    sigunguList.Add(a);
                }
            }
            string[] comboName = new string[jArray.Count];
            for (int i = 0; i < jArray.Count; i++)
            {
                comboName[i] = jArray[i]["name"].ToString();
            }

            combobox.Items.AddRange(comboName);
        }
        public void ParsingCat(string cat1, string cat2, string cat3)
        {
            string catUrl = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/categoryCode?serviceKey=giAYw8bKervyOuF0mqTCfUrDqkwFOMG7qFBjOgPhuSjDDXMZ6HSNyiTZMyiO7JLZYcB6b9dlJc7nuSkZgXf9pw%3D%3D&numOfRows=10&pageSize=10&pageNo=1&startPage=1&MobileOS=ETC&MobileApp=AppTest&cat1=" + cat1 +
                "&cat2=" + cat2 +
                "&cat3=" + cat3 +
                "&_type=json";

            int i = 0;
            JObject jObject = ReceiveWebSourse(catUrl);

            if (cat1 == "" && cat2 == "" && cat3 == "")
            {
                Cat1List.Clear();
                Cat2List.Clear();
                Cat3List.Clear();
                cmbCat1.Items.Clear();
                cmbCat2.Items.Clear();
                cmbCat3.Items.Clear();
                cmbCat1.Items.Add("대분류");
                cmbCat2.Items.Add("중분류");
                cmbCat3.Items.Add("소분류");

                i = 1;
            }
            if (cat1 != "" && cat2 == "" && cat3 == "")
            {

                Cat2List.Clear();
                Cat3List.Clear();
                cmbCat2.Items.Clear();
                cmbCat3.Items.Clear();
                cmbCat2.Items.Add("중분류");
                cmbCat3.Items.Add("소분류");
                i = 2;
            }
            if (cat1 != "" && cat2 != "" && cat3 == "")
            {

                Cat3List.Clear();
                cmbCat3.Items.Clear();
                cmbCat3.Items.Add("소분류");
                i = 3;
            }
            try
            {
                JArray jArray = JArray.Parse(jObject["response"]["body"]["items"]["item"].ToString());
                foreach (var item in jArray)
                {
                    Area a = new Area();
                    a.Name = item["name"].ToString();
                    a.Code = item["code"].ToString();
                    switch (i)
                    {
                        case 1:
                            Cat1List.Add(a);
                            break;
                        case 2:
                            Cat2List.Add(a);
                            break;
                        case 3:
                            Cat3List.Add(a);
                            break;
                    }
                }
                string[] comboName = new string[jArray.Count];
                for (int j = 0; j < jArray.Count; j++)
                {
                    comboName[j] = jArray[j]["name"].ToString();
                }
                switch (i)
                {
                    case 1:
                        cmbCat1.Items.AddRange(comboName);
                        break;
                    case 2:
                        cmbCat2.Items.AddRange(comboName);
                        break;
                    case 3:
                        cmbCat3.Items.AddRange(comboName);
                        break;
                }
            }
            catch (Exception)
            {
                Area a = new Area();


                a.Name = jObject["response"]["body"]["items"]["item"]["name"].ToString();
                a.Code = jObject["response"]["body"]["items"]["item"]["code"].ToString();
                switch (i)
                {
                    case 1:
                        Cat1List.Add(a);
                        cmbCat1.Items.Add(a.Name);
                        break;
                    case 2:
                        Cat2List.Add(a);
                        cmbCat2.Items.Add(a.Name);
                        break;
                    case 3:
                        Cat3List.Add(a);
                        cmbCat3.Items.Add(a.Name);
                        break;
                }
            }


        }
        #region 검색UI


        private void rdoService_CheckedChanged(object sender, EventArgs e)
        {
            lblCat.Visible = cmbCat1.Visible = cmbCat2.Visible = cmbCat3.Visible = true;
            lblArea.Visible = cmbArea.Visible = cmbSigungu.Visible = false;
            btnSearch.Location = new Point(374, 87);
            txtSearch.Location = new Point(120, 89);
            lblSearch.Location = new Point(85, 92);
        }

        private void rdoArea_CheckedChanged(object sender, EventArgs e)
        {
            lblCat.Visible = cmbCat1.Visible = cmbCat2.Visible = cmbCat3.Visible = false;
            lblArea.Visible = cmbArea.Visible = cmbSigungu.Visible = true;
            btnSearch.Location = new Point(374, 87);
            txtSearch.Location = new Point(120, 89);
            lblSearch.Location = new Point(85, 92);
            sigunguList.Clear();
            cmbArea.Text = "지역 선택";
            cmbSigungu.Text = "시군구 선택";
        }

        private void rdoTotal_CheckedChanged(object sender, EventArgs e)
        {
            lblCat.Visible = cmbCat1.Visible = cmbCat2.Visible = cmbCat3.Visible = false;
            lblArea.Visible = cmbArea.Visible = cmbSigungu.Visible = false;

            btnSearch.Location = new Point(374, 58);
            txtSearch.Location = new Point(120, 60);
            lblSearch.Location = new Point(85, 63);
        }
        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = HttpUtility.UrlEncode(txtSearch.Text).ToUpper();

            string url = "";
            string area = "";
            string sigungu = "";
            string cat1 = "";
            string cat2 = "";
            string cat3 = "";
            string pageNo = "";
            string code = "";
            if (keyword == "")
            {
                code = "areaBasedList?";
            }
            else
            {
                code = "searchKeyword?";
            }
            #region 지역선택 시 검색
            if (rdoArea.Checked == true)
            {

                if (cmbArea.Text != "지역 선택")
                {
                    foreach (var item in areaList)
                    {
                        if (item.Name == cmbArea.Text)
                        {
                            area = item.Code + "";
                        }
                    }
                }
                if (cmbSigungu.Text != "시군구 선택")
                {
                    foreach (var item in sigunguList)
                    {
                        if (item.Name == cmbSigungu.Text)
                        {
                            sigungu = item.Code + "";
                        }
                    }
                }

            }
            #endregion

            #region 서비스분류 선택시 검색
            if (rdoService.Checked == true)
            {
                if (cmbCat1.Text != "대분류")
                {
                    foreach (var item in Cat1List)
                    {
                        if (item.Name == cmbCat1.Text)
                        {
                            cat1 = item.Code + "";
                        }
                    }
                }
                if (cmbCat2.Text != "중분류")
                {
                    foreach (var item in Cat2List)
                    {
                        if (item.Name == cmbCat2.Text)
                        {
                            cat2 = item.Code + "";
                        }
                    }
                }
                if (cmbCat3.Text != "소분류")
                {
                    foreach (var item in Cat3List)
                    {
                        if (item.Name == cmbCat3.Text)
                        {
                            cat3 = item.Code + "";
                        }
                    }
                }

            }
            #endregion


            url = "http://api.visitkorea.or.kr/openapi/service/rest/KorService/" + code + "serviceKey=" +
                "giAYw8bKervyOuF0mqTCfUrDqkwFOMG7qFBjOgPhuSjDDXMZ6HSNyiTZMyiO7JLZYcB6b9dlJc7nuSkZgXf9pw%3D%3D&keyword=" + keyword +
                "&areaCode=" + area + "&sigunguCode=" + sigungu + "&cat1=" + cat1 + "&cat2=" + cat2 + "&cat3=" + cat3 + "&listYN=Y&MobileOS=ETC&MobileApp=TourAPI3.0_Guide&arrange=A&numOfRows=10&pageNo=1&startPage=1&pageSize=10" + pageNo + "&_type=json";

            JObject jObject = ReceiveWebSourse(url);

            JArray jArray_ListViewUpload = JArray.Parse(jObject["response"]["body"]["items"]["item"].ToString());
            listView1.Clear();
            //listView1.LargeImageList.Images.Clear();
            Stream stream = Stream.Null;
            ImageList imgList = new ImageList(); ;
            foreach (var item in jArray_ListViewUpload)
            {

                var request = (HttpWebRequest)WebRequest.Create(item["firstimage"].ToString());
                var response = (HttpWebResponse)request.GetResponse();
                var statusCode = response.StatusCode.ToString();
                if (statusCode == "OK")
                {
                    stream = response.GetResponseStream();
                }
                Image i = Image.FromStream(stream);
                imgList.Images.Add(item["title"].ToString(), i);
                listView1.Items.Add(item["title"].ToString(), item["title"].ToString());
                //, float.Parse(item["mapx"].ToString()), float.Parse(item["mapy"].ToString()), item["addr1"].ToString(), item["tel"].ToString(), 
            }
            listView1.LargeImageList = imgList;





            PlanList();

        }

        private void PlanList()
        {



        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region 콤보박스 지역선택
        private void cmbArea_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbSigungu.Items.Clear();
            cmbSigungu.Items.Add("시군구 선택");
            areaCode = "";
            cmbSigungu.Text = "시군구 선택";
            if (cmbArea.Text != "지역 선택")
            {
                foreach (var item in areaList)
                {
                    if (item.Name == cmbArea.Text)
                    {
                        if (cmbArea.Text != "세종특별자치시")
                        {
                            areaCode = item.Code + "";
                            break;
                        }
                        else if (cmbArea.Text == "세종특별자치시")
                        {
                            areaCode = "";
                            cmbSigungu.Items.Add("세종특별자치시");
                            return;
                        }
                    }
                }
                ParsingAreaSigungu(areaCode, cmbSigungu);
            }
        }
        #endregion

        #region 대분류 선택
        private void cmbCat1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCat1.SelectedItem.ToString() == "대분류")
            {
                ParsingCat("", "", "");
                cmbCat1.Text = "대분류";
                cmbCat2.Text = "중분류";
                cmbCat3.Text = "소분류";
            }
            else
            {
                foreach (var item in Cat1List)
                {
                    if (item.Name == cmbCat1.SelectedItem.ToString())
                    {
                        ParsingCat(item.Code, "", "");
                        cmbCat2.Text = "중분류";
                        cmbCat3.Text = "소분류";
                        return;
                    }
                }
            }
        }
        #endregion

        #region 중분류 선택
        private void cmbCat2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCat2.SelectedItem.ToString() == "중분류")
            {

                foreach (var item in Cat1List)
                {
                    if (item.Name == cmbCat1.Text)
                    {
                        ParsingCat(item.Code, "", "");
                        cmbCat2.Text = "중분류";
                        cmbCat3.Text = "소분류";
                    }
                }
            }
            else
            {
                foreach (var item in Cat1List)
                {
                    if (item.Name == cmbCat1.SelectedItem.ToString())
                    {
                        foreach (var item1 in Cat2List)
                        {
                            if (item1.Name == cmbCat2.SelectedItem.ToString())
                            {
                                ParsingCat(item.Code, item1.Code, "");
                                cmbCat3.Text = "소분류";
                                return;
                            }
                        }
                    }
                }
            }
        }
        #endregion


    }
}
