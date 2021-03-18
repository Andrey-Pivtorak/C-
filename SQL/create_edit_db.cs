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
            /*
            var builder = new ConfigurationBuilder();
            // установка шляху до нинішнього каталогу
            builder.SetBasePath(Directory.GetCurrentDirectory());
            // отримую конфігурацію з файлу appsettings.json
            builder.AddJsonFile("appsettings.json");
            // створюю конфігурацію
            var config = builder.Build();
            // отримую строку підключення
            string connectionString = config.GetConnectionString("DefaultConnection");
            */

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
            }

            using (ApplicationContext db = new ApplicationContext())
            {
                // отримую об'єкти  із БД і виводжу їх на консоль
                var users = db.Users.ToList();
                Console.WriteLine("Список новостворених об'єктів:");
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }

            using (ApplicationContext db = new ApplicationContext())
            {
                // редагую перший запис
                User user = db.Users.FirstOrDefault();
                if (user != null)
                {
                    user.Name = "Bogdan";
                    user.Age = 32;
                    db.SaveChanges();
                }

                // отримую дані на консоль після редагування
                Console.WriteLine("\nДані після редагування:");
                var users = db.Users.ToList();
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }

            using (ApplicationContext db = new ApplicationContext())
            {
                // видалення першого запису
                User user = db.Users.FirstOrDefault();
                if (user != null)
                {
                    db.Users.Remove(user);
                    db.SaveChanges();
                }

                // отримую дані на консоль після видалення
                Console.WriteLine("\nДані після видалення:");
                var users = db.Users.ToList();
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
ApplicationContext.cs

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
            // налаштовується строка підключення до MS SQL Server.
            optionsBuilder.UseSqlServer("Server=Name of my server;Database=baseappdb;Trusted_Connection=True;");
        }
    }
}
*/
    
/*
appsettings.json

{
  "ConnectionStrings": {
    "DefaultConnection": "Server=Name of my server;Database=baseappdb;Trusted_Connection=True;"
  }
}
*/
