using System;
using System.Collections.Generic;
using System.Linq; ;

namespace Day_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string val;
            string key;

            Dictionary<string, string> dict = new Dictionary<string, string>();

            userInput = Console.ReadLine();

            string[] wordbits = userInput.Split(' ');



            for (int i = 0; i < wordbits.Length - 1; i += 2)
            {
                key = wordbits[i];
                val = wordbits[(i + 1)];

                dict.Add(key, val);
            }

            Console.WriteLine($"you typed in {userInput}");

        }
    }
}
