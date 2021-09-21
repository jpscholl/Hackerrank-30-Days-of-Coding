using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Day_28
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine().Trim());

            var users = new List<string>();

            for (int i  = 0; i < n; i++)
            {
                var tmp = Console.ReadLine().TrimEnd().Split(' ');
                var firstName = tmp[0];
                var emailID = tmp[1];

                if (Regex.IsMatch(emailID, @".+gmail\.com$"))
                {
                    users.Add(firstName);
                }
            }

            users.Sort();

            foreach(var firstName in users)
            {
                Console.WriteLine(firstName);
            }
            
        }
    }
}
