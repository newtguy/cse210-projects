public class ReflectionActivity : Activity
{
    private const string REFLECTION_NAME = "Reflection";
    private const string REFLECTION_DESCRIPTION = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n";
    private List<string> _initialPrompts;
    private List<string> _additionalQuestions;
    private HashSet<int> _usedPromptIndexes;
    private HashSet<int> _usedQuestionIndexes;

    public ReflectionActivity(string usedIndexes) : base(REFLECTION_NAME)
    {
        this._initialPrompts =
            [
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless.",
                "Think of a time when you served another.",
                "Think of a time when you picked yourself up.",
                "Think of a time when you decided to be better.",
                "Think of a time when you accomplished something meaningful to yourself."
            ];
        this._additionalQuestions =
            [
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?",
                "How might others have viewed you?",
                "What would you do differently?",
                "What preparations can you make for the next time this happens?",
                "When do you think this might happen again?",
                "How will you act the next time this happens?"
            ];
        this._usedPromptIndexes = new HashSet<int>();
        if (usedIndexes.Length > 0)
        {
            foreach (char c in usedIndexes)
            {
                //convert to int
                int index = c - '0';
                this._usedPromptIndexes.Add(index);
            }
        }
        this._usedQuestionIndexes = new HashSet<int>();
        RunReflectionActivity();
    }

    private string GetInitialPrompt()
    {
        int randomIndex;
        do
        {
            randomIndex = GetRndObject().Next(this._initialPrompts.Count);
        } while (IsUsedIndex(randomIndex, this._usedPromptIndexes));
        MarkUsed(randomIndex, this._usedPromptIndexes);
        return this._initialPrompts[randomIndex];
    }

    private bool IsUsedIndex(int index, HashSet<int> usedIndexSet)
    {
        return usedIndexSet.Contains(index);
    }

    private void MarkUsed(int index, HashSet<int> usedIndexSet)
    {
        if (usedIndexSet.Add(index))
        {
            //Console.WriteLine($"Index {index} added successfully.");
        }
        else
        {
            Console.WriteLine($"Index {index} was already used.");
        }
    }

    private string GetAdditionalQuestion()
    {
        int randomIndex;
        do
        {
            randomIndex = GetRndObject().Next(this._additionalQuestions.Count());
        } while (IsUsedIndex(randomIndex, this._usedQuestionIndexes));
        MarkUsed(randomIndex, this._usedQuestionIndexes);
        return this._additionalQuestions[randomIndex];
    }

    private void RunQuestionLoop()
    {
        Console.Write($"{GetAdditionalQuestion()}");
        CustomAnimation(10);
        Console.WriteLine();
    }

    private void RunReflectionActivity()
    {
        PlayIntro(REFLECTION_DESCRIPTION);
        Console.WriteLine($"  ---{GetInitialPrompt()}---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("You may begin in: ");
        FourSecondCountDown();

        SetCurrDate();
        SetFutureDate();
        do
        {
            RunQuestionLoop();
            SetCurrDate();
        } while (GetCurrDateObject() < GetFutureObject());

        Console.WriteLine();
        PlayEndingMessage();
    }

    public string SetPromptIndexes()
    {
        string usedIndexStr = "";
        foreach (int i in this._usedPromptIndexes)
        {
            usedIndexStr += i.ToString();
        }
        return usedIndexStr;
    }
}