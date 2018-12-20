using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlan
{
    class Planner
    {
        private int num;
        private int day;
        private string name;
        private float mapX;
        private float mapY;
        private string loc;
        private string tel;
        private string image;

        public Planner()
        {
        }

        public Planner(string name, float mapX, float mapY, string loc, string tel, string image)
        {
            this.name = name;
            this.mapX = mapX;
            this.mapY = mapY;
            this.loc = loc;
            this.tel = tel;
            this.image = image;
        }

        public Planner(int num, int day, string name, float mapX, float mapY, string loc, string tel, string image) : this(name, mapX, mapY, loc, tel, image)
        {
            this.num = num;
            this.Day = day;

        }

        public int Num { get => num; }
        public int Day { get => day; set => day = value; }
        public string Name { get => name; set => name = value; }
        public float MapX { get => mapX; set => mapX = value; }
        public float MapY { get => mapY; set => mapY = value; }
        public string Loc { get => loc; set => loc = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Image { get => image; set => image = value; }
    }
}