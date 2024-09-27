public class Program
{
    public static void Main(string[] args)
    {
        // Create an instance of the Journal class
        Journal journal = new Journal();

        // Variable to store the user's menu choice
        string choice = "";

        // Display menu options in a loop until the user chooses to quit
        while (choice != "5")
        {
            // Display the menu options
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            // Get the user's choice
            choice = Console.ReadLine();

            // Handle the user's choice with a switch statement
            switch (choice)
            {
                case "1":
                    // Write a new entry by prompting the user
                    journal.WriteEntry();
                    break;
                case "2":
                    // Display all journal entries
                    journal.DisplayJournal();
                    break;
                case "3":
                    // Prompt for a filename and save the journal to that file
                    Console.Write("Enter filename to save: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveJournal(saveFilename);
                    break;
                case "4":
                    // Prompt for a filename and load the journal from that file
                    Console.Write("Enter filename to load: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadJournal(loadFilename);
                    break;
                case "5":
                    // Exit the loop to quit the program
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    // Handle invalid choices
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
