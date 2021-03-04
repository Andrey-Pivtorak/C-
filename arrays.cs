/*
using System;

namespace Studyproject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] mas = { { { 1, 2 }, { 3, 4 } },
                            { { 4, 5 }, { 6, 7 } },
                            { { 7, 8 }, { 9, 10 } },
                            { { 10, 11 }, { 12, 13 } } 
                          };

            int x = mas.GetUpperBound(0);
            int y = mas.GetUpperBound(1);
            int z = mas.GetUpperBound(2);

            Console.Write("{");
            for (int i = 0; i <= x; i++)
            {
                Console.Write("{");
                for (int j = 0; j <= y; j++)
                {
                    Console.Write("{");
                    for (int k = 0; k <= z; k++)
                    {
                        Console.Write(mas[i, j, k]);
                        if (k < z)
                            Console.Write(" , ");
                    }
                    Console.Write("}");
                    if (j < y)
                        Console.Write(" , ");                 
                }
                Console.Write("}");
                if (i < x)
                    Console.Write(" , ");
            }
            Console.Write("}");
            Console.ReadLine();

        }
    }
}
*/

/*
result
{{{1 , 2} , {3 , 4}} , {{4 , 5} , {6 , 7}} , {{7 , 8}, {9 , 10}} , {{10 , 11} , {12 , 13}}}
*/

/*
using System;

namespace SortApp
{
    class Program
    {
        static void Main(string[] args)
        {   
            // entering numbers
            int[] nums = new int[7];
            Console.WriteLine("Please, enter 7 numders:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"Number {i+1}: ");
                nums[i] = Int32.Parse(Console.ReadLine());
            }

            // sorting numbers
            int temp;
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            // output
            Console.WriteLine("Output the sorted array:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]} ");
            }
            Console.ReadLine();
        }
    }
}
*/

/*
using System;

namespace StudyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the numbers of elements:\t");
            int elementsCount = int.Parse(Console.ReadLine());
            
            int[] myArray = new int[elementsCount];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"\nEnter the element of array with index {i}:\t");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nThe array out: ");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            
            Console.ReadKey();
        }
    }
}
*/

/*
using System;

// Entering numbers from the keyboard in reverce order
namespace StudyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the number of array elements: ");
            int elementsNumber = int.Parse(Console.ReadLine());
            int[] myArray = new int[elementsNumber];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"\nEnter the element of array with index {i}:\t");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nThe array out: ");

            for (int i = myArray.Length-1; i >= 0; i--)
            {
                Console.Write(myArray[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
*/

// The sum of even and odd numbers
/*
using System;

namespace StudyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 34, 67, 24, 52, 4, 26, 8, 12 };
            
            int sumEvenNumbers = 0;
            int sumOddNumbers = 0;

            Console.WriteLine("Array output: ");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");

                if (myArray[i] % 2 == 0)
                {
                    sumEvenNumbers += myArray[i];
                }
                else
                {
                    sumOddNumbers += myArray[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("\nThe sum of even numbers is: " + sumEvenNumbers);
            Console.WriteLine("The sum of odd numbers is: " + sumOddNumbers);
            Console.ReadKey();
        }
    }
}
*/

// The min and max value of array.
/*
using System;

namespace StudyProject
{
    class Program
    {
        static  void Main(string[] args)
        {
            int[] myArray = { 7, 3, 8, 2, 7, 9 };
            int minValue = myArray[0];
            int maxValue = myArray[0];

            Console.WriteLine("Our array is:");

            for (int i = 1; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");

                if (minValue > myArray[i])
                {
                    minValue = myArray[i];
                }
                else if (maxValue < myArray[i])
                {
                    maxValue = myArray[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("\nThe least element of this array is " + minValue);
            Console.WriteLine("\nThe greatest element of this array is " + maxValue);
            Console.ReadKey();
        }
    }
}
*/

// The finding an index of the symbol
/*
using System;

namespace MethodProject
{
    class Program
    {
        static int IndexOff(int [] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        static int[] GetRandomArray(uint length, int minValue, int maxValue)
        {

            int[] myArray = new int[length];
            Random random = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(minValue, maxValue);
            }
            return myArray;
        }

        static void Main(string[] args)
        {
            int[] myArray = GetRandomArray(10, -20, 10);
            int result = IndexOff(myArray, 23);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
*/

// github !!! Resize array
/*
using System;

namespace StudyProject
{
    class Program
    {        
        static void Main(string[] args)
        {
            int[] myArray = { 2, 6, 1 };

            Console.WriteLine("The first array is:");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            
            Array.Resize(ref myArray, 2);

            Console.WriteLine();
            Console.WriteLine("The second array is:");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
*/
