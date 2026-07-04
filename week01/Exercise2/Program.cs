using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percentage? ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);

        string letter;

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You got {letter}");

        if (letter == "D" || letter == "F")
        {
            Console.WriteLine("You will get it next time if you study hard enough!!");
        }
        else
        {
            Console.WriteLine("Congratulations you passed!!!");
        }
    }
}