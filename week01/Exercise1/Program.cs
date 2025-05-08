using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.WriteLine("What is your first name?");
        string userFirstName = Console.ReadLine();

        Console.WriteLine("What is your last name?");
        string userLastName = Console.ReadLine();

        string combinedName = userFirstName + " " + userLastName;

        Console.WriteLine($"Your name is {userLastName}, {combinedName}.");
    }
}

