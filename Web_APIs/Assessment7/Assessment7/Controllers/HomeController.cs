using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assessment7.Models;

namespace Assessment7.Controllers
{
    public class HomeController : Controller
    {
        private AnimalDAL adal = new AnimalDAL();
        public IActionResult Index()
        {
             List<Result> list = adal.GetAnimals();
            return View(list);
        }
        public IActionResult Species(string SpeciesName)
        {
            SpeciesRoot r = adal.GetSpecies("meerkat");
            return View(r);
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
