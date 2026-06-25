using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatbotApp_
{
   
        public class User
        {
            public string Name { get; set; } = string.Empty;

            public void GetUserName()
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n  Please enter your name: ");
                Console.ResetColor();

                string? input = Console.ReadLine();

                while (string.IsNullOrWhiteSpace(input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("  Name cannot be empty. Please try again.");
                    Console.ResetColor();
                    Console.Write("  Please enter your name: ");
                    input = Console.ReadLine();
                }

                Name = input.Trim();
            }
        }
    }

