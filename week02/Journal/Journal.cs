using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        if (_entries.Count() > 0 )
        {
            foreach (Entry entry in _entries)
            {
                entry.DisplayEntry();
            }
        }
        else {
            Console.WriteLine("No entries currently exist.");
        }
    }
    public void SaveToFile(string filePath)
    {
        using (StreamWriter outputFile = new StreamWriter(filePath))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._dateTime},{entry._prompt},{entry._response},{entry._location}");
            }
        }
    }
    public void LoadFromFile(string filePath)
    {
        Console.WriteLine("Reading list from file...");

        string[] lines = System.IO.File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            string [] parts = line.Split(",");

            Entry newentry = new Entry();
            newentry._dateTime = parts[0];
            newentry._prompt = parts[1];
            newentry._response = parts[2];
            newentry._location = parts[3];

            AddEntry(newentry);
        }
    }
}
