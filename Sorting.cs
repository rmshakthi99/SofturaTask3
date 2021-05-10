using System;
using System.Collections.Generic;
using System.Text;

namespace TaskProject
{
    //question4:Create a program that will take positive numbers from user until the user enters 0 and print back the numbers in ascending order
    class Sorting
    {
        public static void Main(String[] args)
        {
            int n;
            List<int> asc = new List<int>();
            Console.WriteLine("enter numbers");
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                asc.Add(n);
            } while (n != 0);

            for (int i = 1; i < asc.Count; i++)
            {
                asc.Sort();
                Console.WriteLine(asc[i]);

            }
        }
    }
}

