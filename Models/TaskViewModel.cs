using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_Tracker.Models
{
    public class TaskViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public int TargetMinutes { get; set; }

        public string Status { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }

}
