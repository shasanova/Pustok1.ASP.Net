using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pustok1.DAL;
using Pustok1.ViewModels;

namespace Pustok1.Controllers
{
    public class HomeController : Controller
    {
        private readonly Pustok1DbContext _context;

        public HomeController(Pustok1DbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel model = new()
            {
                Sliders = _context.Sliders.ToList(),
                Features = _context.Features.ToList()

            };
            
            return View(model);
        }
    }
}

