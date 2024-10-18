using System;
using System.Threading;

public class MindfulnessActivity
{
    protected int _duration;
    protected string _activityName;
    protected string _description;

    public void StartActivity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
        
        Console.Clear();
        Console.WriteLine($"Starting {_activityName}");
        Console.WriteLine(_description);
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3); // Spinner pause before starting the activity
    }

    public void EndActivity()
    {
        Console.WriteLine("Good job!");
        Thread.Sleep(1000);
        Console.WriteLine($"You have completed the {_activityName} activity for {_duration} seconds.");
        ShowSpinner(3); // Spinner pause before finishing
    }

    protected void ShowAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(". ");
            Thread.Sleep(1000); // Pauses for 1 second
        }
        Console.WriteLine();
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds * 10; i++) // Spinner rotates faster
        {
            Console.Write(spinner[i % 4]);
            Thread.Sleep(100);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}
