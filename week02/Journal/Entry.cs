public class Entry
{
    private string date;
    private string prompt;
    private string response;

    public Entry()
    {

    }

    //Used for new entry
    public Entry(string newPrompt, string newResponse)
    {
        this.date = DateTime.Now.ToString("M/d/yyyy");
        this.prompt = newPrompt;
        this.response = newResponse;
    }

    //Used for importing entries from file
    public Entry(string newDate, string newPrompt, string newResponse)
    {
        this.date = newDate;
        this.prompt = newPrompt;
        this.response = newResponse;
    }

    // setter functions only needed if altering entry

    // private void SetDate(string newDate)
    // {
    //     this.date = newDate;
    // }
    // private void SetPrompt(string newPrompt)
    // {
    //     this.prompt = newPrompt;
    // }
    // private void SetResponse(string newResponse)
    // {
    //     this.response = newResponse;
    // }
    // public void SetEntry(string newDate, string newPrompt, string newResponse)
    // {
    //     SetDate(newDate);
    //     SetPrompt(newPrompt);
    //     SetResponse(newResponse);
    // }

    private string GetDate()
    {
        return this.date;
    }
    private string GetPrompt()
    {
        return this.prompt;
    }
    private string GetResponse()
    {
        return this.response;
    }
    public string GetEntry()
    {
        return GetDate() + "\n" + GetPrompt() + "\n" + GetResponse();
    }
}