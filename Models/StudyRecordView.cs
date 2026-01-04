using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_Tracker.Models
{
    public class StudyRecordView
    {
        public string TaskTitle { get; set; }
        public string CategoryName { get; set; }
        public DateTime StudyDate { get; set; }
        public int ActualMinutes { get; set; }
        public string Mood { get; set; }
    }
}
