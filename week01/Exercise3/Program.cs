using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int number;
        string guess;
        int guessInt;
        int i;
        string answer = "yes";

        while (answer == "yes")
        {
            number = randomGenerator.Next(1, 50);
            guessInt = 0;
            i = 0;
            while (guessInt != number)
            {
                i++;
                Console.WriteLine("What is your guess? ");
                guess = Console.ReadLine();
                guessInt = int.Parse(guess);
                if (guessInt < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessInt > number)
                {
                    Console.WriteLine("Lower");
                }
            }

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {i} tries.");
            Console.WriteLine("Would you like to play again? yes/no: ");
            answer = Console.ReadLine();
        }
    }
}