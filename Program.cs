using System;

namespace LogicalPrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number for select Option: \n 1. Fibonacci \n 2. Perfect Number \n 3. Prime Number \n 4. Reverse Number \n 5. Vending Machine \n 6. Monthly payment \n 7. Calendar \n 8. Temperature Calculation \n 9. Exit.\n ");
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
                    PrimeNumber pn = new PrimeNumber();
                    pn.prime();
                    break;
                case 4:
                    ReverseNumber rn = new ReverseNumber();
                    rn.reverse();
                    break;
                case 5:
                    VendingMachine vm = new VendingMachine();
                    vm.vending();
                    break;
                case 6:
                    Payment pay1 = new Payment();
                    pay1.monthlyPayment();
                    break;
                case 7:
                    Calendar c1 = new Calendar();
                    c1.dayOfWeek();
                    break;
                case 8:
                    Temperature t1 = new Temperature();
                    t1.temperaturConversion();
                    break;
                case 9:
                    break;
                default:
                    System.Console.WriteLine("Choose correct option..");
                    break;
            }           
       }
    }
}