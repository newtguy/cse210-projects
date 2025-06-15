public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(string date, int duration, string name, double speed) : base(date, duration, name)
    {
        this._speed = speed;
    }

    public override double CalculateDistance()
    {
        return _speed * (GetDuration() / 60);
    }

    public override double CalculateSpeed()
    {
        return this._speed;
    }

    public override double CalculatePace()
    {
        return 60 / CalculateSpeed();
    }
}