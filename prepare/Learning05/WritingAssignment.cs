public class WritingAssignment : Assignment
{
    // Private member variable specific to WritingAssignment
    private string _title;

    // Constructor that calls the base class constructor
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    // Method to get writing information
    public string GetWritingInformation()
    {
        // Access the base class method to get the student name
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}
