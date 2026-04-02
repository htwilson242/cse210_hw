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
            Console.WriteLine("");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
}    