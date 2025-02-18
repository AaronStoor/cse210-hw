public class Swimming : Activity
{
    private int _laps; // Number of laps

    public Swimming(DateTime date, int durationMinutes, int laps) : base(date, durationMinutes)
    {
        this._laps = laps;
    }

    // Calculate Distance for Swimming (in km)
    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0; // Distance in km
    }

    // Calculate Speed in km/h
    public override double GetSpeed()
    {
        return (GetDistance() / base.DurationMinutes) * 60; // Speed = distance / time * 60
    }

    // Calculate Pace in minutes per km
    public override double GetPace()
    {
        return base.DurationMinutes / GetDistance();
    }
}
