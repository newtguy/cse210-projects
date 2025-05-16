using System.ComponentModel;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public Job()
    {

    }

    public void DisplayJobDetails()
    {
        string concatStr = _jobTitle + " (" + _company + ") " + " "
        + _startYear.ToString() + "-" + _endYear.ToString();
        Console.WriteLine(concatStr);
    }
}