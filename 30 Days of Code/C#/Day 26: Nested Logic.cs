using System;

class Solution
{
    static void Main(String[] args)
    {
        string[] returnedDate = Console.ReadLine().Split(' ');
            int returnedDay = int.Parse(returnedDate[0]);
            int returnedMonth = int.Parse(returnedDate[1]);
            int returnedYear = int.Parse(returnedDate[2]);

            string[] dueDate = Console.ReadLine().Split(' ');
            int dueDay = int.Parse(dueDate[0]);
            int dueMonth = int.Parse(dueDate[1]);
            int dueYear = int.Parse(dueDate[2]);

            int returnFee = 0;

            if (returnedYear > dueYear) 
            { 
                returnFee = 10000;
            } 
            else if (returnedYear == dueYear)
            {
                if (returnedMonth > dueMonth)
                {
                    returnFee = (returnedMonth - dueMonth) * 500;
                }
                else if (returnedMonth == dueMonth && returnedDay > dueDay)
                { 
                    returnFee = (returnedDay - dueDay) * 15;
                } 
            }

            Console.WriteLine(returnFee);
    }
}
