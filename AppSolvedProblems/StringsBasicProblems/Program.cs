using System;
using System.Text;

namespace StringsBasicProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Here are some basic problems about strings");
            //1. Write a method that to remove the nth index character from a nonempty string.
            Console.WriteLine(removeNthCharacter("Ionel Ionelule", 5));
            //2. Write a method that to remove the characters which have odd index values of a given string.
            Console.WriteLine(removeOddCharacters("Scoala Informala de IT"));
            //3. Write a method that takes input from the user and displays that input back in upper and lower cases.
            //DisplayUpperAndLower();
            //4. Write a method that reverses a string if it's length is a multiple of 4
            Console.WriteLine(Reverse4("abcd1234"));
            //5. Write method to convert a given string to all uppercase if it contains at least 2 uppercase characters in the first 4 characters.
            Console.WriteLine(ConvertToUpper4("IoNElule"));
            //6. Write a method that to remove a newline.
            Console.WriteLine(RemoveNewLine("Ionel spune pe randul urmator \n o noua propozitie"));
            //7. Write a method to display formatted text (width=50) as output. For example: If I have a text that's 134 characters long, the formatted string should have maximum of 50 characters per line. In this case we will have 3 lines of text.
            DisplayRow50("Write a method to display formatted text (width=50) as output. For example: If I have a text that's 134 characters long, the formatted string should have maximum of 50 characters per line. In this case we will have 3 lines of text.");
            //8. Write a method that formats a number with a percentage
            Console.WriteLine(FormatPercentage(0.256));
            //9. Write a method that reverses a string.
            Console.WriteLine(ReverseMyString("Distractie Maxima"));
            //10. Write a method that strips a set of characters from a string.
            StripMyString("Aici este un sir mare care va fi afisat pe cuvinte.", ' ');
            //11. Write a method that transforms to lowercase first n characters in a string
            Console.WriteLine(TransformLowerFirstN("AiCi ESTe un text demonstrativ", 8));
            //12. Write a method to capitalize first and last letters of each word of a given string.
            Console.WriteLine(CapitalizeWords("ana are mere"));
            //13. Write a method to compute sum of digits of a given string(if any).
            Console.WriteLine(SumOfDigitsFromString("Aici am valoare 45 si valoarea 32. Cat e suma cifrelor?"));
            //14. You will get a text from where you will need to clean the text because it contains a lot of strange characters that don’t belong there ( ^ <, > &+ @%$)
            Console.WriteLine(CleanMyText("Hi^>there<<I’m+ telling%%you, you &need% to$ do& your $homeworks. @Hate ^me^ %now% and %thank% me &later."));
            //15. Write a method to add 'ing' at the end of a given string (length should be at least 3). If the given string already ends with 'ing' then add 'ly' instead. If the string length of the given string is less than 3, leave it unchanged.
            Console.WriteLine(IngLy("abc")); Console.WriteLine(IngLy("string"));
            //16. You have some text that contains your email address. And you want to hide that. You decide to censor your email: to replace all characters in it with asterisks ('*') except the domain. Assume your email address will always be in format [username]@[domain]. You need to replace the username with asterisks of equal number of letters and keep the domain unchanged. You will get as input the email address you need to obfuscate
            Console.WriteLine(ObfucateEmail("doctav@yahoo.com"));
            //17. Write a method to get a string made of the first 2 and the last 2 chars from a given a string. If the string length is less than 2, return instead of the empty string.
            Console.WriteLine(RestringFirstLast2("w3resource"));
            Console.WriteLine(RestringFirstLast2("W3"));
            Console.WriteLine(RestringFirstLast2("A"));
            //18. Write a method to get a string from a given string where all occurrences of its first char have been changed to '$', except the first char itself.
            Console.WriteLine(ReplaceMyChar("restart"));
            //19. Write a method to get a single string from two given strings, separated by a space and swap the first two characters of each string.
            Console.WriteLine(SwapMyStrings("abc", "xyz"));
            //20. Write a method to find the first appearance of the substring 'not' and 'poor' from a given string, if 'not' follows the 'poor', replace the whole 'not'...'poor' substring with 'good'. Return the resulting string.
            Console.WriteLine(ReplaceNotPoor("The lyrics is not that poor!"));
            //21. Write a method that takes a list of words and returns the length of the longest one.
            Console.WriteLine(LongestWord("Aici este un text si aflam lungimea celui mai mare cuvant din el"));
            //22. Write a method to get the last part of a string before a specified character.
            Console.WriteLine(LastPart("Sa aflam cuvintele pana aici-de aici incolo nu mai vrem cuvinte", '-'));
            //23. Write a method to check whether a string starts with specified characters
            Console.WriteLine(StartWithLetters("Ana are mere...", "Ana"));
            //24. Write a method to count occurrences of a substring in a string
            Console.WriteLine(CountOccurrences("Aici e un text cu text repetitiv de tip text", "text"));
            //25. Write a method to swap comma and dot in a string.
            Console.WriteLine(SwapCommaDot("32.054,23"));
            //26.         //26. Check if a string is palindrome (same value read from left to right and right to left) Ex: alabala -> True

            Console.WriteLine(IsPalindrome("alabala"));
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
                n = s.Length - 1;

            for (int i = n - 1; i >= 0; i = i - 2)  //remove odd characters from last to first
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
            if (s.Length % 4 == 0)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = s.Length - 1; i >= 0; i--) //get every char from initial string
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

        //5. Write method to convert a given string to all uppercase if it contains at least 2 uppercase characters in the first 4 characters.
        static string ConvertToUpper4(string s)
        {
            int numberOfUpperCases = 0;
            for (int i = 0; i < 4; i++)  //count the uppercases in the first 4 cases
            {
                if (s[i].ToString().Equals(s[i].ToString().ToUpper()))
                    numberOfUpperCases++;
            }

            if (numberOfUpperCases >= 2)
                return s.ToUpper();
            else
                return s;
        }

        //6. Write a method that to remove a newline.
        static string RemoveNewLine(string s)
        {
            //int position;
            //position = s.IndexOf("\n");   //the index is not good :(
            //Console.WriteLine("position = " + position);
            //remove the new line (2 characters)
            //s.Remove(position, 2);
            s = s.Replace("\n", String.Empty);
            return s;
        }

        //7. Write a method to display formatted text (width=50) as output. For example: If I have a text that's 134 characters long, the formatted string should have maximum of 50 characters per line. In this case we will have 3 lines of text.
        static void DisplayRow50(string s)
        {
            while (s.Length >= 50)
            {
                Console.WriteLine(s.Substring(0, 50));  //the first 50 chars from the string
                s = s.Substring(49);  //the rest of the string
            }
            Console.WriteLine(s); //the "last tie"
        }

        //8. Write a method that formats a number with a percentage
        static string FormatPercentage(double d)
        {
            return d.ToString("P2");
        }

        //9. Write a method that reverses a string.
        static string ReverseMyString(string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }
            return sb.ToString();
        }

        //10. Write a method that strips a set of characters from a string.
        static void StripMyString(string s, char c)
        {
            string[] subsiruri = s.Split(c);
            for (int i = 0; i < subsiruri.Length; i++)
            {
                Console.WriteLine(subsiruri[i].ToString());
            }
        }

        //11. Write a method that transforms to lowercase first n characters in a string
        static string TransformLowerFirstN(string s, int n)
        {
            string sirInitial = s.Substring(0, n);
            sirInitial = sirInitial.Replace(sirInitial, sirInitial.ToLower());
            return sirInitial + s.Substring(n);
        }

        //12. Write a method to capitalize first and last letters of each word of a given string.
        static string CapitalizeWords(string s)
        {
            string currentLetter;
            if (s.Length > 0)
            {
                currentLetter = s[0].ToString();  //get the first letter from the string
                s = s.Remove(0, 1).Insert(0, currentLetter.ToUpper()); //capitalize the first letter

                //process the "core" of the string
                for (int i = 1; i < s.Length - 1; i++)
                {
                    currentLetter = s[i].ToString();
                    if (s[i + 1].ToString() == " " || s[i - 1].ToString() == " ")
                    {
                        s = s.Remove(i, 1).Insert(i, currentLetter.ToUpper());
                    }
                }

                currentLetter = s[s.Length - 1].ToString();  //get the last letter from the string
                s = s.Remove(s.Length - 1, 1).Insert(s.Length - 1, currentLetter.ToUpper()); //capitalize the last letter
            }
            return s;
        }


        //13. Write a method to compute sum of digits of a given string(if any).
        static int SumOfDigitsFromString(string s)
        {
            int sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].CompareTo('0') >= 0 && s[i].CompareTo('9') <= 0) //check is the current letter is a digit
                {
                    sum = sum + int.Parse(s[i].ToString());
                }
            }

            return sum;
        }

        //14. You will get a text from where you will need to clean the text because it contains a lot of strange characters that don’t belong there ( ^ <, > &+ @%$)
        static string CleanMyText(string s)
        {
            string[] badValues = new string[] { "^", "<", ",", ">", "$", "&", "@", "+", "%", "&+", "@%$" };
            for (int i = 0; i < badValues.Length; i++)
            {
                s = s.Replace(badValues[i], " ");
                
            }

            return s;
        }

        //15. Write a method to add 'ing' at the end of a given string (length should be at least 3). If the given string already ends with 'ing' then add 'ly' instead. If the string length of the given string is less than 3, leave it unchanged.
        static string IngLy(string s)
        {
            if (s.Length >= 3)
            {
                if (s.Substring(s.Length - 3) == "ing")
                    s = s + "ly";
                else
                    s = s + "ing";
            }
            return s;
        }

        //16. You have some text that contains your email address. And you want to hide that. You decide to censor your email: to replace all characters in it with asterisks ('*') except the domain. Assume your email address will always be in format [username]@[domain]. You need to replace the username with asterisks of equal number of letters and keep the domain unchanged. You will get as input the email address you need to obfuscate
        //Input: awesome@dotnet.com
        //Output: *******@dotnet.com
        static string ObfucateEmail(string email)
        {
            int position = email.IndexOf("@");
            //build the hidden string with "*"
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < position; i++)
            {
                sb.Append("*");
            }
            //generate the obfucate email address
            return string.Concat(sb, email.Substring(position));
        }

        //17. Write a method to get a string made of the first 2 and the last 2 chars from a given a string. If the string length is less than 2, return instead of the empty string.
        static string RestringFirstLast2(string s)
        {
            if (s.Length < 2)
                return string.Empty;
            else
                return s[0].ToString() + s[1].ToString() + s[s.Length - 2].ToString() + s[s.Length - 1].ToString();
        }

        //18. Write a method to get a string from a given string where all occurrences of its first char have been changed to '$', except the first char itself.
        static string ReplaceMyChar(string s)
        {
            if (s.Length == 0)
            {
                return s;
            }

            char firstChar = s[0];
            return s[0].ToString() + s.Substring(1).Replace(firstChar, '$');
        }

        //19. Write a method to get a single string from two given strings, separated by a space and swap the first two characters of each string.
        static string SwapMyStrings(string s1, string s2)
        {
            return s2[0].ToString() + s2[1].ToString() + s1.Substring(2) + " " + s1[0].ToString() + s1[1].ToString() + s2.Substring(2);
        }

        //20. Write a method to find the first appearance of the substring 'not' and 'poor' from a given string, if 'not' follows the 'poor', replace the whole 'not'...'poor' substring with 'good'. Return the resulting string.
        static string ReplaceNotPoor(string s)
        {
            int notPosition = s.IndexOf("not");
            int poorPosition = s.IndexOf("poor");

            if (poorPosition > notPosition)   //replace not...poor with good
            {
                s = s.Substring(0, notPosition - 1).ToString() + " good" + s.Substring(poorPosition + 4).ToString();
            }
            return s;
        }

        //21. Write a method that takes a list of words and returns the length of the longest one.
        static int LongestWord(string s)
        {
            string[] words = s.Split(" ");
            int maxLength = words[0].Length;

            for (int i = 1; i < words.Length; i++)
            {
                if (maxLength < words[i].Length)
                    maxLength = words[i].Length;
            }

            return maxLength;
        }

        //22. Write a method to get the last part of a string before a specified character.
        //Input :  https://www.siit.com/net-exercises
        //Output:  https://www.siit.com/net
        static string LastPart(string s, char c)
        {
            return s.Substring(0, s.LastIndexOf(c));
        }

        //23. Write a method to check whether a string starts with specified characters
        //input: awesome string
        //               a
        //output : Yes, starts with a
        static string StartWithLetters(string s, string c)
        {
            if (s.IndexOf(c) == 0)
                return $"Yes, starts with {c}";
            else
                return $"No, it doesn't start with {c}";
        }


        //24. Write a method to count occurrences of a substring in a string
        static int CountOccurrences(string s, string substring)
        {
            int countOccurrences = 0;
            while (s.IndexOf(substring) >= 0)  //still have substrings in the string
            {
                countOccurrences++;
                s = s.Remove(s.IndexOf(substring), substring.Length);
            }
            return countOccurrences;
        }

        //25. Write a method to swap comma and dot in a string.

        static string SwapCommaDot(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i].ToString() == ",")
                {
                    //change comma in a dot
                    s = s.Remove(i, 1).Insert(i, ".");
                    i++;
                }

                if(s[i].ToString() ==".")
                {
                    //change dot in a comma
                    s = s.Remove(i, 1).Insert(i, ",");
                    i++;
                }
            }

            return s;
        }

        //26. Check if a string is palindrome (same value read from left to right and right to left) Ex: alabala -> True
        static bool IsPalindrome(string s)
        {
            bool isPalindrome = true;
            int n = s.Length / 2;
            int i= 0;
            while(isPalindrome && i<=n)
            {
                if (s[i].ToString() != s[s.Length - 1 - i].ToString())
                    isPalindrome = false;
                i++;  //next char in the string
            }
            return isPalindrome;
        }

    }
}
