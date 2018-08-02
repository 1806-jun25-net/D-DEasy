using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DandDEasy_WEB.Controllers
{
    public class Character2Controller : AServiceController
    {

        public Character2Controller(HttpClient httpClient) : base(httpClient)
        { }
        // GET: Character2
        public ActionResult Index()
        {
            return View();
        }

        // GET: Character2/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Character2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Character2/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Character2/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Character2/Edit/5
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

        // GET: Character2/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Character2/Delete/5
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