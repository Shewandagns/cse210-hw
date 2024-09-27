using System;
using System.Collections.Generic;
using System.IO; // For reading and writing files

public class Journal
{
    // List to store all journal entries
    private List<Entry> entries = new List<Entry>();

    // List of prompts to show randomly when writing a new entry
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    // Method to add a new entry by showing a random prompt
    public void WriteEntry()
    {
        // Create a random object to select a random prompt from the list
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(prompt); // Display the prompt

        // Get the user's response and current date
        string response = Console.ReadLine();
        string date = DateTime.Now.ToShortDateString(); // Get the current date as a short string (MM/DD/YYYY)

        // Create a new Entry object and add it to the list of entries
        entries.Add(new Entry(date, prompt, response));
    }

    // Method to display all journal entries
    public void DisplayJournal()
    {
        // Iterate over the list of entries and print each one
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.ToString()); // Use the overridden ToString() to format the output
        }
    }

    // Method to save the journal to a file
    public void SaveJournal(string filename)
    {
        // Open a StreamWriter to write to the specified file
        using (StreamWriter writer = new StreamWriter(filename))
        {
            // Write each entry as a line in the file
            foreach (var entry in entries)
            {
                // Write each entry as a single line in the format: "Date|Prompt|Response"
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    // Method to load journal entries from a file
    public void LoadJournal(string filename)
    {
        // Check if the file exists
        if (File.Exists(filename))
        {
            // Clear the current list of entries
            entries.Clear();

            // Read all lines from the file
            string[] lines = File.ReadAllLines(filename);

            // Iterate over each line, split it by the separator '|', and create a new Entry
            foreach (var line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3) // Ensure that there are three parts (Date, Prompt, Response)
                {
                    // Add a new entry with the data from the file
                    entries.Add(new Entry(parts[0], parts[1], parts[2]));
                }
            }
        }
        else
        {
            // Display an error if the file does not exist
            Console.WriteLine("File not found.");
        }
    }
}
