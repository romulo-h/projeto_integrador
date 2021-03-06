using Microsoft.AspNetCore.Mvc;
using ProjIntegrador.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjIntegrador.Controllers
{
    public class HomeController : Controller
    {
        private ProjIntegradorContext db;
        public HomeController(ProjIntegradorContext DB)
        {
            db = DB;
        }

        public IActionResult Index()
        {
            var usuarios = db.Doador.ToList();

            return View();
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
