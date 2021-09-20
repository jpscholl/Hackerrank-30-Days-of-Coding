using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace RunTimePractice
{
    class Program
    {
        public static int findNumsOfRep(string s, char c)
        {
            //Linear time; O(n) time
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    sum++;
                }
            }
            return sum;
        }

        public static int[] findNumsOfRepititionsV1(String s, char[] c)
        {
            // Quad time: O(n * m) time
            int[] sums = new int[c.Length];

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < c.Length; j++)
                {
                    if(s[i] == c[j])
                    {
                        sums[j] = sums[j] + 1;
                    }
                }
            }
            return sums;
        }

        //have to figure out the C# equivalent of the Java tutotial
        //Day 25 24 mins into video

        //public static int[] findnumsofrepititionsv1(string s, char[] c)
        //{
        //    optimal time: o(n+m)
        //    int[] sums = new int[c.length];
        //    dictionary<char, int> map = new dictionary<char, int>();

        //    for (int i = 0; i < s.length; i++)
        //    {
        //        if (!map.containskey(s[i]))
        //        {
        //            map[i] =
        //        }
        //        else
        //        {
        //            int sum = map.
        //        }
        //    }
        //}

        public static void Main(string[] args)
        {
            //time starts
            long startTime = DateTime.Now.Ticks;
            char[] a = { 'a', 'b' };
            //test time
            Console.WriteLine(findNumsOfRepititionsV1("abcakjahsdflkjahsdlkfjahdslkjfhalkdsjfhlkajsdhflkjahsdflkjhasdkljf", a));
            //time ends
            long stopTime = DateTime.Now.Ticks;
            //duration
            long duration = stopTime - startTime;
            //output duration
            Console.WriteLine("Time elapsed: " + duration + " ticks");


            //time starts
            startTime = DateTime.Now.Ticks;
            //test time
            Console.WriteLine(findNumsOfRep("abcakjahsdflkjahsdlkfjahdslkjfhalkdsjfhlkajsdhflkjahsdflkjhasdkljf", 'a'));
            //time ends
            stopTime = DateTime.Now.Ticks;
            //duration
            duration = stopTime - startTime;
            //output duration
            Console.WriteLine("Time elapsed: " + duration + " ticks");

        }
    }
}
