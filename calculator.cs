using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=========================");
                Console.WriteLine("== C A L C U L A T O R ==");
                Console.WriteLine("=========================");

                double firstValue, secondValue;
                string action;

                try
                {
                    Console.Write("Enter number 1: ");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.Write("Enter number 2: ");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR: Wrong the number!");
                    Console.ReadKey();
                    continue;
                }
                
                Console.Write("Enter the operation: + - / *: ");
                action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        Console.Write($"{firstValue} + {secondValue} = ");
                        Console.Write(firstValue + secondValue);
                        break;
                    case "-":
                        Console.Write($"{firstValue} - {secondValue} = ");
                        Console.Write(firstValue - secondValue);
                        break;
                    case "/":
                        if (secondValue == 0)
                            Console.WriteLine("The second number won't be zero!");
                        else
                            Console.Write($"{firstValue} / {secondValue} = ");
                        Console.Write(firstValue / secondValue);
                        break;
                    case "*":
                        Console.Write($"{firstValue} * {secondValue} = ");
                        Console.Write(firstValue * secondValue);
                        break;
                    default:
                        Console.WriteLine("ERROR: Wrong the operation!");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
