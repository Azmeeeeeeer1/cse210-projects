using System;

class Program
{
    static void Main(string[] args)
    {
        int largest = 0;
        float sum = 0;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter the list of numbers, type 0 when finished.");

        string userInput = "";
        int number;
        while (userInput != "0")
        {
            if (userInput != "0")
            {
            Console.Write("Enter number: ");
            userInput = Console.ReadLine();
            number = int.Parse(userInput);
            numbers.Add(number);
            }
        }
        
        foreach (int digit in numbers)
        {
            sum += digit;
            if (digit > largest)
            {
                largest = digit;
            }
        }
        float average = sum / (numbers.Count - 1);

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {largest}");
    }
}