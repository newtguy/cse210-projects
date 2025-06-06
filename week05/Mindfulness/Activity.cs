public class Activity
{
    private string _activityName;
    private int _activityTimeSpan;
    private int _completionCounter;
    private Random rnd;
    private DateTime _currTime;
    private DateTime _futureTime;

    public Activity()
    {
        this._activityName = "DEFAULT ACTIVITY";
        this._activityTimeSpan = 0;
        this._completionCounter = 0;
        this.rnd = new Random();
    }
    public Activity(string name)
    {
        this._activityName = name;
        this._activityTimeSpan = 0;
        this._completionCounter = 0;
        this.rnd = new Random();
        Console.WriteLine(GetWelcomeMessage());
    }

    private void PromptTimeSpan()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        this._activityTimeSpan = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");
    }
    public void IncrementCompletionCounter() { this._completionCounter++; }
    public void SetCurrDate() { this._currTime = DateTime.Now; }
    public void SetFutureDate() { this._futureTime = GetCurrDateObject().AddSeconds(GetActivityTimeSpan()); }
    private string GetActivityName() { return this._activityName; }
    public int GetActivityTimeSpan() { return this._activityTimeSpan; }
    public int GetCompletionCounter() { return this._completionCounter; }
    public Random GetRndObject() { return this.rnd; }
    public DateTime GetCurrDateObject() { return this._currTime; }
    public DateTime GetFutureObject() { return this._futureTime; }

    public string GetWelcomeMessage()
    {
        return $"Welcome to the {GetActivityName()} Activity.\n";
    }

    public void PlayIntro(string description)
    {
        Console.WriteLine(description);
        PromptTimeSpan();
        GetReadyAnimation();
    }

    private string GetEndingMessage()
    {
        return $"You have completed {GetActivityTimeSpan()} seconds of the {GetActivityName()} Activity.\n";
    }

    public void PlayEndingMessage()
    {
        Console.Write("Well done! ");
        CustomAnimation(2);
        Console.WriteLine($"\n\n{GetEndingMessage()}");
        CustomAnimation(4);
    }

    public void PlayAnimationLoop()
    {
        //loop lasts one second
        int delay = 250;
        Console.Write("\\");
        CustomMillisecondTimer(delay);
        Console.Write("\b \b");
        Console.Write("|");
        CustomMillisecondTimer(delay);
        Console.Write("\b \b");
        Console.Write("/");
        CustomMillisecondTimer(delay);
        Console.Write("\b \b");
        Console.Write("-");
        CustomMillisecondTimer(delay);
        Console.Write("\b \b");
    }

    public void CustomAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
            PlayAnimationLoop();
    }

    public void GetReadyAnimation()
    {
        string beginPhrase = "Okay, let's begin...";
        foreach (char c in beginPhrase)
        {
            Console.Write(c);
            if (".,".Contains(c))
            {
                CustomMillisecondTimer(GetRndObject().Next(200, 300));
            }
            else if (c == ' ')
            {
                CustomMillisecondTimer(GetRndObject().Next(100, 200));
            }
            else
            {
                CustomMillisecondTimer(GetRndObject().Next(50, 100));
            }
        }
        Console.WriteLine("\n");
    }

    private void OneSecondTimer()
    {
        Thread.Sleep(1000);
    }

    private void CustomSecondsTimer(int seconds)
    {
        int milliseconds = seconds * 1000;
        Thread.Sleep(milliseconds);
    }

    private void CustomMillisecondTimer(int milliseconds)
    {
        Thread.Sleep(milliseconds);
    }

    public void FourSecondCountDown()
    {
        for (int i = 4; i > 0; i--)
        {
            Console.Write($"{i}...");
            OneSecondTimer();
            Console.Write("\b\b\b\b    \b\b\b\b");
        }
        Console.WriteLine();
    }
}