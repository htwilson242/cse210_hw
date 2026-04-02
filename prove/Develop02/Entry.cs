using System;
using System.Net;
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entrytext;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entrytext}");
        Console.WriteLine();    
    }

    public string ToFileString()
    {
        return $"{_date}|{_promptText}|{_entrytext}";
    }
}


  
