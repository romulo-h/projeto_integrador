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
        private Contexto db;
        public HomeController(Contexto DB)
        {
            db = DB;
        }

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult AdicionarPessoa()
        {

            return PartialView();
        }

        public ActionResult ListarPessoa()
        {
            var usuarios = db.Doador.ToList();
            ViewBag.LstUsuarios = usuarios;

            return PartialView();
        }
        //public IActionResult About()
        //{
        //    ViewData["Message"] = "Your application description page.";

        //    return View();
        //}

        //public IActionResult Contact()
        //{
        //    ViewData["Message"] = "Your contact page.";

        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
