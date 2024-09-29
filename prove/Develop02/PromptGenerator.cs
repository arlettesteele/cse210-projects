using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts;
    public PromptGenerator()
    {
        _prompts = new List<string>();
        _prompts.Add("What did I learn today? ");
        _prompts.Add("What is something I am grateful for today? ");
        _prompts.Add("How did I see the hand of the Lord in my life today? ");
        _prompts.Add("What was the biggest challenge I faced today? ");
        _prompts.Add("What was one act of kindness I witnessed or performed today? ");
        _prompts.Add("What moment today made me smile or laugh? ");
        _prompts.Add("What decision or choice did I make today that Im proud of? ");
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}