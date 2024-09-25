using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyTrackingSys1.Models
{

    public class StudyPlan
    {
        public int PlanID { get; set; }
        public int UserID { get; set; }
        public int MasechetID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string DaysOfWeek { get; set; }
    }
}
