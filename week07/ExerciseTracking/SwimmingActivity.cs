public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(string date, int duration, string name, int laps) : base(date, duration, name)
    {
        this._laps = laps;
    }

    public override double CalculateDistance()
    {
        return this._laps * 50 / 1000;
    }

    public override double CalculateSpeed()
    {
        return CalculateDistance() / GetDuration() * 60;
    }

    public override double CalculatePace()
    {
        return 60 / CalculateSpeed();
    }
}