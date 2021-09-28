/*
//  Author: Jonathan Scholl
//  Date: 9/28/2021
//  Project: https://www.hackerrank.com/challenges/simple-array-sum/problem
//  Description: Given an array of integers, find the sum of its elements.
*/
using System;

namespace SimpleArraySum
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How many integers: ");
            int N = int.Parse(Console.ReadLine());

            int[] numArray = new int[N];

            Console.WriteLine("");

            for (int i = 0; i < N; i++)
            {
                Console.Write("Please enter integer: ");
                numArray[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Sum of the array: " + sumOfArray(numArray));
        }

        public static int sumOfArray(int[] arr)
        {
            int sum = 0;

            foreach (int item in arr)
            {
                sum += item;
            }
            return sum;
        }
    }
}
