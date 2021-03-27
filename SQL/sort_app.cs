/*
HomeController.cs

using Microsoft.AspNetCore.Mvc;
using SortApp.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SortApp.Controllers
{
    public class HomeController : Controller
    {
        UsersContext db;
        public HomeController(UsersContext context)
        {
            this.db = context;
            // добавляю начальные данные для тестирования
            if (db.Companies.Count() == 0)
            {
                Company oracle = new Company { Name = "Oracle" };
                Company google = new Company { Name = "Google" };
                Company microsoft = new Company { Name = "Microsoft" };
                Company apple = new Company { Name = "Apple" };

                User user1 = new User { Name = "Федор Петров", Company = oracle, Age = 29 };
                User user2 = new User { Name = "Евгений Себастьянов", Company = oracle, Age = 37 };
                User user3 = new User { Name = "Инна Прокопенко", Company = microsoft, Age = 22 };
                User user4 = new User { Name = "Сюзанна Дятлова", Company = microsoft, Age = 31 };
                User user5 = new User { Name = "Сергей Непонятный", Company = microsoft, Age = 40 };
                User user6 = new User { Name = "Кристина Хоботенко", Company = google, Age = 25 };
                User user7 = new User { Name = "Олег Печальный", Company = google, Age = 42 };
                User user8 = new User { Name = "Катя Пушкарева", Company = apple, Age = 24 };

                db.Companies.AddRange(oracle, google, microsoft, apple);
                db.Users.AddRange(user1, user2, user3, user4, user5, user6, user7, user8);
                db.SaveChanges();
            }
        }

        public async Task<IActionResult> Index(SortState sortOrder = SortState.NameAsc)
        {
            IQueryable<User> users = db.Users.Include(x => x.Company);

            ViewData["NameSort"] = sortOrder == SortState.NameAsc ? SortState.NameDesc : SortState.NameAsc;
            ViewData["AgeSort"] = sortOrder == SortState.AgeAsc ? SortState.AgeDesc : SortState.AgeAsc;
            ViewData["CompanySort"] = sortOrder == SortState.CompanyAsc ? SortState.CompanyDesc : SortState.CompanyAsc;

            users = sortOrder switch
            {
                SortState.NameDesc => users.OrderByDescending(s => s.Name),
                SortState.AgeAsc => users.OrderBy(s => s.Age),
                SortState.AgeDesc => users.OrderByDescending(s => s.Age),
                SortState.CompanyAsc => users.OrderBy(s => s.Company.Name),
                SortState.CompanyDesc => users.OrderByDescending(s => s.Company.Name),
                _ => users.OrderBy(s => s.Name),
            };

            IndexViewModel viewModel = new IndexViewModel
            {
                Users = await users.AsNoTracking().ToListAsync(),
                SortViewModel = new SortViewModel(sortOrder)
            };
            return View(viewModel);
        }
    }
}
*/

/*
Company.cs

using System.Collections.Generic;

namespace SortApp.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public List<User> Users { get; set; }
        public Company()
        {
            Users = new List<User>();
        }
    }
}
*/

/*
SortState.cs

namespace SortApp.Models
{
    public enum SortState
    {
        NameAsc,    // по имени по возростанию
        NameDesc,   // по имени по убыванию
        AgeAsc,     // по возрасту по возростанию
        AgeDesc,    // по возрасту по убыванию
        CompanyAsc, // по компании по взрростанию
        CompanyDesc    // по компании по убыванию
    }
}
*/

/*
SortViewModel.cs

namespace SortApp.Models
{
    public class SortViewModel
    {
        public SortState NameSort { get; set; } // значение для сортировки по имени
        public SortState AgeSort { get; set; }  // значение для сортировки по возрасту
        public SortState CompanySort { get; set; }  // значение для сортировки по компании
        public SortState Current { get; set; }  // значение свойства, выбранного для сортировки
        public bool Up { get; set; }    // Сортировка по возрастанию или убыванию

        public SortViewModel(SortState sortOrder)
        {
            // значения по умолчанию
            NameSort = SortState.NameAsc;
            AgeSort = SortState.AgeAsc;
            CompanySort = SortState.CompanyAsc;
            Up = true;

            if (sortOrder == SortState.AgeDesc || sortOrder == SortState.NameDesc
                || sortOrder == SortState.CompanyDesc)
            {
                Up = false;
            }

            switch (sortOrder)
            {
                case SortState.NameDesc:
                    Current = NameSort = SortState.NameAsc;
                    break;
                case SortState.AgeAsc:
                    Current = AgeSort = SortState.AgeDesc;
                    break;
                case SortState.AgeDesc:
                    Current = AgeSort = SortState.AgeAsc;
                    break;
                case SortState.CompanyAsc:
                    Current = CompanySort = SortState.CompanyDesc;
                    break;
                case SortState.CompanyDesc:
                    Current = CompanySort = SortState.CompanyAsc;
                    break;
                default:
                    Current = NameSort = SortState.NameDesc;
                    break;
            }
        }
    }
}
*/
