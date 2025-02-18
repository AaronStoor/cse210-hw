public class Cycling : Activity
{
    private double _speed; // Speed in mph

    public Cycling(DateTime date, int durationMinutes, double speed) : base(date, durationMinutes)
    {
        this._speed = speed;
    }

    // Calculate Distance for Cycling (distance = speed * time)
    public override double GetDistance()
    {
        return (_speed * base.DurationMinutes) / 60; // Distance = speed * time in hours
    }

    // Calculate Speed in mph (stored directly)
    public override double GetSpeed()
    {
        return _speed;
    }

    // Calculate Pace (minutes per mile)
    public override double GetPace()
    {
        return 60 / _speed;
    }
}