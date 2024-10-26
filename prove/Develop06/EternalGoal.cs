public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"You have recorded progress on {_goalName} and earned {_points} points.");
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {_goalName}: {_description} (Eternal Goal)");
    }
}
