using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAPPInf();


            while (true)
            {

                // Set corret number
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                // Init gues var
                int guess = 0;

                Console.WriteLine("Guess a Number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();


                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");
                        continue;
                    }

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number please try again");
                    }
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Correct the number is {0}", correctNumber);
                Console.ResetColor();

                Console.WriteLine("Play Again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAPPInf()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Kevin Duong";

            // Text Color
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();

            // Prompts User for name
            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game..", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
