using System;

namespace LogicalPrograms
{
    public class ReverseNumber
    {
        public void reverse()
        {

            System.Console.WriteLine("Enter a Number for reverse operation");
            int num = int.Parse(Console.ReadLine());
            int remaider = 0, sum = 0;

            while (num > 0)
            {
                remaider = num % 10;   
                sum = sum*10 + remaider;
                num = num / 10;
            }

            System.Console.WriteLine("Reverse number is :"+sum);
        }
    }
}