using System;
using System.Collections.Generic;
using System.Text;

namespace StudentStudyPlanner
{
    public abstract class PlannerItem
    {
        public int Id { get; set; }
        public string Subject { get; set; } = "";

        public abstract string GetSummary();
    }
}