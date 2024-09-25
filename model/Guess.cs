using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser.model
{
    public class Guess
    {
        public static int GenerateRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1);
        }

        public static bool AskToPlayAgain()
        {
            Console.Write("do you want to play again press y for yes or n for no: ");
            string userResponse = Console.ReadLine().Trim().ToLower();
            return userResponse == "y";
        }
        public static void RunNumberGuesser(int min, int max)
        {
            bool playAgain = true;
            while (playAgain)
            {
                int targetNumber = GenerateRandomNumber(min, max);
                int userGuess = 0;
                int guessCount = 0;
                int maxAttempts = 6;

                Console.WriteLine($"guess number between {min} and {max} you have {maxAttempts} attempts");

                while (guessCount < maxAttempts && userGuess != targetNumber)
                {
                    Console.Write("Enter your guess: ");
                    userGuess = int.Parse(Console.ReadLine());
                    guessCount++;
                    string resultMessage = userGuess < targetNumber ? "too low try again" : userGuess > targetNumber ? "too high try again" : $"Congrats you guess the correct number {targetNumber} in {guessCount} attempt";

                    Console.WriteLine(resultMessage);
                    Console.WriteLine(guessCount == maxAttempts && userGuess != targetNumber ? $"sorry you used all {maxAttempts} attempts. correct number was {targetNumber}" : "");
                }
                playAgain = AskToPlayAgain();
            }

            Console.WriteLine("thanks for playing");
        }
    }
}
