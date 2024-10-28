public class Swimming : Activity
{
    private int laps; // number of laps

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return (laps * 50) / 1000.0; // Distance in kilometers
    }

    public override double GetSpeed()
    {
        return (GetDistance() / minutes) * 60; // Speed in kph
    }

    public override double GetPace()
    {
        return minutes / GetDistance(); // Pace in min per km
    }

    public override string GetSummary()
    {
        return $"{date:dd MMM yyyy} Swimming ({minutes} min): Distance {GetDistance():0.0} km, " +
            $"Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}
