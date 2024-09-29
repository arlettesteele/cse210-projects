using System;
using System.Collections.Generic;
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
        if (_entries.Count == 0)
        {
            Console.WriteLine("The Journal is empty.");
        }
        else 
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
    }
    public void SaveToFile()
    {
        string fileName = ("Journal.txt");

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
        Console.WriteLine("Journal saved successfully to Journal.txt.");
    }
    public void LoadFromFile()
    {
        _entries.Clear();
        string fileName = ("Journal.txt");

        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                if (parts.Length == 3)
                {
                    string date = parts[0];
                    string prompt = parts[1];
                    string response = parts[2];

                    Entry entry = new Entry(prompt, response);
                    entry._date = date;

                    _entries.Add(entry);
                    
                }
            }
            Console.WriteLine("Journal loaded succesfully.");
        }   
    }
}
