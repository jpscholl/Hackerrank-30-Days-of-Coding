/*
//  Author: Jonathan Scholl
//  Date: 9/9/2021
//  Exercise: Day 16: Exceptions - String to Integer
//  Description: Hackerrank 30 days of code solution Day 16
*/
using System;

namespace Day_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //store user input into string
            string S = Console.ReadLine();

            try
            {
                //test if string is an integer
                int num = int.Parse(S);
                //if string is integer then it outputs string
                Console.WriteLine(S);
            }
            catch (Exception)
            {
                //if the user input isn't an int then outputs following message
                Console.WriteLine("Bad String");
            }
        }
    }
}
