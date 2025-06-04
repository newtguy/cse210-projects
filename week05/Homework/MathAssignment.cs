public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment() : base()
    {
        this._textbookSection = "default section";
        this._problems = "default problems";
    }

    public MathAssignment(string studentName, string topic, string section, string problems)
        : base(studentName, topic)
    {
        this._textbookSection = section;
        this._problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{GetSummary()}\nSection {this._textbookSection} Problems {this._problems}";
    }
}