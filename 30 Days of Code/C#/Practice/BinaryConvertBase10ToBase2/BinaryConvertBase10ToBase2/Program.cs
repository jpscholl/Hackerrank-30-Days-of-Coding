/*
//  Author: Jonathan Scholl
//  Date: 9/4/2021
//  Description: Day 10 hackerrank coding challenge
//  notes: I admittedly had to look this up. I had to study the solution to understand how it works.
*/
using System;
using System.Buffers.Text;
using System.Linq;

namespace BinaryConvertBase10ToBase2
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user for input and convert and store into int variable
            int userNum = Convert.ToInt32(Console.ReadLine().Trim());

            //save number as binary string number
            string userNumAsBinary = Convert.ToString(userNum, 2);

            //split into array
            string[] ones = userNumAsBinary.Split('0');

            //initilize 2 int variables
            int sum = 0;
            int sumMax = 0;

            //foreach string in ones []
            foreach (string str in ones)
            {
                //loop through the array based on length
                for (int i = 0; i < str.Length; i++)
                {
                    //if current index of o is 1...
                    if (str[i] == '1')
                    {
                        //increment sum
                        sum++;
                    }
                }

                //sumMax equal to (checks if sumMax greater than or equal to sum) True: sumMax False: sum;
                sumMax = sumMax >= sum ? sumMax : sum;
                //sum = 0;
            }

            //Console.WriteLine(userNumAsBinary);
            Console.WriteLine(sumMax);
        }
    }
}
