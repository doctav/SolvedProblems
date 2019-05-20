using System;

namespace StringsAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problems solved for: https://github.com/irinascurtu/siit-net/blob/master/strings-advanced.md");
            
            //1. Middle Characther
            Console.WriteLine(MiddleCharacter("test"));
            Console.WriteLine(MiddleCharacter("testing"));

            //2. The goal of this kata is to write a function that takes two inputs: a string and a character. The function will count the number of times that character appears in the string. The count is case insensitive.
            Console.WriteLine(CountMyChar("fizzbuzz", 'z'));
        }

        //1. Middle Characther
        //You are going to be given a word.Your job is to return the middle character of the word. If the word's length is odd, return the middle character. If the word's length is even, return the middle 2 characters.
        static string MiddleCharacter(string s)
        {
            if (s.Length % 2 == 0) //not odd length
            {
                return s[(s.Length / 2) - 1].ToString() + s[s.Length / 2].ToString();
            }
            else  //odd length
                return s[(s.Length / 2)].ToString();
        }

        //2. The goal of this kata is to write a function that takes two inputs: a string and a character. The function will count the number of times that character appears in the string. The count is case insensitive.
        static int CountMyChar(string s, char c)
        {
            int countOccurrences = 0;
            while (s.IndexOf(c) >= 0)  //still have substrings in the string
            {
                countOccurrences++;
                s = s.Remove(s.IndexOf(c), 1);
            }
            return countOccurrences;
        }
    }
}
