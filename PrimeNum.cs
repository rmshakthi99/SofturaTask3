using System;
using System.Collections.Generic;
using System.Text;

namespace TaskProject
{
    //question2:Create a program that will take a min and a max value from user and print all the prime numbers between it.
    class PrimeNum
    {
        public static void Main(String[] args)
        {
            int n, i, a, b, count;
            Console.WriteLine("enter the minimum value");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the maximum value");
            b = Convert.ToInt32(Console.ReadLine());
            for (n = a; n <= b; n++)
            {
                count = 0;
                for (i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0)
                    Console.WriteLine(n);

            }
        }
    }
}

                 
    

