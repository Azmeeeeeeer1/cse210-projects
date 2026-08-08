using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new()
    {
        "Who do you appreciate?",
        "What are your strengths?",
        "Who have you helped recently?",
        "Who are your heroes?"
    };

    public ListingActivity()
        : base(
            "Listing Activity",
            "List as many positive things as you can.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random random = new();

        Console.WriteLine();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
        Console.WriteLine();

        Console.WriteLine("You may begin in...");
        ShowCountdown(5);

        int count = 0;

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {count} items.");

        DisplayEndingMessage();
    }
}