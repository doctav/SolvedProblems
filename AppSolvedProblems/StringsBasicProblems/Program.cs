﻿using System;
using System.Text;

namespace StringsBasicProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Here are some basic problems about strings" );
            //1. Write a method that to remove the nth index character from a nonempty string.
            Console.WriteLine(removeNthCharacter("Ionel Ionelule",5));
            //2. Write a method that to remove the characters which have odd index values of a given string.
            Console.WriteLine(removeOddCharacters("Scoala Informala de IT"));
            //3. Write a method that takes input from the user and displays that input back in upper and lower cases.
            //DisplayUpperAndLower();
            //4. Write a method that reverses a string if it's length is a multiple of 4
            Console.WriteLine(Reverse4("abcd1234"));


        }

        //1. Write a method that to remove the nth index character from a nonempty string.
        static string removeNthCharacter(string s, int n)
        {
            if (s != string.Empty)
                return s.Remove(n, 1);
            else
                return s;
        }

        //2. Write a method that to remove the characters which have odd index values of a given string.
        static string removeOddCharacters(string s)
        {
            int n;  //last odd position in the string
            if (s.Length % 2 == 1)
                n = s.Length;
            else
                n = s.Length-1;
           
            for (int i = n-1; i >= 0; i = i - 2)  //remove odd characters from last to first
                s = s.Remove(i, 1);
            return s;
        }

        //3. Write a method that takes input from the user and displays that input back in upper and lower cases.
        static void DisplayUpperAndLower()
        {
            Console.WriteLine("3. Write a method that takes input from the user and displays that input back in upper and lower cases.");
            Console.WriteLine("Input your string");
            string s = Console.ReadLine();

            Console.WriteLine($"{s.ToUpper()}  ,  {s.ToLower()}");
        }

        //4. Write a method that reverses a string if it's length is a multiple of 4
        static string Reverse4(string s)
        {
            if(s.Length%4==0)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = s.Length-1; i >=0; i--) //get every char from initial string
                {
                    sb.Append(s[i]);
                }
                return sb.ToString();   //return the reversed string
            }
            else
            {
                return s;
            }
        }

    }
}