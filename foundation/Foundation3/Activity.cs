public abstract class Activity
{
    protected DateTime date;  // Use protected to allow access in derived classes
    protected int minutes;    // Use protected so derived classes can access it

    public Activity(DateTime date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    public abstract double GetDistance(); // Abstract since each activity calculates it differently

    public abstract double GetSpeed();    // Abstract to ensure derived classes override it

    public virtual double GetPace()       // Virtual to allow customization in derived classes
    {
        double distance = GetDistance();
        return distance > 0 ? (minutes / distance) : 0; // Calculate pace safely
    }

    public virtual string GetSummary()
    {
        // General summary format, overridden if needed in derived classes
        return $"{date:dd MMM yyyy} - Duration: {minutes} min, Distance: {GetDistance():0.0} units, " +
            $"Speed: {GetSpeed():0.0} units per hour, Pace: {GetPace():0.0} min per unit";
    }
}
