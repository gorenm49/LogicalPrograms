using System;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public void prime()
        {
            System.Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            int count  = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("Prime number");
            }
            else
            {
                System.Console.WriteLine("Not a prime number");
            }
        }
    }
}