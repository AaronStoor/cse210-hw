using System;
using System.Threading;

public abstract class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void SetDuration()
    {
        Console.WriteLine("Please enter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name}: {_description}");
        SetDuration();
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3); 
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Great job! You completed the {_name}.");
        Console.WriteLine($"You spent {_duration} seconds on this activity.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("\\");
        animationStrings.Add("-");
        animationStrings.Add("/");
        animationStrings.Add("|");
        animationStrings.Add("\\");
        animationStrings.Add("-");
        animationStrings.Add("/");

        int i = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
        Console.WriteLine();
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);

            Console.Write("\b \b");

        }
    }

    public abstract void Run();
}
