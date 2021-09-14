/*
//  Author: Jonathan Scholl
//  Date: 9/13/2021
//  Exercise: Day 19 Interfaces
//  Description: Hackerrank 30 Days of Code 
*/
using System;

namespace StarWarsInterfacePractice
{
    class Program
    {
        public static Character SummonCharacter()
        {
            Random rand = new Random();
            if (Math.Abs(rand.Next()) % 2 == 0)
            {
                return new Enemy();
            }
            else
            {
                return new Hero();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Star Wars!");
            Console.WriteLine("May the force be with you...\n");

            Enemy DarthVader = new Enemy();
            Hero ObiwanKenobi = new Hero();

            DarthVader.attack();
            ObiwanKenobi.attack();
            DarthVader.heal();
            ObiwanKenobi.heal();

            Console.WriteLine("Enemy weapon: " + DarthVader.getWeapon());
            Console.WriteLine("Hero weapon: " + ObiwanKenobi.getWeapon());

            Character spy = SummonCharacter();

            spy.attack();
            spy.heal();
        }
    }
}
