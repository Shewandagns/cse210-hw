public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            Console.WriteLine($"You have completed the goal! You gained {_points} points.");
        }
        else
        {
            Console.WriteLine("This goal is already completed.");
        }
    }

    public override void DisplayGoal()
    {
        string status = _isCompleted ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {_goalName}: {_description}");
    }
}
