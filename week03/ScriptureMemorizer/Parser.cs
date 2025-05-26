using System;
using System.IO;
using System.Collections.Generic;

//Parses .txt file into Reference and List<Word> objects
public class Parser
{
    private Reference _refer;
    private List<Word> _words;

    public Parser()
    {
        this._words = new List<Word>();
        this._refer = new Reference();
    }

    public Reference GetReference()
    {
        return this._refer;
    }

    public List<Word> GetWords()
    {
        return this._words;
    }

    public void LoadFromFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine($"File '{fileName}' not found.");
            return;
        }

        string[] lines = File.ReadAllLines(fileName);
        if (lines.Length == 0)
        {
            Console.WriteLine("Empty file. Unable to add scripture.");
            return;
        }

        // First line: parse scripture reference
        string[] referStr = lines[0].Split(new char[] { ' ', ':', '-' },
            StringSplitOptions.RemoveEmptyEntries);

        if (referStr.Length < 4)
        {
            Console.WriteLine("Invalid reference format.");
            return;
        }

        this._refer = new Reference(referStr[0], referStr[1], referStr[2], referStr[3]);

        // Verses
        for (int i = 1; i < lines.Length; i++)
        {
            string[] words = lines[i].Split(new char[] { ' ', '\n' },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                Word newWord = new Word(word);
                this._words.Add(newWord);
            }
        }
    }
}