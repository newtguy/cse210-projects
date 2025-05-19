using System.Security.Cryptography;

public class PromptGenerator
{
    private List<string> prompts = new List<string>();

    public PromptGenerator()
    {
        prompts = ["What did you eat today?",
            "Who was the most interesting person you interacted with today?",
            "What makes you feel most alive?",
            "What are three things you are grateful for today?",
            "Did you take any risks today?",
            "What happens when you are angry?",
            "The world would be a lot better if..."
            ];
    }

    public string ReturnRandomPrompt()
    {
        int i = RandomNumberGenerator.GetInt32(0, prompts.Count - 1);
        string returnedPrompt = prompts[i];
        return returnedPrompt;
    }
}