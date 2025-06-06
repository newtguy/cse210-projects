public class BreathingActivity : Activity
{
    private const string BREATHING_NAME = "Breathing";
    private const string BREATHING_DESCRIPTION = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n";

    public BreathingActivity() : base(BREATHING_NAME)
    {
        RunBreathingActivity();
    }

    private void RunBreathCycle()
    {
        Console.Write("Breathe in... ");
        FourSecondCountDown();
        Console.Write("Hold that breath... ");
        FourSecondCountDown();
        Console.Write("Breath out... ");
        FourSecondCountDown();
        Console.Write("Hold it and relax... ");
        FourSecondCountDown();
    }

    private void RunBreathingActivity()
    {
        PlayIntro(BREATHING_DESCRIPTION);

        for (int i = 0; i < GetActivityTimeSpan(); i += 16)
        {
            //Each Cycle takes 16 seconds.
            RunBreathCycle();
            Console.WriteLine();
        }
        PlayEndingMessage();
    }
}