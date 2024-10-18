using System;

public class ReflectionActivity : MindfulnessActivity
{
    private string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public void RunReflectionActivity()
    {
        // Start the activity with the name and description
        StartActivity("Reflection Activity", 
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        Random random = new Random();
        int reflectionDuration = _duration;

        while (reflectionDuration > 0)
        {
            string prompt = _prompts[random.Next(_prompts.Length)];
            Console.WriteLine($"Prompt: {prompt}");
            Console.WriteLine("Now think about the following questions:");

            foreach (string question in _questions)
            {
                Console.WriteLine(question);
                ShowSpinner(5); // Pausing for user to reflect on each question
                reflectionDuration -= 5; // Deduct from the remaining time
                if (reflectionDuration <= 0) break;
            }
        }

        // End the activity
        EndActivity();
    }
}
