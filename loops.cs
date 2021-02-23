/*
using System;

namespace Firstproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter two numbers:");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine($"Number 1 > Number 2");
            }
            else if (x < y)
            {
                Console.WriteLine("Number 1 < Number 2");
            }
            else
            {
                Console.WriteLine("Number 1 = Number 2");
            }

        }
    }
}
*/

/*
using System;

namespace Firstproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 5 && number < 10)
            {
                Console.WriteLine("The number is more 5 and less 10");
            }
            else
            {
                Console.WriteLine("The number is unknown!");
            }
            Console.ReadKey();
        }
    }
}
*/

/*
using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number 5 or 10:");
            /*string number = Console.ReadLine();
            switch(number)
            {
                case "5":
                    Console.WriteLine("The number is 5");
                    break;
                case "10":
                    Console.WriteLine("The number is 10");
                    break;
                default:
                    Console.WriteLine("This number is unknown!");
                    break;
            }*/
            /* 
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 5 || number == 10)
            {
                Console.WriteLine("The number is 5 or 10");
            }
            else
            {
                Console.WriteLine("This number is unknown!");
            }
            Console.ReadKey();
        }
    }
}
*/

/*
using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the deposit amount, $:");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (amount < 100)
            {
                amount += amount * 0.05;
            }
            else if (amount > 100 && amount < 200)
            {
                amount += amount * 0.07;
            }
            else
            {
                amount += amount * 0.1;
            }
            Console.WriteLine($"Yout total amount is {amount}$.");
            Console.ReadKey();
        }
    }
}
*/

/*
using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the investment amount: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter the number of months: ");
            int num_months = Convert.ToInt32(Console.ReadLine());
            int count = 1;
            
            while (count <= num_months)
            {
                amount += amount * 0.07M;
                count++;
            }
            Console.WriteLine($"You'll have total amount {amount}$");
        }
    }
}
*/

/*
using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the deposit amount, $:");
            double amount = Convert.ToDouble(Console.ReadLine());
            double bonus = 15;
            double total_amount = 0;
            if (amount < 100)
            {
                amount += amount * 0.05;
            }
            else if (amount > 100 && amount < 200)
            {
                amount += amount * 0.07;
            }
            else
            {
                amount += amount * 0.1;
            }
            Console.WriteLine($"Yout total amount is {amount}$.");
            total_amount += amount + bonus;
            Console.WriteLine($"Yout total amount with bonus is {total_amount}$.");
            Console.ReadKey();
        }
    }
}
*/
