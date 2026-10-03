using System;
using System.Collections.Generic;
using System.Text;

namespace StudentStudyPlanner
{
    public class StudySession : PlannerItem
    {
        public DateTime Date { get; set; }

        public TimeSpan StartTime { get; set; }

        private int duration;

        public int Duration
        {
            get { return duration; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Duration must be more than 0 minutes.");
                duration = value;
            }
        }

        public string Notes { get; set; } = "";

        public override string GetSummary()
        {
            string time = StartTime.ToString(@"hh\:mm");
            return $"[Study] {Subject}, {Date:dd MMM} {time}, {Duration} min";
        }
    }
}
