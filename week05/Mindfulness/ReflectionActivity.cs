using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new()
    {
        "Think of a time when you helped someone.",
        "Think of a difficult challenge you overcame.",
        "Think of a time you stood up for someone.",
        "Think of a time you were truly happy."
    };

    private List<string> _questions = new()
    {
        "Why was it meaningful?",
        "What did you learn?",
        "How did you feel?",
        "Would you do it again?",
        "What made it different?",
        "How can you use this experience again?"
    };

    public ReflectionActivity()
        : base(
            "Reflection Activity",
            "Reflect on times when you showed strength and resilience.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random random = new();

        Console.WriteLine();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
        Console.WriteLine();

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.WriteLine(_questions[random.Next(_questions.Count)]);
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}