public class RunningActivity : Activity
{
    private double _distance; //km

    public RunningActivity(string date, int duration, string name, double distance) : base(date, duration, name)
    {
        this._distance = distance;
    }

    public override double CalculateDistance()
    {
        return this._distance;
    }

    public override double CalculateSpeed()
    {
        return this._distance / GetDuration() * 60;
    }

    public override double CalculatePace()
    {
        return 60 / CalculateSpeed();
    }

}
