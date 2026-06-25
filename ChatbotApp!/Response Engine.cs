using ChatbotApp_;
using System;
using System.Collections.Generic;

namespace ChatbotApp_
{
    public static class ResponseEngine
    {
        private static readonly Dictionary<string, string> _responses = new()
        {
            {
                "how are you|how are u|how r you",
                "I'm fully operational and vigilant! Always on the lookout for cyber threats. How can I help you stay safe today?"
            },

            {
                "purpose|what do you do|what can you do|why are you here",
                "My purpose is to help you stay safe online! I can teach you about password safety, phishing scams, safe browsing habits, and much more."
            },

            {
                "help|topics|what can i ask",
                "Great question! You can ask me about passwords, phishing, malware, safe browsing and cybersecurity tips."
            }
        };

        public static string GetResponse(string input)
        {
            string lowerInput = input.ToLower();

            // Show activity log command
            if (lowerInput.Contains("show activity log"))
            {
                return ActivityLog.ShowLog();
            }

            foreach (var pair in _responses)
            {
                string[] keywords = pair.Key.Split('|');

                foreach (string keyword in keywords)
                {
                    if (lowerInput.Contains(keyword))
                    {
                        return pair.Value;
                    }
                }
            }

            return "I didn't quite understand that. Could you rephrase?";
        }
    }
}