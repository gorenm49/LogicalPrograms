using System;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public void perfect()
        {

            int num = 28, sum = 0;

            for (int i = 1; i <= num/2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;

                }
            }

            if (sum == num)
            {
                System.Console.WriteLine("This is perfect number.");
            }
        }
    }
}