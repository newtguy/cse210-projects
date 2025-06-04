public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment()
    {
        this._studentName = "default name";
        this._topic = "default topic";
    }

    public Assignment(string studentName, string topic)
    {
        this._studentName = studentName;
        this._topic = topic;
    }

    public string GetStudentName() { return this._studentName; }
    private string GetTopic() { return this._topic; }

    public string GetSummary()
    {
        return $"{GetStudentName()} - {GetTopic()}";
    }
}