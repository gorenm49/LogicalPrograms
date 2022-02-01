using System;

namespace LogicalPrograms
{
    public class Temperature
    {
        public void temperaturConversion()
        {
            System.Console.WriteLine("choose Option:\n 1. Celsius  to fahrenheit \n 2. fahrenheit to Celsius \n 3.Break\n");
            int num = int.Parse(Console.ReadLine());
            double fahrenheit = 0.0, celsius = 0.0;

            switch (num)
            {
                case 1:
                    System.Console.WriteLine("Enter value in Celsius for conversion: ");
                    celsius  = Convert.ToDouble(Console.ReadLine());
                    fahrenheit = (celsius * 9/5)+32;
                    System.Console.WriteLine("fahrenheit : "+fahrenheit);
                    break;
                case 2:
                    System.Console.WriteLine("Enter value in fahrenheit for Conversion: ");
                    fahrenheit = Convert.ToDouble(Console.ReadLine()) ;
                    celsius = (fahrenheit - 32) * 5/9;
                    System.Console.WriteLine("Celsious: "+celsius);
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