public class MathAssignment : Assignment
{
    // Private member variable specific to MathAssignment
    private string _textbookSection;
    private string _problems;

    // Constructor that calls the base class constructor
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Method to get homework list
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
