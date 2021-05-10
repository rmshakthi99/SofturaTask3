using System;
using System.Collections.Generic;
using System.Text;

namespace TaskProject
{
   // question 7: Write a program to validate a card
//4477 4683 4311 3002
//2003 1134 3864 7744
//2+0+0+6+1+2+3+8+3+16+6+8+7+14+4+8
//70%10 =0

    class CreditCardValidate
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter card number");
            string number = Console.ReadLine();
            int digit = 0;
            int sum = 0;
            for (int i = 0; i <= number.Length - 1; i++)
            {
                if (i % 2 == 0)
                {
                    digit = int.Parse(number.Substring(i, 1));
                    sum += DoubleDigitValue(digit);
                }
                else
                {
                    digit = int.Parse(number.Substring(i, 1));
                    sum += digit;
                }
            }
            if (sum % 10 == 0)
                Console.WriteLine("Card is valid");
            else
                Console.WriteLine("Card is invalid");
        }
        static int DoubleDigitValue(int digit)
        {
            int sum;
            int doubledigit = digit * 2;
            if (doubledigit >= 10)
            {
                sum = 1 + doubledigit % 10;
            }
            else
            {
                sum = doubledigit;
            }
            return sum;
        }
    }
}
   
