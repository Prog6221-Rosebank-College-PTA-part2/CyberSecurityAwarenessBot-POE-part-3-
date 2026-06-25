
using System;
using System.Windows.Forms;
using Sound;

namespace ChatbotApp_
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Audio.PlayGreeting("Greetings.wav");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new MainForm());
        }
    }
}



