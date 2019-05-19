using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Here are some basic solved problems...\n");
            //SumOfThreeFromConsole();
            //GreastestOfFiveNumbers();
            //CirclePerimeterAndArea();
            //DivisibleByFive();
            //GreaterOfTwo();
            //FiveIntegersAndSum();
            //WriteNNumbers();
            //PrintNumbersNotDivisible37();
            //SmallestAndLargest5();
        }

        //1. Write a program that reads from the console three numbers of type int and prints their sum.
        static void SumOfThreeFromConsole()
        {
            Console.WriteLine("1. Write a program that reads from the console three numbers of type int and prints their sum.");
            Console.WriteLine("Input 1st number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input 2nd number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Input 3rd number");
            int c = int.Parse(Console.ReadLine());

            int sum = a + b + c;
            Console.WriteLine($"The sume {a}+{b}+{c}={sum}.\n");
        }

        //2. Write a program that reads five numbers from the console and prints the greatest of them.
        static void GreastestOfFiveNumbers()
        {
            Console.WriteLine("2. Write a program that reads five numbers from the console and prints the greatest of them.");
            decimal currentNumber, max;
            Console.WriteLine("Input the number no. 1");
            currentNumber = decimal.Parse(Console.ReadLine());
            max = currentNumber;
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Input the number no." + (i + 1));
                currentNumber = decimal.Parse(Console.ReadLine());
                if (currentNumber > max)
                    max = currentNumber;
            }
            Console.WriteLine($"The greatest number is {max}\n");
        }

        //3. Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.
        static void CirclePerimeterAndArea()
        {
            Console.WriteLine("3. Write a program that reads from the console the radius \"r\" of a circle and prints its perimeter and area.");
            Console.WriteLine("Input the Radius");
            float radius = float.Parse(Console.ReadLine());
            double perimeter, area;
            perimeter = 2 * Math.PI * radius;
            area = Math.PI * radius * radius;
            Console.WriteLine($"The perimeter = {perimeter}. The area = {area}\n");
        }

        //4. Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist that are divisible with 5. such that the remainder of their division by 5 is 0.
        static void DivisibleByFive()
        {
            Console.WriteLine("4. Write a program that reads from the console two integer numbers  and prints how many numbers between them exist that are divisible with 5. such that the remainder of their division by 5 is 0.");
            int a, b;
            Console.WriteLine("Input the first number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number");
            b = int.Parse(Console.ReadLine());

            if(a>b)  //check if a<b. Otherwise, swap them.
            {
                int temp;
                temp = a;
                a = b;
                b = temp;
            }

            int numberOfDivisibleWithFive = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                    numberOfDivisibleWithFive++;
            }
            Console.WriteLine($"Between {a} and {b} the are {numberOfDivisibleWithFive} numbers divisible with 5.\n");
        }

        //5. Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional statements and with conditional statements.
        static void GreaterOfTwo()
        {
            Console.WriteLine("5. Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional statements and with conditional statements.");
            double a, b;
            Console.WriteLine("Input the first number");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number");
            b = double.Parse(Console.ReadLine());
            if(a>b)
                Console.WriteLine($"The greater is {a}");
            else
                Console.WriteLine($"The greater is {b}");
            //without conditional statement
            double max = a > b ? a : b;
            Console.WriteLine($"The greater is {max}\n");
        }

        //6. Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program should prompt the user to enter another number(only once)
        static void FiveIntegersAndSum()
        {
            Console.WriteLine("6. Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program should prompt the user to enter another number(only once)");
            int canRead = 0, i=1, sum=0;
            while(i<=5 && canRead<2)
            {
                Console.WriteLine($"Input the number with the index {i}");
                if(int.TryParse(Console.ReadLine(),out int currentNumber))
                {
                    sum = sum + currentNumber;
                }
                else
                {
                    //one more chance
                    canRead++;
                    i--;
                }
                //read the next number
                i++;
            }

            //check if all the numbers are ok
            if (canRead<2)
            {
                Console.WriteLine($"The sum is {sum}\n");
            }
            else
            {
                Console.WriteLine("Too many tries...Sorry...\n");
            }
            
        }

        //7. Write a program that prints on the console the numbers from 1 to N. The number N should be read from the standard input.
        static void WriteNNumbers()
        {
            Console.WriteLine("7. Write a program that prints on the console the numbers from 1 to N. The number N should be read from the standard input.");
            Console.WriteLine("Input N");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        //8. Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously. The number N should be read from the standard input.
        static void PrintNumbersNotDivisible37()
        {
            Console.WriteLine("8. Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously. The number N should be read from the standard input.");
            Console.WriteLine("Input N");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The numbers are:");
            for (int i = 1; i <= n; i++)
            {
                if(i%3!=0 && i%7!=0)
                    Console.WriteLine(i);
            }
        }

        //9. Write a program that reads from the console a series of 5 integers and prints the smallest and largest of them.
        static void SmallestAndLargest5()
        {
            int min, max, currentNumber;
            Console.WriteLine("9. Write a program that reads from the console a series of 5 integers and prints the smallest and largest of them.");
            Console.WriteLine("Input 1st number");
            currentNumber = int.Parse(Console.ReadLine());
            min = currentNumber;
            max = currentNumber;
            for (int i = 2; i <= 5; i++)
            {
                Console.WriteLine($"Input the {i}rd number");
                currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > max)
                    max = currentNumber;

                if (currentNumber < min)
                    min = currentNumber;
            }
            Console.WriteLine($"Max={max}, Min={min}");
        }

    }
}
