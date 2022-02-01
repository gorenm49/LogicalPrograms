using System;

namespace LogicalPrograms
{
    public class Calendar
    {
        public void dayOfWeek()
        {

            System.Console.WriteLine("Enter the date in (YYYY) (MM) (DD) format");
            int y = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int y1 = y - (14 - m) / 12; 
            int x = y1 + y1/4 - y1/100 + y1 /400; 
            int m1 = m + 12 * ((14 - m)/12)-2; 
            int d1 = (d + x + 31*m1 / 12) % 7; 
             
            int num =Convert.ToInt32(d1);
           
            switch (num)
            {
                case 1:
                    System.Console.WriteLine("Monday");
                    break;
                case 2:
                    System.Console.WriteLine("Tuesday");
                    break;
                case 3:
                    System.Console.WriteLine("Wednesday");
                    break;
                case 4:
                    System.Console.WriteLine("Thurday");
                    break;
                case 5:
                    System.Console.WriteLine("Friday");
                    break;
                case 6:
                    System.Console.WriteLine("saturday");
                    break;
                case 7:
                    System.Console.WriteLine("Sunday");
                    break;
                default:
                    System.Console.WriteLine("opps someting went a wrong, Enter correct date format..");
                    break;
            }
            

        }
    }
}