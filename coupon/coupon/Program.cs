using System;
using System.Collections.Generic;
using System.Text;
namespace Day6
{
    class couponNumber
    {
        //public void coupons(int n)//n=5
        public static void Main(string[] args)
       
        {

            int n = 100000000;
            Random ran = new Random();
            //n = ran.Next(10000, 9999999);
            int check = ran.Next(1, 9);
            //Console.WriteLine("enter the coupon limit");
            int count = 0;
            Console.WriteLine("coupon number is: " + n);
            while (n > 0)
            {
                if (check == n)
                {
                    Console.WriteLine("number is present");
                    break;
                }
                count++;
                Console.WriteLine("count :" + count);
                n--;
            }
            Console.WriteLine("to get  number we need count " + count);
        }
    }
}
