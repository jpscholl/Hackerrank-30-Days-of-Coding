/*
//  Author: Jonathan Scholl
//  Date: 9/9/2021
//  Exercise: Hackerrank 30 Days of Code: Exception Practice
//  Description: Following the video tutorial to practice exception handling
*/
using System;

namespace ExceptionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] intArray = new int[10];
            //Console.WriteLine(intArray[10]);

            try
            {
                int[] c = new int[6];
                Console.WriteLine("Element 6 at index 5 = " + c[5]);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception thrown" + e);
            }
            finally
            {
                Console.WriteLine("Finally clause: Finished try-catch");
            }
        }
    }
}
