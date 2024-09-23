using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;

        do
        {
            // Generate a random number between 1 and 100
            Random random = new Random();
            int magicNumber = random.Next(1, 101);

            int guess = -1;
            int guessCount = 0;

            Console.WriteLine("I have picked a magic number between 1 and 100. Can you guess it?");

            // Loop until the user guesses the magic number
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }

            // Ask the user if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes");

        Console.WriteLine("Thanks for playing!");
    }
}
