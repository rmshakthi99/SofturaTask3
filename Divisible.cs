using System;
using System.Collections.Generic;
using System.Text;
//question1:  Create a program that will take 10 numbers from user. And print the numbers that are divisible by 7
namespace TaskProject
{
    class Divisible
    {
        public static void Main(String[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("Ente 10 numbers");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 7 == 0)
                    Console.WriteLine("numbers divisible by 7 " + arr[i]);
            }
        }
    }
}















