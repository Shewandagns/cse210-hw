using System;
using System.Collections.Generic;

public class ListingActivity : MindfulnessActivity
{
    private string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public void RunListingActivity()
    {
        // Start the activity with the name and description
        StartActivity("Listing Activity", 
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Length)];

        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("You have a few seconds to think about this prompt...");

        // Give the user some time to think about the prompt
        ShowSpinner(5);

        // Collecting the list of items
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                items.Add(item);
            }
        }

        // Display the results
        Console.WriteLine($"You listed {items.Count} items.");

        // End the activity
        EndActivity();
    }
}
