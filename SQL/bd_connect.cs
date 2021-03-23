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

/*
User.cs

using System;
using System.Collections.Generic;

#nullable disable

namespace BaseAppConnect
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
*/

/*
BaseAppConnect.cs

using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BaseAppConnect
{
    public partial class baseappdbContext : DbContext
    {
        public baseappdbContext()
        {
        }

        public baseappdbContext(DbContextOptions<baseappdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=desktop-cd37fhg;Database=baseappdb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
