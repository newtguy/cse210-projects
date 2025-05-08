using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numberList = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        string input;
        int number;

        do
        {
            Console.WriteLine("Enter number: ");
            input = Console.ReadLine();
            number = int.Parse(input);
            if (number != 0)
            {
                numberList.Add(number);
            }
        }
        while (number != 0);

        int sum = numberList.Sum();
        Console.WriteLine($"The sum is: {sum}");

        double average = numberList.Average();
        Console.WriteLine($"The average is: {average}");

        int largest = numberList.Max();
        Console.WriteLine($"The largest number is: {largest}");

        numberList.Sort();
        int smallestPositive = 0;
        foreach (int i in numberList)
        {
            if (i > 0)
            {
                smallestPositive = i;
                break;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        Console.WriteLine("The sorted list is: ");
        foreach (int i in numberList)
        {
            Console.WriteLine(i);
        }

    }
}