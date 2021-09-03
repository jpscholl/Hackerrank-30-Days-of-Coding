/*
//  Author: Jonathan Scholl
//  Date: 8/31/2021
//  Exercise: Guess The Number Game
//  Description: Creating a game where the computer randomly picks number between 1-100
//  and you try to guess it in as few tries as possible.
*/
using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Guess The Number game!" +
                "\nCPU is choosing number at random (1 - 100)");

            GuessNumberGame.NumGuessGame();

        }
    }
}