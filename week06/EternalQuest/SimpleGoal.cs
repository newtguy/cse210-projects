public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string goalName, string description, int points)
    : base(goalName, description, points)
    {
        this._isComplete = false;
    }

    public SimpleGoal(string goalName, string description, int points, bool isComplete)
    : base(goalName, description, points)
    {
        this._isComplete = isComplete;
    }

    public override void ProgressGoal()
    {
        this._isComplete = true;
    }

    public override bool isComplete()
    {
        return this._isComplete;
    }

    public override string Parse()
    {
        return $"{GetName()},{GetDescrip()},{GetPoints()},{isComplete()}";
    }
}