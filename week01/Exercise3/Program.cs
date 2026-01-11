using System;
using System.Security;

class Program
{
    static void Main(string[] args)
    {
        // Part 1 where the user provides the magic number

        // Console.Write("What is your magic number? ");
        // string questionNumber = Console.ReadLine();
        // int magicNumber = int.Parse(questionNumber);

        // Console.Write("What is your guess? ");
        // string questionGuess = Console.ReadLine();
        // int guess = int.Parse(questionGuess);

        // while (guess != magicNumber)
        // {
        //     Console.Write("What is your guess? ");
        //     guess = int.Parse(Console.ReadLine());

        //     if (magicNumber > guess)
        //     {
        //         Console.WriteLine("Higher");
        //     }
        //     else if (magicNumber < guess)
        //     {
        //         Console.WriteLine("Lower");
        //     }
        //     else
        //     {
        //         Console.WriteLine("You guessed it right!");
        //     }

        // PART 3: USING  RANDOM TO GENERATE MAGIC NUMBER
        // INCLUDING STRETCH CHALLENGE 

        string playResponse = "yes";

        while (playResponse == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int guessCount = 0;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Congratulation, you guessed it right!");
                    Console.WriteLine($"You made {guessCount} guesses.");
                }
            }

            Console.Write("Do you want to play again? (yes/no) ");
            playResponse = Console.ReadLine().ToLower();
        }
    }
}