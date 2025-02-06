using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description)
        : base(name, description) { }

    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        ShowCountDown(5); 

        int elapsedTime = 0;

        while (elapsedTime < _duration)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(4); 

            Console.WriteLine("Breathe out...");
            ShowSpinner(4); 

            elapsedTime += 8;  
        }

        DisplayEndingMessage();
    }
}
