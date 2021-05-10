using System;
using System.Collections.Generic;
using System.Text;

namespace TaskProject
{
    //question 6: Play the Cow Bull game using an application
    //The application should have minimum 5 four letter words
    //First time when the game starts the user starts guessing the word.
   // If the user guessed word has the same letter in same position then it is score for “Cow” 
//If the user guessed word has the same letter in different position then it is score for “Bull” 

    class cowbull
    {
        public static void Main(String[] args)
        {
            string[] w = new string[5] { "kite", "four", "neat", "play", "goal" };
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j <4;j++)
                {
                    int cow = 0;
                    int bull = 0;
                    Console.WriteLine("enter the guess: ");
                    string s = Console.ReadLine();
                    char[] c = s.ToCharArray();
                    for (int k = 0; k <4;k++)
                    {
                        if (c[k] == w[i][k]) cow = cow + 1;
                        else if (c[k] == w[i][1] || c[k] == w[i][1] || c[k] == w[i][2] || c[k] == w[i][3]) bull = bull + 1;
                        

                    }

                    Console.WriteLine("cows-" + cow + " bulls-" + bull);

                    if (cow == 4 && bull == 0)
                    {
                        Console.WriteLine("you win!!!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("try again");
                        j++;
                    }
                }
                Console.WriteLine("you lost");
            }
        }
    }
}


        
    
