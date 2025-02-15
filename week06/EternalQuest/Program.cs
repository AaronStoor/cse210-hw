using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Goal Manager!");
            Console.WriteLine("1. List Goal Names");
            Console.WriteLine("2. List Goal Details");
            Console.WriteLine("3. Create a New Goal");
            Console.WriteLine("4. Record an Event");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Display Player Info");
            Console.WriteLine("8. Exit");
            Console.Write("Please select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    goalManager.ListGoalNames();
                    break;
                case "2":
                    goalManager.ListGoalDetails();
                    break;
                case "3":
                    goalManager.CreateGoal();
                    break;
                case "4":
                    goalManager.RecordEvent();
                    break;
                case "5":
                    goalManager.SaveGoals();
                    break;
                case "6":
                    goalManager.LoadGoals();
                    break;
                case "7":
                    goalManager.DisplayPlayerInfo();
                    break;
                case "8":
                    Console.WriteLine("Exiting...");
                    return; // Exit the program
                default:
                    Console.WriteLine("Invalid selection, please try again.");
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}