
using System;

namespace ChatbotApp_
{
    public class TaskItem
    {
        public string Title { get; set; } = "";

        public string Description { get; set; } = "";

        public DateTime ReminderDate { get; set; }

        public bool Completed { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Description} - Reminder: {ReminderDate:d}";
        }
    }
}
