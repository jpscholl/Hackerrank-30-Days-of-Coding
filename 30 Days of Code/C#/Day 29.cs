using System;
class Solution
{
    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);

            if (((k - 1) | k) > n && k % 2 == 0)
                Console.WriteLine(k - 2);
            else
                Console.WriteLine(k - 1);
        }
    }
}
