public class Running : Activity
{
    private double _distance; // in miles

    public Running(DateTime date, int durationMinutes, double distance) : base(date, durationMinutes)
    {
        this._distance = distance;
    }

    // Calculate Distance for Running (stored directly)
    public override double GetDistance()
    {
        return _distance;
    }

    // Calculate Speed in mph
    public override double GetSpeed()
    {
        return (_distance / base.DurationMinutes) * 60; // Speed = distance / time * 60
    }

    // Calculate Pace (minutes per mile)
    public override double GetPace()
    {
        return base.DurationMinutes / _distance;
    }
}
