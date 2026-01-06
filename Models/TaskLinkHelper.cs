using System;

namespace Learning_Tracker.Models
{
    internal static class TaskLinkHelper
    {
        private const string Separator = " | ";

        public static string BuildSubject(int taskId, string taskTitle, string? originalSubject)
        {
            string left = $"#{taskId} {taskTitle}";
            if (string.IsNullOrWhiteSpace(originalSubject))
                return left;

            return left + Separator + originalSubject.Trim();
        }

        public static bool TryParseTaskId(string? subject, out int taskId)
        {
            taskId = 0;
            if (string.IsNullOrWhiteSpace(subject))
                return false;

            subject = subject.Trim();
            if (!subject.StartsWith('#'))
                return false;

            int spaceIndex = subject.IndexOf(' ');
            if (spaceIndex <= 1)
                return false;

            string idPart = subject.Substring(1, spaceIndex - 1);
            return int.TryParse(idPart, out taskId);
        }

        public static string ExtractOriginalSubject(string? subject)
        {
            if (string.IsNullOrWhiteSpace(subject))
                return string.Empty;

            int idx = subject.IndexOf(Separator, StringComparison.Ordinal);
            if (idx < 0)
                return string.Empty;

            return subject[(idx + Separator.Length)..].Trim();
        }
    }
}
