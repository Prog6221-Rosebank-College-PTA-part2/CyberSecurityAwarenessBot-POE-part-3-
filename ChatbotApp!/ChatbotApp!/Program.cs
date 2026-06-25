using ChatbotApp_;
using Sound;
using System;
class Program
{
    static void Main(string[] args)
    {
        Audio.PlayGreeting("Greetings.wav");
        ChatbotUI.DisplayAsciiLogo();

        var user = new User();
        user.GetUserName();

        var bot = new Chatbot(user);
        bot.Start();
    }
}



