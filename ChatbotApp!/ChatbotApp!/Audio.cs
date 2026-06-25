using ChatbotApp_;
using System;
using System.Media;
namespace Sound
{
   


    class Audio
    {
        public static void PlayGreeting(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    using var player = new SoundPlayer("Greetings.wav");
                    player.PlaySync();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"  [Audio file '{filePath}' not found. Skipping voice greeting.]");
                    Console.ResetColor();
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"  [Could not play audio: {ex.Message}]");
                Console.ResetColor();
            }
        }
    }
}

