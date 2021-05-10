using System;
using System.Collections.Generic;
using System.Text;

namespace TaskProject
{
    //question3 :Create a program that will take numbers from user until the users enters a negative number and print the numbers that are repeating
    class RepeatingNumbers
    {
        public static void Main(String[] args)
        {
            int n;
            List<int> rep = new List<int>();
            Console.WriteLine("enter numbers");
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                rep.Add(n);
            } while (n >= 0);
            Console.WriteLine("the repeating numbers are:");
            for (int i = 0; i < rep.Count; i++)
            {
                for (int j = i + 1; j < rep.Count; j++)
                {
                    if (rep[i] == rep[j])
                    {
                        Console.WriteLine(rep[j]);
                    }
                }
            }
        }
    }
}

            
