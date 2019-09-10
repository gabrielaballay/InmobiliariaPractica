using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inmobiliaria.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inmobiliaria.Controllers
{
    public class PropietarioController : Controller
    {
        IRepositorio<Propietario> repo;
        public PropietarioController(IRepositorio<Propietario> repositorio)
        {
            repo = repositorio;
        }
        // GET: Propietario
        public ActionResult Index()
        {
            Data data = new Data();
            var propietarios = repo.ObtenerTodos();
            if (TempData.ContainsKey("id"))
                ViewBag.Id = TempData["id"];

            return View(propietarios);
        }

        // GET: Propietario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Propietario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Propietario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Propietario propietario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    repo.Alta(propietario);
                    TempData["id"] = propietario.IdPropietario;
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }
            }
            catch(Exception ex)
            {
                ViewBag.StackTrace = ex.StackTrace;
                ViewBag.Error = ex.Message;
                return View();
            }
        }

        // GET: Propietario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Propietario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Propietario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Propietario/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}