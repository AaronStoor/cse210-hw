using System;
using System.IO;

public class Entry
{
    public string _date { get; set; }
    public string _promptText { get; set; }
    public string _entryText { get; set; }

    public Entry(string date, string prompt, string entryText)
    {
        date = _date;
        prompt = _promptText;
        entryText = _entryText;
    }
    
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }
}