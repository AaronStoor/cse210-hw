using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> listingPrompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?"
        };

        List<string> reflectionPrompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you helped someone in need."
        };

        List<string> reflectionQuestions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "How did you feel when it was complete?"
        };

        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "A relaxation activity to focus on your breathing.");
        ListingActivity listingActivity = new ListingActivity("Listing Activity", "A listing exercise to reflect on the good things in your life", listingPrompts);
        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "A reflection activity to help you recognize your strength.", reflectionPrompts, reflectionQuestions);

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Activity Program!");
            Console.WriteLine("Please choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    breathingActivity.Run();
                    break;
                case "2":
                    listingActivity.Run();
                    break;
                case "3":
                    reflectingActivity.Run();
                    break;
                case "4":
                    Console.WriteLine("Thank you for using the Activity Program!");
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }

            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
        }
    }
}
