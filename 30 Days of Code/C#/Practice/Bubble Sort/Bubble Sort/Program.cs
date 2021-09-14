/*
//  Author: Jonathan Scholl
//  Date: 9/14/2021
//  Project: Day 20: Bubble Sort
//  Description: 30 Days of coding Hackerrank day 20
*/
using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int numberOfSwaps = 0;

        // Write your code here
        for (int i = 0; i < n; i++)
        {
            for (int x = 0; x < n - 1; x++)
            {
                if (a[x] > a[x + 1])
                {
                    int temp = a[x];
                    a[x] = a[x + 1];
                    a[x + 1] = temp;
                    numberOfSwaps++;
                }
                if (numberOfSwaps == 0)
                {
                    break;
                }
            } 
            
            Console.WriteLine("Array is sorted in " + numberOfSwaps + " swaps.");
            Console.WriteLine("First Element: " + a[0]);

        }    
    }
}
