// github !!! delete the element in the beginning/end/index of array
/*
using System;

namespace StudyProject
{
    class Program
    {
        static void DeleteMiddle(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < index; i++)            
                newArray[i] = array[i];

            for (int i = index + 1; i < array.Length; i++)            
                newArray[i - 1] = array[i];

            array = newArray;
        }

        static void DeleteFirst(ref int[] array)
        {
            DeleteMiddle(ref array, 0);
        }

        static void DeleteLast(ref int[] array)
        {
            DeleteMiddle(ref array, array.Length - 1);
        }

        static void Main(string[] args)
        {
            int[] myArray = { 3, 6, 5, 2, 7 };            
            
            Console.WriteLine("The firs array is:");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            
            string key = "Y";

            while (key == "Y" || key == "y")
            {
                // The variables of insert:
                Console.WriteLine("\nWhat do you want to do? Enter the number:");
                Console.WriteLine("\n1. The element delete in the middle of the array.");
                Console.WriteLine("2. The element delete in the beginning of the array.");
                Console.WriteLine("3. The element delete in the end of the array.\n");
                int result = int.Parse(Console.ReadLine());

                switch (result)
                {
                    case 1:
                        DeleteMiddle(ref myArray, 2);
                        break;
                    case 2:
                        DeleteFirst(ref myArray);
                        break;
                    case 3:
                        DeleteLast(ref myArray);
                        break;
                    default:
                        Console.WriteLine("Unknown value!");
                        break;
                }

                if (result == 1 || result == 2 || result == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("The modified array is:");

                    for (int i = 0; i < myArray.Length; i++)
                    {
                        Console.Write(myArray[i] + " ");
                    }
                }
                else
                {
                    Console.WriteLine("The array don't modify. Try one more time !!!");
                }

                Console.WriteLine("\nDo you want to continue? y/n?");
                key = Console.ReadLine();
                Console.Clear();
            }            
        }
    }
}
*/
