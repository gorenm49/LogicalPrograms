using System;

namespace LogicalPrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number for select Option: \n 1. Fibonacci \n 2. Perfect Number \n 3. Exit.\n ");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Fibonacci f1 = new Fibonacci();
                    f1.fibo();
                    break;
                case 2:
                    PerfectNumber p1= new PerfectNumber();
                    p1.perfect();
                    break;
                case 3:
                    break;
                default:
                    System.Console.WriteLine("Choose correct option..");
                    break;
            }
            
            
            

            
            
        }
    }
}