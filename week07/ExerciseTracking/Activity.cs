public abstract class Activity
{
    // Shared attributes
    private DateTime _date;
    private int _durationMinutes; // Duration in minutes

    // Constructor
    public Activity(DateTime date, int durationMinutes)
    {
        this._date = date;
        this._durationMinutes = durationMinutes;
    }

    // Property to access the duration minutes (getter)
    public int DurationMinutes => _durationMinutes;

    // Abstract methods to be implemented by derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Get Summary - all activities will use this
    public string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_durationMinutes} min): Distance {GetDistance():0.##}, Speed: {GetSpeed():0.##}, Pace: {GetPace():0.##} min per km";
    }
}
