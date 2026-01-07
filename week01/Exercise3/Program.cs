using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,11);
        int guess;
        string play = "yes";
        int numberOfGuesses = 0;
        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            numberOfGuesses += 1;
            if (magicNumber == guess)
            {
                Console.WriteLine($"You guessed it! It took you {numberOfGuesses} guesses.");
                Console.Write("do you want to continue playing? ");
                play = Console.ReadLine();
                magicNumber = randomGenerator.Next(1,11);
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
        } while (magicNumber != guess && play == "yes");

    }
}