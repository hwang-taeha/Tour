using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlan
{
    interface IPlanner
    {
        List<Planner> SelectPlanner();
        bool InsertPlanner(Planner p);
        bool DeletePlanner(string num);
    }
}
