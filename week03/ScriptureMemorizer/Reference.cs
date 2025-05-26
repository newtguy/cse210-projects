// Keeps track of the book, chapter, and verse information.

public class Reference
{
    private string _book;
    private string _chapter;
    private string _verseStart;
    private string _verseEnd;


    public Reference()
    {

    }

    public Reference(string book, string chapter,
    string verseStart, string verseEnd)
    {
        this._book = book;
        this._chapter = chapter;
        this._verseStart = verseStart;
        this._verseEnd = verseEnd;
    }

    public string GetReference()
    {
        return this._book + " " + this._chapter
        + ":" + this._verseStart + "-" + this._verseEnd;
    }
}