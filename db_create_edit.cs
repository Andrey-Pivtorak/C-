using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace TestApp
{
    public class User
    {
        public int  Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            optionsbuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                User user1 = new User { Name = "Vasiliy", Age = 33 };
                User user2 = new User { Name = "Fedor", Age = 28 };

                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();
            }

            // data getting
            using (ApplicationContext db = new ApplicationContext())
            {
                var users = db.Users.ToList();
                Console.WriteLine("Data after update:");
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }

            // data editting
            using (ApplicationContext db = new ApplicationContext())
            {
                User user = db.Users.FirstOrDefault();
                if (user != null)
                {
                    user.Name = "Marya";
                    user.Age = 27;
                    //db.Users.Update(user);
                    db.SaveChanges();
                }

                // data printing after update
                Console.WriteLine("\nData after editting:");
                var users = db.Users.ToList();
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }

            // data deletion
            using (ApplicationContext db = new ApplicationContext())
            {
                User user = db.Users.FirstOrDefault();
                if (user != null)
                {
                    // deletion the object
                    db.Users.Remove(user);
                    db.SaveChanges();
                }

                Console.WriteLine("\nData after editting:");
                var users = db.Users.ToList();
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }

            // data adding  
            using (ApplicationContext db = new ApplicationContext())
            {                
                User user3 = new User { Name = "Helen", Age = 31 };
                User user4 = new User { Name = "Victor", Age = 35 };
                db.Users.AddRange(user3, user4);
                db.SaveChanges();
                
                Console.WriteLine("\nData after adding:");
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
