using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, List<string> prompts, List<string> questions)
        : base(name, description)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");

        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");

        ShowCountDown(5); 

        int elapsedTime = 0;

        while (elapsedTime < _duration)
        {
            string question = GetRandomQuestion();
            Console.WriteLine($"Question: {question}");

            ShowSpinner(4);  
            elapsedTime += 4;  
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
    }
}
