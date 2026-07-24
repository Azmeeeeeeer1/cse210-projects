using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>()
        {
            new Scripture(new Reference("Matthew", 5, 16),
                  "Let your light so shine before men, that they may see your good works."),

            new Scripture(new Reference("Joshua", 1, 9),
                  "Be strong and of a good courage; be not afraid, neither be thou dismayed."),

            new Scripture(new Reference("Philippians", 4, 13),
                  "I can do all things through Christ which strengtheneth me."),

            new Scripture(new Reference("Doctrine and Covenants", 6, 36),
                    "Look unto me in every thought; doubt not, fear not.")
        };

        Random rand = new Random();

        Scripture scripture = scriptures[rand.Next(scriptures.Count)];

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine("Press enter to continue or 'quit' to finish: ");
        string prompt = Console.ReadLine();

        while (prompt != "quit")
        {
            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            scripture.HideRandomWords(2);

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("Press enter to continue or 'quit' to finish: ");
            prompt = Console.ReadLine();
        }
    }
}