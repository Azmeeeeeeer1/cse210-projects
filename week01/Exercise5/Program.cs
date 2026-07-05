using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userInput = Console.ReadLine();
            int favoriteNumber = int.Parse(userInput);
            return favoriteNumber;
        }
        static int SquareNumber()
        {
            int number = PromptUserNumber();
            int sqrNumber = number * number;

            return sqrNumber;
        }
        static void DisplayResult()
        {
            DisplayWelcome();
            string name = PromptUserName();
            int squareNumber = SquareNumber();

            Console.WriteLine($"{name}, the square of your number is {squareNumber}"); 
        }

        DisplayResult();
    }
}