public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _currentCompletions;
    private int _requiredCompletions;

    public ChecklistGoal(string goalName, string description, int points, int currentCompletions, int requiredCompletions)
    : base(goalName, description, points)
    {
        this._bonusPoints = points * 10;
        this._currentCompletions = currentCompletions;
        this._requiredCompletions = requiredCompletions;
    }

    public int GetBonusPoints() { return this._bonusPoints; }

    public override bool isComplete()
    {
        if (this._currentCompletions >= this._requiredCompletions)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool isWorthyOfBonusPoints()
    {
        if (this._currentCompletions == this._requiredCompletions)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override void ProgressGoal()
    {
        this._currentCompletions++;
    }

    public override string GetSummary()
    {
        string concat = "";

        if (isComplete()) { concat += "[✓]"; }
        else { concat += "[ ]"; }

        concat += $" {GetName()} ({GetDescrip()}) -- "
        + $"Currently completed: {this._currentCompletions}/{this._requiredCompletions}";
        return concat;
    }

    public override string Parse()
    {
        return $"{GetName()},{GetDescrip()},{GetPoints()}" +
        $",{this._currentCompletions},{this._requiredCompletions}";
    }
}