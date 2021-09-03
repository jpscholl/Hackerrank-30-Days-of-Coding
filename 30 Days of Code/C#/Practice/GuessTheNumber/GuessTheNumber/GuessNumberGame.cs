using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class GuessNumberGame
    {
        public static int cpuNumGenerator()
        {
            Random rand = new Random();
            int cpuNum = rand.Next(1, 100);
            return cpuNum;
        }

        public static void NumGuessGame()
        {
            int cpuRandomNum = cpuNumGenerator();
            bool playerWins = false;
            int numOfGuesses = 0;
            do
            {
                Console.Write("Enter your guess: ");
                int playerGuess = Convert.ToInt32(Console.ReadLine());


                if (playerGuess == cpuRandomNum)
                {
                    numOfGuesses++;
                    Console.WriteLine("\nCPU random Number: " + cpuRandomNum);
                    Console.WriteLine("You guessed it in " + numOfGuesses + " tries");
                    playerWins = true;
                }
                else if (playerGuess >= 0 && playerGuess <= 100 && playerGuess > cpuRandomNum)
                {
                    numOfGuesses++;
                    Console.WriteLine("You guessed too high!");
                }
                else if (playerGuess >= 0 && playerGuess <= 100 && playerGuess < cpuRandomNum)
                {
                    numOfGuesses++;
                    Console.WriteLine("You guesssed too low!");
                }
                else
                {
                    numOfGuesses++;
                    Console.WriteLine("Out of range!");
                }
            } while (playerWins != true);

            Console.WriteLine("Exiting game");

        }
    }
}
