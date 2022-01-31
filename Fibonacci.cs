using System;

namespace LogicalPrograms
{
    public class Fibonacci
    {
        public void fibo()
        {
            Console.WriteLine("Enter number of elements: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int firstVar = 1, secondVar = 1, thirdVar=0;
            Console.Write(firstVar+"\t"+secondVar);

            for (int i = 3; i <= num; i++)
            {
                thirdVar = firstVar + secondVar;
                System.Console.Write("\t"+thirdVar);

                firstVar = secondVar;
                secondVar = thirdVar;
            }

            Console.WriteLine("\n");
        }
    }
}