using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
