using System;
using System.Net;
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entrytext;
    public string _mood;

    public Entry(string date, string promptText, string entryText, string mood)
    {
        _date = date;
        _promptText = promptText;
        _entrytext = entryText;
        _mood = mood;
    }

    public void Display()
    {
        // Implementation for displaying the entry
    }
}

  
