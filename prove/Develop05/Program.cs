using System;

class Program
{
    static void Main(string[] args)
    {
        // Main menu system for selecting activities
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an activity: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.RunBreathingActivity();
                    break;
                case "2":
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.RunReflectionActivity();
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.RunListingActivity();
                    break;
                case "4":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}