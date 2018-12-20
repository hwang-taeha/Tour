using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlan
{
    class SearchResult
    {
        private string addr1;
        private string addr2;
        private int areacode;
        private int booktour;
        private string cat1;
        private string cat2;
        private string cat3;
        private int contentid;
        private int contenttypeid;
        private string createdtime;
        private string firstimage;
        private string firstimage2;
        private string mapx;
        private string mapy;
        private int mlevel;
        private string modifiedtime;
        private int readcount;
        private int sigungucode;
        private string tel;
        private string title;
        private int zipcode;

        public SearchResult() { }

        public SearchResult(string title, string addr1, string addr2, int areacode, int booktour, string cat1, string cat2, string cat3, int contentid, int contenttypeid, string createdtime, string firstimage, string firstimage2, string mapx, string mapy, int mlevel, string modifiedtime, int readcount, int sigungucode, string tel, int zipcode)
        {
            this.title = title;
            this.addr1 = addr1;
            this.addr2 = addr2;
            this.areacode = areacode;
            this.booktour = booktour;
            this.cat1 = cat1;
            this.cat2 = cat2;
            this.cat3 = cat3;
            this.contentid = contentid;
            this.contenttypeid = contenttypeid;
            this.createdtime = createdtime;
            this.firstimage = firstimage;
            this.firstimage2 = firstimage2;
            this.mapx = mapx;
            this.mapy = mapy;
            this.mlevel = mlevel;
            this.modifiedtime = modifiedtime;
            this.readcount = readcount;
            this.sigungucode = sigungucode;
            this.tel = tel;
            this.zipcode = zipcode;
        }

        public string Addr1 { get => addr1; set => addr1 = value; }
        public string Addr2 { get => addr2; set => addr2 = value; }
        public int Areacode { get => areacode; set => areacode = value; }
        public int Booktour { get => booktour; set => booktour = value; }
        public string Cat1 { get => cat1; set => cat1 = value; }
        public string Cat2 { get => cat2; set => cat2 = value; }
        public string Cat3 { get => cat3; set => cat3 = value; }
        public int Contentid { get => contentid; set => contentid = value; }
        public int Contenttypeid { get => contenttypeid; set => contenttypeid = value; }
        public string Createdtime { get => createdtime; set => createdtime = value; }
        public string Firstimage { get => firstimage; set => firstimage = value; }
        public string Firstimage2 { get => firstimage2; set => firstimage2 = value; }
        public string Mapx { get => mapx; set => mapx = value; }
        public string Mapy { get => mapy; set => mapy = value; }
        public int Mlevel { get => mlevel; set => mlevel = value; }
        public string Modifiedtime { get => modifiedtime; set => modifiedtime = value; }
        public int Readcount { get => readcount; set => readcount = value; }
        public int Sigungucode { get => sigungucode; set => sigungucode = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Title { get => title; set => title = value; }
        public int Zipcode { get => zipcode; set => zipcode = value; }
    }
}
