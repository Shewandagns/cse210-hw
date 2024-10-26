public abstract class Goal
{
    protected string _goalName;
    protected string _description;
    protected int _points;
    protected bool _isCompleted;

    public Goal(string name, string description, int points)
    {
        _goalName = name;
        _description = description;
        _points = points;
        _isCompleted = false;
    }

    public virtual void DisplayGoal()
    {
        Console.WriteLine($"{_goalName}: {_description}");
    }

    public abstract void RecordEvent(); // This will be overridden in derived classes
    public int GetPoints() => _points;
    public bool IsComplete() => _isCompleted;
}
