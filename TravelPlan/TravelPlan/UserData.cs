using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlan
{
    class UserData
    {
        private string addr1;

        public string Addr1
        {
            get { return addr1; }
            set { addr1 = value; }
        }

        private string firstimage;

        public string Firstimage
        {
            get { return firstimage; }
            set { firstimage = value; }
        }
        private string tel;

        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public UserData(string addr1, string firstimage, string tel, string title)
        {
            this.addr1 = addr1;
            this.firstimage = firstimage;
            this.tel = tel;
            this.title = title;
        }
        public UserData()
        {

        }
    }
}
