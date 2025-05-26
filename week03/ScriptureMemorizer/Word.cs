// Keeps track of a single _word and whether it is shown or hidden.

public class Word
{
    private string _word;
    private bool _isHidden;

    public Word()
    {
        this._isHidden = false;
    }

    public Word(string word)
    {
        this._word = word;
        this._isHidden = false;
    }

    public void SetWord(string word)
    {
        this._word = word;
    }

    public string GetWord()
    {
        return this._word;
    }

    public bool IsHidden()
    {
        return this._isHidden;
    }

    public void HideWord()
    {
        int wordLength = this._word.Length;
        string underlineWord = new string('_', wordLength);
        this._word = underlineWord;
        this._isHidden = true;
    }
}