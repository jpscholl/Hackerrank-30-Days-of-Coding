/*
//  Author: Jonathan Scholl
//  Date: 9/3/2021
//  Exercise: HackerRank 30 Days of Code
//  Description: Day 9 Recursion
*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace Day_9
{
	class Program
	{
        public static int Factorial(int x)
        {
            //Base Case
            if (x <= 1)
            {
                return 1;
            }
            //Recursive Case
            else
            {
                return x * Factorial(x - 1);
            }
        }
        static void Main(string[] args)
		{
            int userNum = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine(Factorial(userNum));
		}
	}
}
