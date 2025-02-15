public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Console.WriteLine($"Event recorded! {_amountCompleted} out of {_target} completed.");
        }
        else
        {
            Console.WriteLine("Target already reached, no more events can be recorded");
        }
    }

    public bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public string GetDetailsString()
    {
        return $"{base.GetDetailsString()}\nTarget: {_target}\nCompleted: {_amountCompleted}/{_target} - Bonus: {_bonus} points if completed.";
    }

    public string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()} - Target: {_target}, Completed: {_amountCompleted}.{_target} - Bonus: {_bonus} points";
    }

    public int GetTotalPoints()
    {
        return IsComplete() ? GetPoints() + _bonus : GetPoints();
    }
}