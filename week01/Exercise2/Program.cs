using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.WriteLine("What is your grade percentage?");
        string input = Console.ReadLine();
        float grade = float.Parse(input);

        string letterGrade;
        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else if (grade < 60)
        {
            letterGrade = "F";
        }
        else
        {
            letterGrade = "Somethin ain't right.";
        }

        if (grade % 10 < 3)
        {
            if (!(letterGrade == "F"))
            {
                letterGrade += "-";
            }
        }
        else if (grade % 10 >= 7)
        {
            if (!(letterGrade == "A" || letterGrade == "F"))
            {
                letterGrade += "+";
            }
        }

        Console.WriteLine($"Grade: {letterGrade}");
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations on your passing grade!");
        }
        else
        {
            Console.WriteLine("Let's get that grade up!");
        }
    }
}