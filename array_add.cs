// Adding the element in the beginning/end/index of array

using System;

namespace StudyProject
{
    class Program
    {
        static void InsertMiddle(ref int[] array, int value, int index)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[index] = value;

            for (int i = 0; i < index; i++)            
                newArray[i] = array[i];

            for (int i = index; i < array.Length; i++)            
                newArray[i + 1] = array[i];

            array = newArray;
        }

        static void InsertFirst(ref int[] array, int value)
        {
            InsertMiddle(ref array, value, 0);
        }

        static void InsertLast(ref int[] array, int value)
        {
            InsertMiddle(ref array, value, array.Length);
        }

        static void Main(string[] args)
        {
            int[] myArray = { 1, 4, 6, 2, 5 };
            
            Console.WriteLine("The firs array is:");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }

            // The variables of insert:
            Console.WriteLine("\nWhat do you want to do? Enter the number:");
            Console.WriteLine("\n1. The element insert in the middle of the array.");
            Console.WriteLine("2. The element insert in the beginning of the array.");
            Console.WriteLine("3. The element insert in the end of the array.\n");
            int result = int.Parse(Console.ReadLine());
                               
            switch (result)
            {
                case 1:
                    InsertMiddle(ref myArray, -5, 3);
                    break;
                case 2:
                    InsertFirst(ref myArray, -5);
                    break;
                case 3:
                    InsertLast(ref myArray, -5);
                    break;
                default:
                    Console.WriteLine("Unknown value! Try one more time !");
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
                Console.WriteLine("The array don't modify !!!");
            }         

            Console.ReadKey();
        }
    }
}
