using System.Diagnostics;

namespace Model
{
    public class Task
    {
        public string titleBox { get; set; }
        public string descriptionBox { get; set; }
        public DateTime? dueDateBox { get; set; }
        public TaskStatus statusBox { get; set; }
        public PriorityLevel priorityLevelBox { get; set; }
        public string Category { get; set; }
        public List<string> Tags { get; set; }
        public List<DateTime> Reminders { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime lastModifiedDate { get; set; }

        public Task()
        {
            Tags = new List<string>();
            Reminders = new List<DateTime>();
            createdDate = DateTime.Now;
            lastModifiedDate = DateTime.Now;
        }

        public enum TaskStatus
        {
            Pending,
            InProgress,
            Completed,
            Overdue
        }

        public enum PriorityLevel
        {
            Low,
            Medium,
            High,
            Critical
        }
    }

}
