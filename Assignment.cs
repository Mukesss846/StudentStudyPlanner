using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StudentStudyPlanner
{
    public class Assignment : PlannerItem
    {

        public string Title { get; set; } = "";


        public DateTime DueDate { get; set; }

        public string Priority { get; set; } = "";

        public string Status { get; set; } = "Pending";
        public override string GetSummary()
        {
            {
                return $"[Assignment] {Title}, due {DueDate:dd MMM} ({Priority}, {Status})";
            }
        }
    }
}

            

          
    

    

