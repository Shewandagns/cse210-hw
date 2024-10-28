public class Cycling : Activity
{
    private double speed; // in mph

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return (speed * minutes) / 60; // Calculate distance based on speed and time
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60 / speed; // Pace in min per mile
    }

    public override string GetSummary()
    {
        return $"{date:dd MMM yyyy} Cycling ({minutes} min): Distance {GetDistance():0.0} miles, " +
            $"Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
