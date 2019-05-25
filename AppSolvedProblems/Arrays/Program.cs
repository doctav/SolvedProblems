using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] v1 = new int[] { 1, 2, 3, 4, 5 };
            int[] v2;
            v2 = v1;
            v1[0] = 100;
            Console.WriteLine(v2[0]);
        }
    }
}
