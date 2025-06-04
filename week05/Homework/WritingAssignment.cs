public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment() : base()
    {
        this._title = "default title";
    }

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        this._title = title;
    }

    public string GetWritingInformation()
    {
        return $"{GetSummary()}\n{this._title} by {GetStudentName()}";
    }
}