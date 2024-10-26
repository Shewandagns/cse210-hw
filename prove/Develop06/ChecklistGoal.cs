public class ChecklistGoal : Goal
{
    private int _requiredCompletions;
    private int _currentCompletions;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int requiredCompletions, int bonusPoints)
        : base(name, description, points)
    {
        _requiredCompletions = requiredCompletions;
        _bonusPoints = bonusPoints;
        _currentCompletions = 0;
    }

    public override void RecordEvent()
    {
        if (_currentCompletions < _requiredCompletions)
        {
            _currentCompletions++;
            Console.WriteLine($"Progress made! Completed {_currentCompletions}/{_requiredCompletions} times.");
            Console.WriteLine($"You earned {_points} points.");
            
            if (_currentCompletions == _requiredCompletions)
            {
                _isCompleted = true;
                Console.WriteLine($"Checklist complete! Bonus {_bonusPoints} points awarded.");
            }
        }
        else
        {
            Console.WriteLine("This goal has already been fully completed.");
        }
    }

    public override void DisplayGoal()
    {
        string status = _isCompleted ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {_goalName}: {_description} (Completed {_currentCompletions}/{_requiredCompletions} times)");
    }
}
