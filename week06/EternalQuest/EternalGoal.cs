public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {}
    
    public void RecordEvent()
    {
        Console.WriteLine($"The goal '{Name}' cannot be completed because it is eternal.");
    }

    public bool IsComplete()
    {
        return false;
    }

    public string GetStringRepresentation()
    {
        return $"{Name} - {GetDetailsString()} - Completed: Never";
    }
}