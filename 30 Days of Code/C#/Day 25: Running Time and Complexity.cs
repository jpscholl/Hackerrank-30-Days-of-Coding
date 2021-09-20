using System;

class Solution
{
    public static bool isPrime(int n)
    {
        //i equal to 2 (first prime number) runs if square root is greater than or equal to 2
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            //modulus of 0 means not prime
            if (n % i == 0)
            {
                return false;
            }
        }
        //prime
        return true;
    }

    static void Main(String[] args)
    {
        //number of integers to test
        var T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            //input number to check
            int n = int.Parse(Console.ReadLine());

            //if number is greater than or equal to 2 and is true outputs Prime
            if (n >= 2 && isPrime(n))
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
        }
    }
}
