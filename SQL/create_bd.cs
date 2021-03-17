/*
Program.cs

using System;
using System.Linq;

namespace BaseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;  // додається українська мова
            using (ApplicationContext db = new ApplicationContext())
            {
                // створюю 2 об'єкта User
                User user1 = new User { Name = "Sasha", Age = 25 };
                User user2 = new User { Name = "Oksana", Age = 27 };
                User user3 = new User { Name = "Sergiy", Age = 31 };

                // додаю їх в БД
                db.Users.Add(user1);
                db.Users.Add(user2);
                db.Users.Add(user3);
                db.SaveChanges();
                Console.WriteLine("Об'єкти успішно збережені.");

                // отримую об'єкти  із БД і виводжу їх на консоль
                var users = db.Users.ToList();
                Console.WriteLine("Список об'єктів:");
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

/*
User.cs

namespace BaseApp
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
*/

/*
ApplicationContex.cs

using Microsoft.EntityFrameworkCore;

namespace BaseApp
{
   public class ApplicationContext : DbContext //DbContext - визначає контекст даних, що використовуються для взаємодії з БД
    {
        public DbSet<User> Users { get; set; }  // DbSet<User> - представляє набір об'єктів, які зберігаються в БД
        public ApplicationContext()
        {
            Database.EnsureCreated();   // перевіряє, чи є створена БД. Якщо немає, то створює її
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)  // DbContextOptionsBuilder - встан парам підключення
        {
            // налаштовується строка підключення до MS SQL Server
            optionsBuilder.UseSqlServer("Server=desktop-cd37fhg;Database=baseappdb;Trusted_Connection=True;");
        }
    }
}
*/
