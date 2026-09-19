using System;
using System.Collections.Generic;
using System.Text;

namespace StudentStudyPlanner
{
    public class Assignment
    {
        public int Id { get; set; }

        public string Title { get; set; } = "";

        public string Subject { get; set; } = "";

        public DateTime DueDate { get; set; }

        public string Priority { get; set; } = "";

        public string Status { get; set; } = "Pending";
    }
}
    

