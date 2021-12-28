/*
//  Author: Jonathan Scholl
//  Date: 12/28/2021
//  Project: https://www.hackerrank.com/challenges/mini-max-sum/problem
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mini_Max_Sum
{
    class Result
    {

        /*
         * Complete the 'miniMaxSum' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void miniMaxSum(List<int> arr)
        {
            long resultMax = 0;
            long resultMin = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                resultMax += arr[i];
                resultMin += arr[i];
            }
            Console.WriteLine($"{resultMax - arr.Max()} {resultMin - arr.Min()}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            
            Result.miniMaxSum(arr);
        }
    }
}
