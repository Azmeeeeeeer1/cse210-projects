using System;
using System.ComponentModel.DataAnnotations;
using System.IO.Enumeration;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();

        string choice = "";
        while (choice != "5")
        {
            PromptGenerator randomPrompt = new PromptGenerator();

            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                Entry anEntry = new Entry();

                anEntry._promptText = randomPrompt.GetRandomPrompt();               
                Console.WriteLine(anEntry._promptText);

                Console.Write(">");
                anEntry._entryText = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                anEntry._date = theCurrentTime.ToShortDateString();

                theJournal.AddEntry(anEntry);
            }
            else if (choice == "2")
            {
                theJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();

                theJournal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();

                theJournal.SaveToFile(filename);
            }
            else if (choice == "5")
            {
                
            }
            else
            {
                Console.WriteLine("Please choose form the options given above.");
            }
        }
    }
}