// Keeps track of both the reference and the text of the scripture. 
// Can hide words and get the rendered display of the text.

using System.Dynamic;

public class Scripture
{
    private Reference _refer;
    private List<Word> _words;
    private Random _rnd;

    public Scripture()
    {
        this._refer = new Reference();
        this._words = new List<Word>();
        this._rnd = new Random();
    }

    public Scripture(Reference reference, List<Word> words)
    {
        this._refer = reference;
        this._words = words;
        this._rnd = new Random();
    }

    public void DisplayScripture()
    {
        Console.Write(this._refer.GetReference() + " ");
        foreach (Word word in this._words)
        {
            Console.Write(word.GetWord() + " ");
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in this._words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public void HideRandomWord()
    {
        while (true)
        {
            int index = _rnd.Next(0, _words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].HideWord();
                return;
            }
        }
    }

    public int GetUnhiddenCount()
    {
        return this._words.Count(w => !w.IsHidden());
    }

}