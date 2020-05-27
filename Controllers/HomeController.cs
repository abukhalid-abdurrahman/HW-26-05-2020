using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Solution.Models;

namespace Solution.Controllers
{
    public class HomeController : Controller
    {
        DataContext dbContext;
        public HomeController(DataContext context){ dbContext = context; }

        public IActionResult Index()
        {
            return View(dbContext.Products.ToList());
        }

        [HttpPost]
        public IActionResult Index(string requset)
        {
            //TODO: Search Product
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Superuser superuser)
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
