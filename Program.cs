using System;
using Newtonsoft.Json;

namespace howtodenmark
{
    class Program
    {
        private static string Menu()
        {
            while (true)
            {
                Console.WriteLine($"[1] play{Environment.NewLine}" +
                    $"[2] add a word{Environment.NewLine}" +
                    $"[3] delete a word{Environment.NewLine}" +
                    $"[4] open word database{Environment.NewLine}" +
                    $"[5] leave");
                string UserChoice = Console.ReadLine();
                switch (UserChoice)
                {
                    case "1":
                        Console.Clear();
                        return "playing";
                    case "2":
                        Console.Clear();
                        return "adding";
                    case "3":
                        Console.Clear();
                        return "deleting";
                    case "4":
                        Console.Clear();
                        return "database";
                    case "5":
                        Console.Clear();
                        return "leaving";
                    default:
                        Console.Clear();
                        Console.WriteLine("wrong input");
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            string IsITTheFirstTime = Initialization.FileCheck(); //checks whether the requied files exists, if not creates them, determines how to greet the user

            if (IsITTheFirstTime == "executing the code for the first time")
            {
                User.FirstGreetings();
            }
            else if (IsITTheFirstTime == "reexecuting the code")
            {
                User.Greetings();
            }

            while (true)
            {
                string menuChoice = Menu(); //asks what the user wants to do
                if (menuChoice == "playing")
                {
                    Console.WriteLine("playing...");
                }
                else if (menuChoice == "adding")
                {
                    break;
                }
                else if (menuChoice == "deleting")
                {
                    break;
                }
                else if (menuChoice == "database")
                {
                    break;
                }
                else if (menuChoice == "leaving")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("error");
                    break;
                }
            }
        }
    }
}
