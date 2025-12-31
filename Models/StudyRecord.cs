using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_Tracker.Models
{
    public class StudyRecord
    {
        public int Id { get; set; }

        public int TaskId { get; set; }

        public DateTime StudyDate { get; set; }

        public int ActualMinutes { get; set; }

        public string Mood { get; set; }

        public string Remark { get; set; }
    }
}
