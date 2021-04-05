using Assessment6.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment6.Controllers
{
    public class HomeController : Controller
    {

        private CountriesDBContext _context;
        public HomeController(CountriesDBContext context) 
        { _context = context; }

        public IActionResult Index()
        {
            return View();
        }
        //2.Countries action
        //a.Grab the list of countries from the Database and feed it into the view
        public IActionResult Countries()
        {
            return View(_context.Countries.ToList());
        }
        public IActionResult CountriesByContinent(string ContinentName)
        {
            return View(_context.Countries.Where(x => x.Continent == ContinentName).ToList());  
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
