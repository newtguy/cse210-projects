public class ListingActivity : Activity
{
    private const string LISTING_NAME = "Listing";
    private const string LISTING_DESCRIPTION = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n";
    private List<string> _prompts;
    private HashSet<int> _usedPromptIndexes;

    public ListingActivity(string usedIndexes) : base(LISTING_NAME)
    {
        this._prompts =
        [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
            "What would you like to change about your day?",
            "What goals do you want to set this month?",
            "How have you seen the Lord's hand in your life this week?",
            "Who would you like to reach out to this week?"
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
        RunListingActivity();
    }

    private string GetRandomPrompt()
    {
        int randomIndex;
        do
        {
            randomIndex = GetRndObject().Next(this._prompts.Count);
        } while (IsUsedIndex(randomIndex, this._usedPromptIndexes));
        MarkUsed(randomIndex, this._usedPromptIndexes);
        return this._prompts[randomIndex];
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


    private void RunListingActivity()
    {
        PlayIntro(LISTING_DESCRIPTION);
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"  ---{GetRandomPrompt()}---");

        SetCurrDate();
        SetFutureDate();
        int activityCounter = 0;
        do
        {
            Console.ReadLine();
            activityCounter++;
            SetCurrDate();
        } while (GetCurrDateObject() < GetFutureObject());

        Console.WriteLine($"You listed {activityCounter} items!");
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