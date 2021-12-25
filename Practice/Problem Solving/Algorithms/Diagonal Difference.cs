/*
//  Author: Jonathan Scholl
//  Date: 12/24/2021
//  Project: https://www.hackerrank.com/challenges/diagonal-difference/problem?isFullScreen=true
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            Console.WriteLine(diagonalDifference(arr));
        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            int firstDiag = 0;
            int secondDiag = 0;

            for (int x = 0, y = 0; x < arr.Count; x++, y++)
            {
                firstDiag += arr[x][y];
            }

            for (int x = arr.Count - 1, y = 0; x >= 0; x--, y++)
            {
                secondDiag += arr[x][y];
            }

            return Math.Abs(firstDiag - secondDiag);
        }
    }
}
