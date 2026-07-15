using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person you met or talked to today, and why?",
        "What was the best part of your day?",
        "What challenge did you face today, and how did you handle it?",
        "What made you smile or laugh today?",
        "What is one thing you learned today that you didn't know before?",
        "What are you grateful for today?",
        "If you could relive one moment from today, which would it be and why?",
        "What is one goal you made progress toward today?",
        "How did you help someone today, or how did someone help you?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);

        return _prompts[index];
    }
}