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
                s=s.Remove(0,1).Insert(0, currentLetter.ToUpper()); //capitalize the first letter

                //process the "core" of the string
                for (int i = 1; i < s.Length - 1; i++)
                {
                     currentLetter = s[i].ToString();
                    if (s[i + 1].ToString() == " " || s[i - 1].ToString() == " ")
                    {
                        s=s.Remove(i,1).Insert(i, currentLetter.ToUpper());
                    }
                }

                currentLetter = s[s.Length-1].ToString();  //get the last letter from the string
                s=s.Remove(s.Length-1,1).Insert(s.Length-1, currentLetter.ToUpper()); //capitalize the last letter
            }
            return s;
        }


    }
}
