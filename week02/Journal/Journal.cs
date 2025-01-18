using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(string date, string prompt, string entryText)
    {
        _entries.Add(new Entry(date, prompt, entryText));
    }

    public void DisplayAllEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries available.");
        }
        else
        {
            foreach (var entry in _entries)
            {
                entry.Display();
            }
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
        Console.WriteLine($"Journal saved to {filename}.");
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            _entries.Clear(); 
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        _entries.Add(new Entry(parts[0], parts[1], parts[2]));
                    }
                }
            }
            Console.WriteLine("Journal loaded from file.");
        }
        else
        {
            Console.WriteLine($"File {filename} not found.");
        }
    }
}
