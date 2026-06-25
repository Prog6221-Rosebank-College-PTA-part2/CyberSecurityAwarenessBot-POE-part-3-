using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatbotApp_
{
    public static class TaskManager
    {
        public static List<TaskItem> Tasks =
            new List<TaskItem>();

        public static void AddTask(
            string title,
            string description,
            DateTime reminder)
        {
            Tasks.Add(new TaskItem
            {
                Title = title,
                Description = description,
                ReminderDate = reminder,
                Completed = false
            }
            ); 
        }
            public static string ViewTasks()
        {
            if (Tasks.Count == 0)
            {
                return "No tasks available.";
            }

            string output = "";

            foreach (var task in Tasks)
            {
                output +=
                    $"Title: {task.Title}\n" +
                    $"Description: {task.Description}\n" +
                    $"Reminder: {task.ReminderDate:d}\n" +
                    $"Completed: {task.Completed}\n\n";
            }

            return output;
        }
    }
    }



