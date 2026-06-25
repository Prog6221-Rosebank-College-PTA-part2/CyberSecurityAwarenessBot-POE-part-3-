using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatbotApp_
{
    public class Chatbot
    {      // Private field to store the current user
        private readonly User _user;

        // Private field to store the current user
        public Chatbot(User user)
        {
            _user = user; 
        }

        public void Start()
        {
            ChatbotUI.DisplayDivider();
            ChatbotUI.DisplaySectionHeader("Welcome");
            ChatbotUI.DisplayBotMessage(
                $"Hello, {_user.Name}! Welcome to the Cybersecurity Awareness Bot.\n" +
                "  I'm here to help you stay safe online. Type 'help' to see what I can do,\n" +
                "  or 'exit' to quit.");
            ChatbotUI.DisplayDivider();

            while (true)
            {
                ChatbotUI.DisplayUserPrompt(_user.Name);
                string? input = Console.ReadLine();

                // Input validation
                if (string.IsNullOrWhiteSpace(input))
                {
                    ChatbotUI.DisplayBotMessage("It seems you didn't type anything. Please enter a question or type 'help'.");
                    continue;
                }

                if (input.Trim().ToLower() == "exit")
                {
                    ChatbotUI.DisplayDivider();
                    ChatbotUI.DisplayBotMessage($"Goodbye, {_user.Name}! Stay safe online. 🔒");
                    ChatbotUI.DisplayDivider();
                    break;
                }

                string response = ResponseEngine.GetResponse(input);
                ChatbotUI.DisplayBotMessage(response);
                ChatbotUI.DisplayDivider();
            }
        }
    }
}
