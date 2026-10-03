using System;
using System.Collections.Generic;
using System.Text;

namespace StudentStudyPlanner
{
    public class StudySession : PlannerItem
    {


        public DateTime Date { get; set; }

        public TimeSpan StartTime { get; set; }

        public int Duration { get; set; }

        public string Notes { get; set; } = "";
        public override string GetSummary()
        {
            string time = StartTime.ToString(@"hh\:mm");
            return $"[Study] {Subject}, {Date:dd MMM} {time}, {Duration} min";


        }
    }
}
