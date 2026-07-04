using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        string answer = "yes";
        while (answer == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,100);

            int guess;
            int guessCount = 0;
            do
            {
                Console.Write("What is your guess? ");
                string userInput2 = Console.ReadLine();
                guess = int.Parse(userInput2);

                if (guess == magicNumber)
                {
                    Console.WriteLine("You guessed the number!!");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Higher");
                }
                guessCount += 1;
            } while (guess != magicNumber);
            Console.WriteLine($"You took {guessCount} number of guesses.");

            Console.Write("Do you want to play again? ");
            answer = Console.ReadLine();
        }
        
        
    }
}