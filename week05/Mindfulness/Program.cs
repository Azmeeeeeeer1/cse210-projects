using System;

class Program
{
    static void Main(string[] args)
    {
        int breathingCount = 0;
        int reflectionCount = 0;
        int listingCount = 0;
        int gratitudeCount = 0;

        bool running = true;

        while (running)
        {
            Console.Clear();

            Console.WriteLine("Mindfulness Program");
            Console.WriteLine();

            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Gratitude Activity");
            Console.WriteLine("5. Quit");
            Console.WriteLine();

            Console.Write("Choose an option: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    new BreathingActivity().Run();
                    breathingCount++;
                    break;

                case "2":
                    new ReflectionActivity().Run();
                    reflectionCount++;
                    break;

                case "3":
                    new ListingActivity().Run();
                    listingCount++;
                    break;

                case "4":
                    new GratitudeActivity().Run();
                    gratitudeCount++;
                    break;

                case "5":
                    running = false;
                    break;
            }
        }

        Console.Clear();

        Console.WriteLine("Activity Summary");
        Console.WriteLine("----------------");
        Console.WriteLine($"Breathing: {breathingCount}");
        Console.WriteLine($"Reflection: {reflectionCount}");
        Console.WriteLine($"Listing: {listingCount}");
        Console.WriteLine($"Gratitude: {gratitudeCount}");
    }
}