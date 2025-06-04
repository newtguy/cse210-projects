using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment a = new Assignment();
        Assignment b = new Assignment("Bob", "Social Studies");

        // Console.WriteLine(a.GetSummary());
        // Console.WriteLine(b.GetSummary());

        // MathAssignment m = new MathAssignment();
        // Console.WriteLine(m.GetSummary());
        // Console.WriteLine(m.GetHomeworkList());

        WritingAssignment w = new WritingAssignment();
        WritingAssignment s = new WritingAssignment("Sarah", "Writing", "Sarah book");
        Console.WriteLine(w.GetSummary());
        Console.WriteLine(w.GetWritingInformation());
        Console.WriteLine(s.GetWritingInformation());
    }
}