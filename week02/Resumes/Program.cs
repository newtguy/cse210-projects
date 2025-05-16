using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        job1._company = "Boeing";
        job1._jobTitle = "Aircraft Mechanic";
        job1._startYear = 2000;
        job1._endYear = 2005;

        Job job2 = new Job();
        job2._company = "Walmart";
        job2._jobTitle = "Manager";
        job2._startYear = 2006;
        job2._endYear = 2011;

        // job1.DisplayJobDetails();
        // job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._jobs = new List<Job>();

        myResume._name = "Bob";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResumeDetails();
    }
}