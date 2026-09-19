using System;
using System.Collections.Generic;
using System.Text;

namespace StudentStudyPlanner
{
    public class StudySession
    {
        public int Id { get; set; }

        public string Subject { get; set; } = "";

        public DateTime Date { get; set; }

        public TimeSpan StartTime { get; set; }

        public int Duration { get; set; }

        public string Notes { get; set; } = "";
    }
}
