using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalPoints = 0;

    static void Main(string[] args)
    {
        bool isRunning = true;

        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Eternal Quest!");
            Console.WriteLine($"Total Points: {totalPoints}");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    RecordEvent();
                    break;
                case "4":
                    SaveGoals();
                    break;
                case "5":
                    LoadGoals();
                    break;
                case "6":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }

        Console.WriteLine("Thanks for playing Eternal Quest!");
    }

    static void CreateGoal()
    {
        Console.WriteLine("Select the type of goal to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choice: ");
        string typeChoice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (typeChoice)
        {
            case "1":
                goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter required completions: ");
                int requiredCompletions = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points for completing: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, description, points, requiredCompletions, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    static void ListGoals()
    {
        Console.Clear();
        Console.WriteLine("List of Goals:");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            goals[i].DisplayGoal();
        }

        Console.WriteLine("\nPress any key to return to the main menu...");
        Console.ReadKey();
    }

    static void RecordEvent()
    {
        ListGoals();
        Console.Write("Which goal did you complete? Enter the number: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            goals[goalIndex].RecordEvent();
            totalPoints += goals[goalIndex].GetPoints();
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }

        Console.WriteLine("\nPress any key to return to the main menu...");
        Console.ReadKey();
    }

    static void SaveGoals()
    {
        Console.Write("Enter filename to save goals: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(totalPoints); // Save total points

            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.GetType().Name);
                outputFile.WriteLine(goal.ToString()); // Customize this to store goal properties
            }
        }

        Console.WriteLine("Goals saved successfully!");
        Console.ReadKey();
    }

    static void LoadGoals()
    {
        Console.Write("Enter filename to load goals: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            totalPoints = int.Parse(lines[0]); // Load total points

            goals.Clear(); // Clear existing goals before loading new ones

            for (int i = 1; i < lines.Length; i += 2) // Adjust based on how goal data is stored
            {
                string goalType = lines[i];
                string goalData = lines[i + 1]; // Example: Parse goal data

                if (goalType == "SimpleGoal")
                {
                    // Parse and add a SimpleGoal based on goalData
                }
                else if (goalType == "EternalGoal")
                {
                    // Parse and add an EternalGoal based on goalData
                }
                else if (goalType == "ChecklistGoal")
                {
                    // Parse and add a ChecklistGoal based on goalData
                }
            }

            Console.WriteLine("Goals loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }

        Console.ReadKey();
    }
}
