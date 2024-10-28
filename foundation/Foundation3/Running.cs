public class Running : Activity
{
    private double distance; // in miles

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return (distance / minutes) * 60; // Speed in mph
    }

    public override double GetPace()
    {
        return minutes / distance; // Pace in min per mile
    }

    public override string GetSummary()
    {
        return $"{date:dd MMM yyyy} Running ({minutes} min): Distance {GetDistance():0.0} miles, " +
            $"Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}

