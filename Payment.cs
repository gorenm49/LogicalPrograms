using System;

namespace LogicalPrograms
{
    public class Payment
    {
        public void monthlyPayment()
        {
            System.Console.WriteLine("Enter amount for Principal load(P), Year to pay off(Y) and Percentage Interest(R) ");
            double P = Convert.ToDouble(Console.ReadLine());
            int Y = Convert.ToInt32(Console.ReadLine());
            double R = Convert.ToDouble(Console.ReadLine());

            int n = 12 * Y;
            double r = R / (12 * 100);
            double temp = Convert.ToDouble(Math.Pow(1-(1+r),(-n)));

            double payment = P * r / temp;

            System.Console.WriteLine("Monthly Payment is : "+payment);
        }
    }
}