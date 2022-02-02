using System;

namespace LogicalPrograms
{
    public class CouponNumbers
    {
        Random random = new Random();
        int flag = 0,store=0;
        int [] temp;

        public int  coupon()
        {

            return random.Next(0,100);
        }

        public void checkCoupon()
        {
            System.Console.WriteLine("Enter value for N coupon generation:");
            int num = int.Parse(Console.ReadLine());

        
            for (int  i = 0; i < num; i++)
            {
                this.store  = Convert.ToInt32(coupon());

                for (int j = 0; i < i; i++)
                {
                    temp [j] = Convert.ToInt32(this.store);
                }    

            }

            for (int k = 0; k < temp.Length; k++)
            {
                if (temp[k].Equals(this.store))
                {
                    flag =1;
                }
                if (flag ==1)
                {
                    break;
                }
                {
                    System.Console.WriteLine(this.store);
                }
            }
            
        }
    }
}