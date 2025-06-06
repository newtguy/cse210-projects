using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Parser parser = new Parser();
        parser.LoadFromFile("scripture.txt");
        Scripture currScripture = new Scripture(parser.GetReference(), parser.GetWords());

        string menuInput = "";
        int unHiddenCount = 0;
        int toHide = 0;

        do
        {
            currScripture.DisplayScripture();
            Console.WriteLine("");
            menuInput = Console.ReadLine();

            if (menuInput != "quit")
            {
                unHiddenCount = currScripture.GetUnhiddenCount();
                toHide = Math.Min(5, unHiddenCount);
                for (int hideCounter = 0; hideCounter < toHide; hideCounter++)
                {
                    if (currScripture.IsCompletelyHidden())
                    {
                        Console.WriteLine("All Words hidden.");
                        break;
                    }
                    currScripture.HideRandomWord();
                }
            }
        } while (menuInput != "quit");

    }
}