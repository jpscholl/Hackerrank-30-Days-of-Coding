/*
//  Author: Jonathan Scholl
//  Date: 12/28/2021
//  Project: https://www.hackerrank.com/challenges/plus-minus/problem?isFullScreen=true
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Plus_Minus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.plusMinus(arr);
        }
        class Result
        {
            /*
             * Complete the 'plusMinus' function below.
             *
             * The function accepts INTEGER_ARRAY arr as parameter.
             */

            public static void plusMinus(List<int> arr)
            {
                int zeroCount = 0;
                int posCount = 0;
                int negCount = 0;

                for (int i = 0; i < arr.Count; i++)
                {                  
                    if (arr[i] > 0) posCount++;
                    if (arr[i] < 0) negCount++;
                    if (arr[i] == 0) zeroCount++;
                }

                double positive = ((double)posCount / arr.Count);
                double negative = ((double)negCount / arr.Count);
                double zero = ((double)zeroCount / arr.Count);

                Console.WriteLine(positive.ToString("F6"));
                Console.WriteLine(negative.ToString("F6"));
                Console.WriteLine(zero.ToString("F6"));
            }
        }
    }
}
