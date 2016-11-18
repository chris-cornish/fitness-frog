using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FitnessFrog.Core.Domain;
using FitnessFrog.Core.Domain.Data;

namespace FitnessFrog.Core.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly FitnessFrogDbContext _context;

        public HomeController(FitnessFrogDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Frog()
        {

            Frog frog = new Frog();

            frog.Days = _context.Days.ToList();

            return View(frog);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
