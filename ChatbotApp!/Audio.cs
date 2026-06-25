using System;
using System.IO;
using System.Media;

namespace Sound
{
    public static class Audio
    {
        public static void PlayGreeting(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    using SoundPlayer player = new SoundPlayer(filePath);
                    player.PlaySync();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(
                        $"Audio file '{filePath}' was not found.");
                    Console.ResetColor();
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(
                    $"Error playing audio: {ex.Message}");
                Console.ResetColor();
            }
        }
    }
}


