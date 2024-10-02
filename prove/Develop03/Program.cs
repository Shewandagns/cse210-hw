class Program
{
    static void Main(string[] args)
    {
        // Example Scripture: John 3:16
        Reference reference = new Reference("John", 3, 16);
        string scriptureText = "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life.";
        Scripture scripture = new Scripture(reference, scriptureText);

        while (!scripture.AllWordsHidden())
        {
            scripture.Display();
            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.WriteLine("All words are hidden. Program ended.");
    }
}
