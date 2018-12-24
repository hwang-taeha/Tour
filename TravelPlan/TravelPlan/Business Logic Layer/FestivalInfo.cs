using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlan
{
    class FestivalInfo
    {
        private string image;
        private string title;
        private string addr1;
        private string contentid;
        private string contenttypeid;
        private string eventstartdate;
        private string eventenddate;
        private string tel;
        private float mapX;
        private float mapY;

        public FestivalInfo(string image, string title, string addr1, string contentid, string contenttypeid, string eventstartdate, string eventenddate, string tel, float mapX, float mapY)
        {
            this.image = image;
            this.title = title;
            this.addr1 = addr1;
            this.contentid = contentid;
            this.contenttypeid = contenttypeid;
            this.eventstartdate = eventstartdate;
            this.eventenddate = eventenddate;
            this.tel = tel;
            this.MapX = mapX;
            this.MapY = mapY;
        }

        public string Image { get => image; set => image = value; }
        public string Title { get => title; set => title = value; }
        public string Addr1 { get => addr1; set => addr1 = value; }
        public string Contentid { get => contentid; set => contentid = value; }
        public string Contenttypeid { get => contenttypeid; set => contenttypeid = value; }
        public string Eventstartdate { get => eventstartdate; set => eventstartdate = value; }
        public string Eventenddate { get => eventenddate; set => eventenddate = value; }
        public string Tel { get => tel; set => tel = value; }
        public float MapX { get => mapX; set => mapX = value; }
        public float MapY { get => mapY; set => mapY = value; }
    }
}
