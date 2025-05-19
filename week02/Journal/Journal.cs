using System.IO;

public class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        this.entries = new List<Entry>();
    }

    public bool CheckEmpty()
    {
        if (this.entries == null) { return false; }

        bool isEmpty = !this.entries.Any();
        if (isEmpty) { return false; }
        else { return true; }
    }

    public void AddNewEntry(string newDate, string newPrompt, string newResponse)
    {
        Entry newEntry = new Entry(newDate, newPrompt, newResponse);
        this.entries.Add(newEntry);
    }



    public void PrintAllEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry.GetEntry());
            Console.WriteLine();
        }
    }

    public void SaveToFile(string fileName)
    {
        if (entries == null || !entries.Any())
        {
            Console.WriteLine("No entries to save.");
            return;
        }

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine(entry.GetEntry());
                outputFile.WriteLine();
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine($"File \'{fileName}\' not found.");
            return;
        }

        this.entries = new List<Entry>();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        if (lines.Length == 0)
        {
            Console.WriteLine("Empty file. Unable to add entries.");
            return;
        }

        for (int i = 0; i < lines.Count() / 4; i += 4)
        {
            Entry currEntry = new Entry(lines[i], lines[i + 1], lines[i + 2]);
            this.entries.Add(currEntry);
        }
    }
}