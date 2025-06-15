using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List<Activity> activities = new List<Activity>();
        activities.Add(new RunningActivity("03 Nov 2022", 45, "Running", 7.1));
        activities.Add(new CyclingActivity("04 Dec 2023", 90, "Cycling", 17.5));
        activities.Add(new CyclingActivity("05 Jan 2024", 25, "Swimming", 13));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}