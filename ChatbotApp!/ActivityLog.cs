
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChatbotApp_
{
    public static class ActivityLog
    {
        private static List<string> Logs =
            new List<string>();

        public static void AddLog(string action)
        {
            Logs.Add(
                $"{DateTime.Now:G} - {action}");
        }

        public static string ShowLog()
        {
            if (Logs.Count == 0)
            {
                return "No activity has been recorded yet.";
            }

            return string.Join(
                Environment.NewLine,
                Logs.TakeLast(10));
        }
    }
}