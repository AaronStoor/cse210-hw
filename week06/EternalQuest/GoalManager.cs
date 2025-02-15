using System.Runtime.Serialization.Formatters.Binary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    // Constructor
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    // Start the GoalManager session
    public void Start()
    {
        Console.WriteLine("Goal Manager started!");
    }

    // Display the player's info (score and goals)
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
        Console.WriteLine($"Total Goals: {_goals.Count}");
    }

    // List all goal names
    public void ListGoalNames()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }

        Console.WriteLine("Goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.Name);
        }
    }

    // List details of all goals
    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }

        Console.WriteLine("Goal Details:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    // Create a new goal
    public void CreateGoal()
    {
        Console.WriteLine("Enter goal name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter goal description:");
        string description = Console.ReadLine();

        Console.WriteLine("Enter goal points:");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = new Goal(name, description, points);
        _goals.Add(newGoal);

        Console.WriteLine("Goal created successfully!");
    }

    // Record an event (mark goal as completed)
    public void RecordEvent()
    {
        Console.WriteLine("Enter the name of the goal you want to complete:");
        string name = Console.ReadLine();

        Goal goalToComplete = _goals.Find(g => g.Name == name);

        if (goalToComplete != null)
        {
            goalToComplete.RecordEvent();
            _score += goalToComplete.IsComplete() ? goalToComplete.GetPoints() : 0;
            Console.WriteLine("Goal marked as complete!");
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    // Save the goals to a file using JsonSerializer
    public void SaveGoals()
    {
        try
        {
            string json = JsonSerializer.Serialize(_goals);
            File.WriteAllText("goals.json", json);
            Console.WriteLine("Goals saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    // Load goals from a file using JsonSerializer
    public void LoadGoals()
    {
        try
        {
            if (File.Exists("goals.json"))
            {
                string json = File.ReadAllText("goals.json");
                _goals = JsonSerializer.Deserialize<List<Goal>>(json);
                Console.WriteLine("Goals loaded successfully.");
            }
            else
            {
                Console.WriteLine("No saved goals found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }
}