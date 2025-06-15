public abstract class Activity
{
    private string _date;  //string representation of date
    private int _duration; //in minutes
    private string _name; // example: "Running"

    public Activity(string date, int duration, string name)
    {
        this._date = date;
        this._duration = duration;
        this._name = name;
    }

    public string GetDate() { return this._date; }
    public int GetDuration() { return this._duration; }

    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();
    public string GetSummary()
    {
        //example: 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km
        return $"{this._date} {this._name} ({this._duration} min): "
        + $"Distance {CalculateDistance():F1} km, Speed: {CalculateSpeed():F1} kph, Pace: {CalculatePace():F2} min per km";
    }
}

// Distance (km) = swimming laps * 50 / 1000
// Distance(miles) = swimming laps * 50 / 1000 * 0.62
// Speed(mph or kph) = (distance / minutes) * 60
// Pace(min per mile or min per km) = minutes / distance
// Speed = 60 / pace
// Pace = 60 / speed