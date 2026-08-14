using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        int choice = 0;

        while (choice != 6)
        {
            Console.Clear();

            Console.WriteLine($"You have {manager.GetScore()} points.");
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");

            Console.Write("\nSelect a choice from the menu: ");

            choice = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    manager.CreateGoal();
                    break;

                case 2:
                    manager.ListGoalDetails();
                    break;

                case 3:
                    manager.SaveGoals();
                    break;

                case 4:
                    manager.LoadGoals();
                    break;

                case 5:
                    manager.RecordEvent();
                    break;

                case 6:
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            if (choice != 6)
            {
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}