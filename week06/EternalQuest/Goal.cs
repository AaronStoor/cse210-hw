using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

public class Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    private bool _isComplete;

    // Constructor
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = false; // Goal is not complete initially
    }

    // Method to record an event (complete the goal)
    public void RecordEvent()
    {
        _isComplete = true;
    }

    // Method to check if the goal is complete
    public bool IsComplete()
    {
        return _isComplete;
    }

    // Method to get the details of the goal as a string
    public string GetDetailsString()
    {
        return $"Goal: {_shortName}\nDescription: {_description}\nPoints: {_points}";
    }

    // Method to get a string representation of the goal
    public string GetStringRepresentation()
    {
        return $"{_shortName} - {_description} (Points: {_points}) - Completed: {_isComplete}";
    }

    // Property to get the name of the goal
    public string Name => _shortName;

    // Method to get the points for this goal
    public int GetPoints()
    {
        return _points;
    }
}