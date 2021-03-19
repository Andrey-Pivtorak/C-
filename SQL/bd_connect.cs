/*
Program.cs

using System;
using System.Linq;

namespace BaseAppConnect
{
    class Program
    {
        static void Main(string[] args)
        {
            using (baseappdbContext db = new baseappdbContext())
            {
                // отримую об'єкти з БД і виводжу на консоль
                var users = db.Users.ToList();
                Console.WriteLine("Список обьектов:");
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }
            Console.ReadKey();
        }
    }
}
*/
