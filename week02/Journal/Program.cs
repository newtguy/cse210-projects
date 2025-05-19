using System;

//I exceeded core requirements by implementing 
//constructors to populate Entry and Journal attributes.

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Journal Project.");
        PromptGenerator promptGenerator = new PromptGenerator();
        string prompt = "";
        string response = "";
        Journal journal = new Journal();

        int menuChoice;
        do
        {
            PrintMenuOptions();
            menuChoice = int.Parse(Console.ReadLine());
            switch (menuChoice)
            {
                case 1:
                    //Add new Entry
                    string date = DateTime.Now.ToString("M/d/yyyy");
                    prompt = promptGenerator.ReturnRandomPrompt();
                    Console.WriteLine(prompt);
                    response = Console.ReadLine();
                    journal.AddNewEntry(date, prompt, response);
                    break;
                case 2:
                    //Display Journal
                    //Check !empty
                    if (journal.CheckEmpty())
                    { journal.PrintAllEntries(); }
                    else
                    { Console.WriteLine(); }
                    break;
                case 3:
                    //Save journal to file
                    Console.WriteLine("What is the file name you want to save to?");
                    string saveFile = "";
                    saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;
                case 4:
                    //Load journal from file
                    Console.WriteLine("What is the file name you want to load from?");
                    string loadFile = "";
                    loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;
                case 5:
                    //Exit
                    Console.WriteLine("Goodbye!");
                    break;
            }
        } while (menuChoice != 5);

    }

    static void PrintMenuOptions()
    {
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quit");
    }

}