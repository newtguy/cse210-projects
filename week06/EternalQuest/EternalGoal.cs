using System.Runtime.Serialization;

public class EternalGoal : Goal
{
    public EternalGoal(string goalName, string description, int points)
    : base(goalName, description, points)
    {

    }

    public override void ProgressGoal() { }

    public override bool isComplete()
    {
        return false;
    }

    public override string Parse()
    {
        return $"{GetName()},{GetDescrip()},{GetPoints()}";
    }
}