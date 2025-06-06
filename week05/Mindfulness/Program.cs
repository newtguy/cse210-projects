using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Mindfulness Project.");
        //Create Activity Objects

        int menuInput;
        string usedReflectionIndexes = "";
        string usedListingIndexes = "";
        do
        {
            Console.WriteLine("1. Start breathing Activity\n2. Start Reflecting Activity\n3. Start Listing Activity\n4. Quit");
            menuInput = int.Parse(Console.ReadLine());

            switch (menuInput)
            {
                case < 1:
                case > 4:
                    Console.WriteLine("Please answer with 1-4.");
                    break;
                case 1:
                    BreathingActivity breath = new BreathingActivity();
                    break;
                case 2:
                    ReflectionActivity reflect = new ReflectionActivity(usedReflectionIndexes);
                    usedReflectionIndexes = reflect.SetPromptIndexes();
                    break;
                case 3:
                    ListingActivity list = new ListingActivity(usedListingIndexes);
                    usedListingIndexes = list.SetPromptIndexes();
                    break;
            }
        } while (menuInput != 4);
    }
}