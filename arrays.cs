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
