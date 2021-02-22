using System;


namespace Studyproject
{
    class Program
    {
        static void Main(string[] args)
        {
            uint oddNumbersCount = 0;
            uint evenNumbersCount = 0;

            Console.Write("Enter the start number: ");
            int currentValue = int.Parse(Console.ReadLine());
            Console.Write("Enter the finish number: ");
            int limit = int.Parse(Console.ReadLine());

            int oddNumbersSum = 0;
            int evenNumbersSum = 0;

            while (currentValue <= limit)
            {
                if (currentValue % 2 == 0)
                {
                    evenNumbersCount++;
                    evenNumbersSum += currentValue;
                }
                else
                {
                    oddNumbersCount++;
                    oddNumbersSum += currentValue;
                }
                currentValue++;
            }

            Console.WriteLine();
            Console.WriteLine("Number of odd numbers: " + oddNumbersCount);
            Console.WriteLine("Number of even numbers: " + evenNumbersCount);
            Console.WriteLine();
            Console.WriteLine("Total sum of odd numbers: " + oddNumbersSum);
            Console.WriteLine("Total sum of even numbers: " + evenNumbersSum);

            Console.ReadKey();
        }
    }
}
