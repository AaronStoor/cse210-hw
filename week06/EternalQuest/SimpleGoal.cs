public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public void RecordEvent()
    {
        _isComplete = true;
    }

    public bool IsComplete()
    {
        return _isComplete;
    }

    public string GetStringRepresentation()
    {
        return $"{Name} - ({GetDetailsString()}) - Completed: {_isComplete}";
    }
}