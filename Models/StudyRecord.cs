namespace Learning_Tracker.Models
{
    public class StudyRecord
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Subject { get; set; }

        public string Content { get; set; }

        public int StudyTime { get; set; }   // 分钟

        public DateTime StudyDate { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
