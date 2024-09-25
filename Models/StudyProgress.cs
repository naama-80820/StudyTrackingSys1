using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyTrackingSys1.Models
{
    public class StudyProgress
    {
        public int ProgressID { get; set; }
        public int PlanID { get; set; }
        public int LinesStudied { get; set; }
        public DateTime DateStudied { get; set; }
    }
}
