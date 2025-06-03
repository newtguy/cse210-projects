public class Video
{
    private string _title;
    private string _author;
    private int _videoLength;
    private List<Comment> _comments;
    public Video(string title, string author, int length)
    {
        this._title = title;
        this._author = author;
        this._videoLength = length;
        this._comments = new List<Comment>();
    }

    private string GetTitle()
    {
        return this._title;
    }

    private string GetAuthor()
    {
        return this._author;
    }

    private int GetLength()
    {
        return this._videoLength;
    }

    private void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }

    public void AddComment(Comment comment)
    {
        this._comments.Add(comment);
    }

    public void AddThreeComments(Comment comment1, Comment comment2, Comment comment3)
    {
        this._comments.Add(comment1);
        this._comments.Add(comment2);
        this._comments.Add(comment3);
    }

    public void DisplayAll()
    {
        Console.WriteLine($"{GetTitle()} by {GetAuthor()}");
        TimeSpan time = TimeSpan.FromSeconds(GetLength());
        string formatLength = time.ToString(@"hh\:mm\:ss");
        Console.WriteLine($"Length: {formatLength}");
        DisplayComments();
    }
}