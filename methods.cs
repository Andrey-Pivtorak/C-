/*
using System;

namespace StudyMethods
{
    class Program
    {
        static int Sum(int value1, int value2)
        {
            return value1 + value2;
        }

        static void PrintResult(int result)
        {
            Console.WriteLine("The result of Add: " + result);
        }

        static void Main(string[] args)
        {
            int a, b, c;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = Sum(a, b);

            PrintResult(c);
            Console.ReadKey();
        }
    }
}
*/

// Entering the symbols from the keyboard
/*
using System;

namespace MethodsProject
{
    class Program
    {
        static void PrintString(string[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
        }

        static void EnterSymb(uint countNumb, string[] myArray)
        {
            for (int i = 0; i < countNumb; i++)
            {
                myArray[i] = Console.ReadLine();
            }
        }

        static  void Main(string[] args)
        {
            Console.Write("How many symbols want you enter? ");
            int numbSymbols = int.Parse(Console.ReadLine());
            string[] symbolArray = new string[numbSymbols];

            EnterSymb(numbSymbols, symbolArray);
            Console.WriteLine("Your array is:");
            PrintString(symbolArray);
            
            Console.ReadKey();               
        }
    }
}
*/
