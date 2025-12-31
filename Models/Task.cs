using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_Tracker.Models
{
    public class Task
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Title { get; set; }

        public int CategoryId { get; set; }

        public int PlanMinutes { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
