public class Comment
{
    private string _username;
    private string _message;
    public Comment(string message, string username)
    {
        this._username = username;
        this._message = message;
    }

    private string GetUsername()
    {
        return this._username;
    }

    private string GetMessage()
    {
        return this._message;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"@{GetUsername()}");
        Console.WriteLine($"{GetMessage()}");
    }
}