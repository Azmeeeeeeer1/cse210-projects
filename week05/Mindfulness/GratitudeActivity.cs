using System;

public class GratitudeActivity : Activity
{
    public GratitudeActivity()
        : base(
            "Gratitude Activity",
            "Think about things you are grateful for today.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("Write something you're grateful for: ");
            Console.ReadLine();
        }

        DisplayEndingMessage();
    }
}