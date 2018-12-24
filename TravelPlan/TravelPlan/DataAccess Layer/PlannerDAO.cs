using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlan
{
    class PlannerDAO : IPlanner
    {
        private DBConnection con;

        private static PlannerDAO pd;

        private PlannerDAO() { }

        public static PlannerDAO getInstance()
        {
            if (pd == null)
            {
                pd = new PlannerDAO();
            }
            return pd;
        }

        public List<Planner> SelectPlanner()
        {
            con = new DBConnection();
            List<Planner> lst = new List<Planner>();
            string proc = "SelectPlanner";

            DataTable dt = con.ExecuteSelect(proc);

            foreach (DataRow item in dt.Rows)
            {
                lst.Add(new Planner( Int32.Parse(item["day"].ToString()), item["name"].ToString(), Int32.Parse(item["mapx"].ToString()), Int32.Parse(item["mapy"].ToString()), item["loc"].ToString(), item["tel"].ToString(), item["image"].ToString()));
            }

            return lst;
        }

        public bool InsertPlanner(Planner p)
        {
            string proc = "InsertPlanner";
            bool result = false;
            con = new DBConnection();
            SqlParameter[] sqlParameters = new SqlParameter[7];

            sqlParameters[0] = new SqlParameter("day", p.Day);
            sqlParameters[1] = new SqlParameter("name", p.Name);
            sqlParameters[2] = new SqlParameter("mapx", p.MapX);
            sqlParameters[3] = new SqlParameter("mapy", p.MapY);
            sqlParameters[4] = new SqlParameter("loc", p.Loc);
            sqlParameters[5] = new SqlParameter("tel", p.Tel);
            sqlParameters[6] = new SqlParameter("image", p.Image);

            if (con.ExecuteInsert(proc, sqlParameters))
            {
                result = true;
            }
            return result;

        }
        
        public bool DeletePlanner(string num)
        {
            string proc = "DeletePlanner";
            bool result = false;

            con = new DBConnection();
            SqlParameter pm = new SqlParameter("num", num);

            if (con.ExecuteDelete(proc, pm))
            {
                result = true;
            }

            return result;
        }
    }
}
