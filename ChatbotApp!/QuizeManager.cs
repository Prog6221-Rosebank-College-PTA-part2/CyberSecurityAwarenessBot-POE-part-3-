using System.Collections.Generic;

namespace ChatbotApp_
{
    public static class QuizManager
    {
        public static List<QuizQuestion> Questions =
            new List<QuizQuestion>()
            {
                new QuizQuestion
                {
                    Question = "What is phishing?",
                    Answers = new[]
                    {
                        "A virus",
                        "A scam email",
                        "A firewall",
                        "A password"
                    },
                    CorrectAnswer = 1
                },

                new QuizQuestion
                {
                    Question = "Should you share your password?",
                    Answers = new[]
                    {
                        "Yes",
                        "No",
                        "Sometimes",
                        "Only with friends"
                    },
                    CorrectAnswer = 1
                },

                new QuizQuestion
                {
                    Question = "What does HTTPS indicate?",
                    Answers = new[]
                    {
                        "Secure website",
                        "Slow website",
                        "Broken website",
                        "Virus detected"
                    },
                    CorrectAnswer = 0
                },

                new QuizQuestion
                {
                    Question = "What is malware?",
                    Answers = new[]
                    {
                        "Helpful software",
                        "Security update",
                        "Malicious software",
                        "Password manager"
                    },
                    CorrectAnswer = 2
                },

                new QuizQuestion
                {
                    Question = "What does 2FA stand for?",
                    Answers = new[]
                    {
                        "Two Factor Authentication",
                        "Two File Access",
                        "Two Fast Accounts",
                        "Second Password"
                    },
                    CorrectAnswer = 0
                },

                new QuizQuestion
                {
                    Question = "Which password is strongest?",
                    Answers = new[]
                    {
                        "password123",
                        "123456",
                        "Coffee!Rainy#Day9",
                        "qwerty"
                    },
                    CorrectAnswer = 2
                },

                new QuizQuestion
                {
                    Question = "What should you do before clicking a link?",
                    Answers = new[]
                    {
                        "Click immediately",
                        "Hover over it",
                        "Ignore it",
                        "Delete browser"
                    },
                    CorrectAnswer = 1
                },

                new QuizQuestion
                {
                    Question = "What protects your computer from malware?",
                    Answers = new[]
                    {
                        "Antivirus software",
                        "Calculator",
                        "Paint",
                        "WordPad"
                    },
                    CorrectAnswer = 0
                },

                new QuizQuestion
                {
                    Question = "What should you do with software updates?",
                    Answers = new[]
                    {
                        "Ignore them",
                        "Install them",
                        "Delete them",
                        "Block them"
                    },
                    CorrectAnswer = 1
                },

                new QuizQuestion
                {
                    Question = "What is the safest action on public Wi-Fi?",
                    Answers = new[]
                    {
                        "Share passwords",
                        "Use a VPN",
                        "Disable antivirus",
                        "Download unknown files"
                    },
                    CorrectAnswer = 1
                }
            };
    }
}