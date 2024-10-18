using System;

public class BreathingActivity : MindfulnessActivity
{
    public void RunBreathingActivity()
    {
        // Start the activity with the name and description
        StartActivity("Breathing Activity", 
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        // Calculate how many full cycles of breathing (in + out) will fit in the specified duration
        int breathingCycles = _duration / 6; // Assume 3 seconds for "Breathe in..." and 3 seconds for "Breathe out..."
        
        for (int i = 0; i < breathingCycles; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3); // Pausing for 3 seconds
            Console.WriteLine("Breathe out...");
            ShowCountdown(3); // Pausing for 3 seconds
        }

        // End the activity
        EndActivity();
    }

    // Show countdown with backspaces for breathing activity
    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the number and replace it with a new one
        }
        Console.WriteLine(); // Move to next line after countdown
    }
}

