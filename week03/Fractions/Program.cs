using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction myFraction = new Fraction();
        Console.WriteLine(myFraction.GetFractionString());
        Console.WriteLine(myFraction.GetDecimalValue());

        myFraction.SetTop(4);
        Console.WriteLine(myFraction.GetFractionString());
        myFraction.SetBottom(3);
        Console.WriteLine(myFraction.GetFractionString());

        Fraction otherFraction = new Fraction(7);
        Console.WriteLine(otherFraction.GetFractionString());
        Fraction simpleFraction = new Fraction(5, 8);
        Console.WriteLine(simpleFraction.GetFractionString());
        Console.WriteLine(simpleFraction.GetDecimalValue());

        Console.WriteLine(simpleFraction.GetType());
        Console.WriteLine(simpleFraction.GetHashCode());
    }
}