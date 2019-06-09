using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Write a method to create an array of 5 integers and display the array items. Access individual elements and display them through indexes.
            FiveIntegers();
            //2. Write a method to reverse the order of the items in the array
            int[] vector = new int[] { 1, 2, 3, 4, 3 };
            vector = ReverseArray(vector);
            DisplayArray(vector);
            //3. Write a method to get the number of occurrences of a specified element in an array
            int cheie = 3;
            Console.WriteLine($"{cheie} appears {GetNumberOfOccurences(vector, cheie)} times");
            //4. Write a method to insert a new item before the second element in an existing array
            int[] newArray = InsertNewItem(vector, 77);
            DisplayArray(newArray);
            //5. Write a method to remove a specified item using the index from an array.
            vector = new int[] { 1, 2, 3, 4, 3 };
            int[] newArray2 = RemoveItemFromArray(vector, 3);
            DisplayArray(newArray2);
            //6. Write a program to find the sum of all elements of the array
            DisplayArray(vector);
            Console.WriteLine($"Sum of the array is: {SumOfArray(vector)}");
            //7. Write a program to print all unique elements in an array.
            vector = new int[] { 1, 2, 3, 4, 3 };
            PrintUniqueElements(vector);
            Console.WriteLine();
            //8. Write a program to find maximum and minimum element in an array.
            DisplayMinMax(vector);
            //9. Write a programin to separate odd and even integers in separate arrays
            vector = new int[] { 1, 2, 3, 4, 3, 6, 8, 0, 11 };
            SeparateOddEven(vector);
            //10. Write a program to sort elements of array in ascending order.
            SortAscending(vector);
            //11. Write a program to sort elements of the array in descending order.
            SortDescending(vector);
            //12. Write a program to find the second largest element in an array.
            SecondLargestElement(vector);
            //13. Write a program to find the second smallest element in an array.
            SecondSmallestElement(vector);
            //14. Write a program for a 2D array of size 3x3 and print the matrix.
            PrintTheMatrix();
            //15. Write a program in C# Sharp for addition of two Matrices of same size
            int[,] m1 = new int[,]
            {
                {10,20,30 },
                {40,50,60 }
            };
            int[,] m2 = new int[,]
            {
                {1,2,3 },
                {4,5,6 }
            };
            Add2Matrix(m1, m2);  //here is my method
        }

        //0. Method to display the content of an array
        public static void DisplayArray(int[] array)
        {
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        //1. Write a method to create an array of 5 integers and display the array items. Access individual elements and display them through indexes.
        public static void FiveIntegers()
        {
            int[] vector = new int[] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Item no. {i} has value {vector[i]}");
            }
        }

        //2. Write a method to reverse the order of the items in the array
        public static int[] ReverseArray(int[] vector)
        {
            int n = vector.Length;
            int[] reversedArray = new int[n];
            for (int i = 0; i < vector.Length; i++)
            {
                reversedArray[n - 1 - i] = vector[i];
            }
            return reversedArray;
        }

        //3. Write a method to get the number of occurrences of a specified element in an array
        public static int GetNumberOfOccurences(int[] array, int key)
        {
            int numberOfOccurences = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key)
                {
                    numberOfOccurences++;
                }
            }
            return numberOfOccurences;
        }

        //4. Write a method to insert a new item before the second element in an existing array
        public static int[] InsertNewItem(int[] array, int newValue)
        {
            if (array.Length >= 2)
            {
                int[] newArray = new int[1 + array.Length];
                newArray[0] = array[0];
                newArray[1] = newValue;
                for (int i = 1; i < array.Length; i++)
                {
                    newArray[i + 1] = array[i];
                }
                return newArray;
            }
            else
            {
                return array;
            }
        }

        //5. Write a method to remove a specified item using the index from an array.
        public static int[] RemoveItemFromArray(int[] array, int index)
        {
            if (index >= 0 && index < array.Length)
            {
                int[] newArray = new int[array.Length - 1];
                for (int i = 0; i < index; i++)
                {
                    newArray[i] = array[i];
                }
                for (int j = index + 1; j < array.Length; j++)
                {
                    newArray[j - 1] = array[j];
                }
                return newArray;
            }
            else
            {
                return array;
            }
        }

        //6. Write a program to find the sum of all elements of the array
        public static int SumOfArray(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        //7. Write a program to print all unique elements in an array.
        public static void PrintUniqueElements(int[] array)
        {
            Console.WriteLine("Unique elements: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (GetNumberOfOccurences(array, array[i]) == 1)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }

        //8. Write a program to find maximum and minimum element in an array.
        public static void DisplayMinMax(int[] array)
        {
            int min = array[0];
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Max = {max}, min = {min}");
        }

        //9. Write a programin to separate odd and even integers in separate arrays
        public static void SeparateOddEven(int[] array)
        {
            int[] odd = new int[0];
            int[] even = new int[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Array.Resize(ref even, 1 + even.Length);
                    even[even.Length - 1] = array[i];
                }
                if (array[i] % 2 == 1)
                {
                    Array.Resize(ref odd, 1 + odd.Length);
                    odd[odd.Length - 1] = array[i];
                }
            }
            Console.WriteLine("Odd");
            DisplayArray(odd);
            Console.WriteLine("Even");
            DisplayArray(even);
        }

        //10. Write a program to sort elements of array in ascending order.
        public static void SortAscending(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted values (ascending order)");
            DisplayArray(array);
        }


        //11. Write a program to sort elements of the array in descending order.
        public static void SortDescending(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted values (descending order)");
            DisplayArray(array);
        }

        //12. Write a program to find the second largest element in an array.
        public static void SecondLargestElement(int[] array)
        {
            if (array.Length >= 2)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] < array[j])
                        {
                            int temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
                Console.WriteLine($"The second largest element is {array[1]}");
            }
        }

        //13. Write a program to find the second smallest element in an array.
        public static void SecondSmallestElement(int[] array)
        {
            if (array.Length >= 2)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] < array[j])
                        {
                            int temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
                Console.WriteLine($"The second smallest element is {array[array.Length - 2]}");
            }
        }

        //14. Write a program for a 2D array of size 3x3 and print the matrix.
        public static void PrintTheMatrix()
        {
            int[,] matrice = {{10,20,30 },
                { 40,50,60 },
                { 70,80,90 }
                };
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    Console.Write(matrice[i, j] + " ");
                }
            }
            Console.WriteLine();
        }


        //15. Write a program in C# Sharp for addition of two Matrices of same size
        public static void Add2Matrix(int[,] matrix1, int[,] matrix2)
        {
            //check if the dimensions are the same
            if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
            {
                Console.WriteLine("Matrix have DIFFERENT dimensions!!!");
                return;
            }
            
            //now let's add the values from the matrix
            int[,] matrix3 = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            //print the matrix with the results
            for (int i = 0; i < matrix3.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < matrix3.GetLength(1); j++)
                {
                    Console.Write(matrix3[i, j] + " ");
                }
            }
            Console.WriteLine();  //a new line
        }
        
    }
}
