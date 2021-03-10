// The sum of digits of a number using recursion
/*
using System;

namespace StudyProject
{
    class Program
    {
        static int SumDigits(int value)
        {
            if (value < 10 )
            {
                return value;
            }
           
            // the last number  // the next number without last number
            return value % 10 + SumDigits(value / 10);
        }

        static int SumDigits1(int value)
        {
            int result = 0;

            while (value > 0)
            {
                // the last number
                result += value % 10;
                // the next number without last number
                value /= 10;
            }             
            return result;
        }

        static void Main(string[] args)
        {
            int myValue = 7599;

            Console.WriteLine(SumDigits(myValue));
            Console.WriteLine();
            Console.WriteLine(SumDigits1(myValue));
            Console.ReadKey();
        }
    }
}
*/
