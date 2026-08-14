using System.Formats.Tar;
using System.Runtime;
using System.Xml.Serialization;

public class GoalManager
{
    List<Goal> _goals = new List<Goal>();
    int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public int GetScore()
    {
        return _score;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetName());
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The type of Goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("What type of goal would you like to create? ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                string spoints = Console.ReadLine();
                int points = int.Parse(spoints);

                SimpleGoal sGoal = new SimpleGoal(name, description, points);

                _goals.Add(sGoal);
                break;
            case "2":
                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                spoints = Console.ReadLine();
                points = int.Parse(spoints);

                EternalGoal eGoal = new EternalGoal(name, description, points);

                _goals.Add(eGoal);
                break;
            case "3":
                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                spoints = Console.ReadLine();
                points = int.Parse(spoints);

                Console.Write("How many times does this goal needs to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing is that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);

                _goals.Add(checklistGoal);
                break;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }

        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());

        Goal selectedGoal = _goals[choice - 1];

        int earnedPoints = selectedGoal.RecordEvent();

        _score += earnedPoints;

        Console.WriteLine($"Congratulations! You earned {earnedPoints} points.");
        Console.WriteLine($"You now have {_score} points.");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(":");

            string goalType = parts[0];
            string[] details = parts[1].Split(",");

            if (goalType == "SimpleGoal")
            {
                string name = details[0];
                string description = details[1];
                int points = int.Parse(details[2]);
                bool complete = bool.Parse(details[3]);

                _goals.Add(new SimpleGoal(name, description, points, complete));
            }
            else if (goalType == "EternalGoal")
            {
                string name = details[0];
                string description = details[1];
                int points = int.Parse(details[2]);

                _goals.Add(new EternalGoal(name, description, points));
            }
            else if (goalType == "ChecklistGoal")
            {
                string name = details[0];
                string description = details[1];
                int points = int.Parse(details[2]);
                int bonus = int.Parse(details[3]);
                int target = int.Parse(details[4]);
                int completed = int.Parse(details[5]);

                _goals.Add(new ChecklistGoal(name, description, points, target, bonus, completed));
            }
        }
    }
}