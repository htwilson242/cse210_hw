using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "Who did I talk to the most today?",
        "What was my favorite thing that I ate today?",
        "How was I able to help another person today?",
        "How did someone else help me today?",
        "What did the Lord do for me today?",
        "How did I come closer to the Lord today?",
        "What did I learn from my scripture study today?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}