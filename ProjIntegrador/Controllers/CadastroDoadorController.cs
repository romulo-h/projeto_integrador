using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjIntegrador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjIntegrador.Controllers
{
    public Doador teste;
    public class CadastroDoadorController : Controller
    {
        // GET: CadastroDoadorController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CadastroDoadorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CadastroDoadorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CadastroDoadorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CadastroDoadorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CadastroDoadorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CadastroDoadorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CadastroDoadorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
