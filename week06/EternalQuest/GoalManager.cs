using System.IO;

public class GoalManager
{
    const string FILE_NAME = "goals.txt";
    private int _score;
    private List<Goal> _goals;

    public GoalManager()
    {
        this._score = 0;
        this._goals = new List<Goal>();
        Run();
    }

    private void Run()
    {
        int userInput = 0;
        while (userInput != 6)
        {
            userInput = PromptMenuOptions();

            switch (userInput)
            {
                case 1:
                    CreateNewGoal();
                    break;
                case 2:
                    DisplayGoals();
                    break;
                case 3:
                    SaveToFile(FILE_NAME);
                    break;
                case 4:
                    LoadFromFile(FILE_NAME);
                    break;
                case 5:
                    ProgressOneGoal();
                    break;
            }
        }
        Console.WriteLine("Come back soon!");
    }

    private int PromptMenuOptions()
    {
        int userInput = 0;
        while (userInput < 1 || userInput > 6)
        {
            Console.WriteLine($"You have {this._score} points!\n");
            Console.WriteLine("Menu Options\n  1.Create New Goal\n"
                + "  2.List Goals\n  3.Save Goals\n  4.Load Goals\n"
                + "  5.Progress Your Goal\n  6.Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        return userInput;
    }

    private void CreateNewGoal()
    {
        int goalSelection = PromptGoalOptions();
        this._goals.Add(PromptGoalDetails(goalSelection));
    }

    private int PromptGoalOptions()
    {
        int userInput = 0;
        while (userInput < 1 || userInput > 3)
        {
            Console.WriteLine("Which Goal would you like to create?\n"
                + "  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal");
            Console.Write("Select a choice from the menu: ");
            userInput = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        return userInput;
    }

    private Goal PromptGoalDetails(int goalSelection)
    {
        Console.WriteLine("What is the name of your goal?");
        string name = Console.ReadLine();
        Console.WriteLine("What is the description of your goal?");
        string description = Console.ReadLine();
        Console.WriteLine("What is the point value of your goal?");
        int points = int.Parse(Console.ReadLine());

        if (goalSelection == 1)
        {
            return new SimpleGoal(name, description, points);
        }
        else if (goalSelection == 2)
        {
            return new EternalGoal(name, description, points);
        }
        else
        {
            Console.WriteLine("How many completions are needed for bonus points?");
            int requiredCompletions = int.Parse(Console.ReadLine());
            return new ChecklistGoal(name, description, points, 0, requiredCompletions);
        }
    }

    private void DisplayGoals()
    {
        foreach (Goal goal in this._goals)
        {
            Console.WriteLine(goal.GetSummary());
        }
        Console.WriteLine();
    }

    private void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(this._score);
            foreach (Goal goal in this._goals)
            {
                outputFile.WriteLine(goal.Parse());
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine($"File '{fileName}' not found.");
            return;
        }

        string[] lines = File.ReadAllLines(fileName);
        if (lines.Length == 0)
        {
            Console.WriteLine("Empty file. Unable to add goal.");
            return;
        }

        //first line contains score
        this._score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] lineArgs = lines[i].Split(new char[] { ',' });
            if (lineArgs.Length < 3 || lineArgs.Length > 5)
            {
                Console.WriteLine("Invalid 'serialization' (too many arguments per line)");
                return;
            }
            else if (lineArgs.Length == 3)
            {
                //Eternal Goal
                this._goals.Add(new EternalGoal(lineArgs[0], lineArgs[1], int.Parse(lineArgs[2])));
            }
            else if (lineArgs.Length == 4)
            {
                //Simple Goal
                this._goals.Add(new SimpleGoal(lineArgs[0], lineArgs[1], int.Parse(lineArgs[2]), bool.Parse(lineArgs[3])));
            }
            else
            {
                //Checklist Goal
                this._goals.Add(new ChecklistGoal(lineArgs[0], lineArgs[1], int.Parse(lineArgs[2]), int.Parse(lineArgs[3]), int.Parse(lineArgs[4])));
            }
        }
    }

    private void ProgressOneGoal()
    {
        int goalIndex = PromptNameSelection();
        this._goals[goalIndex].ProgressGoal();
        this._score += this._goals[goalIndex].GetPoints();
        if (this._goals[goalIndex] is ChecklistGoal checklist)
        {
            if (checklist.isWorthyOfBonusPoints())
            {
                this._score += checklist.GetBonusPoints();
                Console.WriteLine($"You just earned {checklist.GetBonusPoints()} bonus points!!!");
            }
        }
        Console.WriteLine("Congratulations!\n");
    }

    private int PromptNameSelection()
    {
        Console.WriteLine("The Goals are: ");
        for (int i = 0; i < this._goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}: {this._goals[i].GetName()}");
        }
        Console.Write("Which goal did you complete? ");
        int goalIndexCompleted = int.Parse(Console.ReadLine()) - 1;
        return goalIndexCompleted;
    }
}