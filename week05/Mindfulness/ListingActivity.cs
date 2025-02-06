using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity(string name, string description, List<string> prompts)
        : base(name, description)
    {
        _prompts = prompts;
    }

    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");

        ShowCountDown(5);  

        int elapsedTime = 0;
        List<string> userList = new List<string>();

        while (elapsedTime < _duration)
        {
            Console.WriteLine("Please list an item:");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                userList.Add(item);
            }

            ShowSpinner(1);  
            elapsedTime += 1;  
        }

        Console.WriteLine($"You listed {userList.Count} items.");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }
}
