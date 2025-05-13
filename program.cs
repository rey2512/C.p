using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int targetNumber = random.Next(1, 101);
            int attempts = 0;
            int guess = 0;

            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I have selected a number between 1 and 100. Try to guess it!");

            while (guess != targetNumber)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out guess))
                {
                    attempts++;
                    
                    if (guess < targetNumber)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else if (guess > targetNumber)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! You've guessed the correct number: {targetNumber}");
                        Console.WriteLine($"It took you {attempts} attempts.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            Console.WriteLine("Thanks for playing!");
        }
    }
}
