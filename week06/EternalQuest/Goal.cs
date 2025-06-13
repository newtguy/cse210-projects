public abstract class Goal
{
    private string _goalName;
    private string _description;
    private int _points;

    public Goal(string goalName, string description, int points)
    {
        this._goalName = goalName;
        this._description = description;
        this._points = points;
    }

    public string GetName() { return this._goalName; }
    public string GetDescrip() { return this._description; }
    public int GetPoints() { return this._points; }

    public abstract void ProgressGoal();
    public abstract bool isComplete();
    public virtual string GetSummary()
    {
        string concat = "";

        if (isComplete()) { concat += "[✓]"; }
        else { concat += "[ ]"; }

        concat += $" {this._goalName} ({this._description})";
        return concat;
    }
    public abstract string Parse();

}