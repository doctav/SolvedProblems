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

            //3. Facebook like
            string[] names = new string[] { "John", "Mark", "Tavy", "Elsa" };
            Console.WriteLine(FacebookLike(names));

            //4. Ho ho ho!!! Santa Claus
            Console.WriteLine(Ho());
            Console.WriteLine(Ho(Ho(Ho())));
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

        ////3. You probably know the "like" system from Facebook and other pages. People can "like" blog posts, pictures or other items. We want to create the text that should be displayed next to such an item.
        //Implement a function likes :: [String] -> String, which must take in input array, containing the names of people who like an item.It must return the display text as shown in the examples:
        //likes[] // must be "no one likes this" likes ["Peter"] // must be "Peter likes this" likes ["Jacob", "Alex"] // must be "Jacob and Alex like this" likes ["Max", "John", "Mark"] // must be "Max, John and Mark like this" likes ["Alex", "Jacob", "Mark", "Max"] // must be "Alex, Jacob and 2 others like this"
        static string FacebookLike(string[] s)
        {
            if (s.Length == 0)
                return "No one likes this";
            if (s.Length == 1)
                return s[0] + " likes this.";
            if (s.Length == 2)
                return s[0] + " and " + s[1] + " like this.";
            if (s.Length == 3)
                return s[0] + "," + s[1] + " and " + s[2] + " like this.";
            return s[0] + ", " + s[1] + " and " + (s.Length - 2).ToString() + " others like this.";
        }

        //4. Ho ho ho!!! Santa Claus
        //Santa is learning programming.And what could be the first program, he wants to write? Yes, the "Hello world!" of Christmas: "Ho Ho Ho!". He wants to write a function ho(), which should have the following return values:
        //ho(); // should return "Ho!" ho(ho()); // should return "Ho Ho!" ho(ho(ho())); // should return "Ho Ho Ho!" Unfortunately he couldn't find any tutorial, which explains, how he could implement that. Can you help him?
        //Rules:
        //each call of ho() must add a "Ho" to the string the "Ho"'s must be separated by a space at the end of the string, there must be an exclamation mark (!), without a space
        static string Ho()
        {
            return "Ho!";
        }
        static string Ho(string s)
        {
            return "Ho " + s.ToLower();
        }
    }
}
