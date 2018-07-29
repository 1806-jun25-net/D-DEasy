using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DandDEasy_WEB.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace DandDEasy_WEB.Controllers
{
    public class HomeController : AServiceController
    {
        public HomeController(HttpClient httpClient) : base(httpClient)
        { }

        public IActionResult Index()
        {
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






        //    public HomeController(HttpClient httpClient) : base(httpClient)
        //    { }

        //    // GET: Todo
        //    // we can DI into action methods too
        //    //public ActionResult Index([FromServices] HttpClient client)
        //    public async Task<ActionResult> Index()
        //    {

        //        var request = CreateRequestToService(HttpMethod.Get, "api/Home");

        //        try
        //        {
        //            var response = await HttpClient.SendAsync(request);

        //            if (!response.IsSuccessStatusCode)
        //            {
        //                return View("Error");
        //            }

        //            string jsonString = await response.Content.ReadAsStringAsync();

        //            List<Login> todo = JsonConvert.DeserializeObject<List<Login>>(jsonString);

        //            return View(todo);
        //        }
        //        catch (HttpRequestException ex)
        //        {
        //            // logging
        //            return View("Error");
        //        }
        //    }

        //    // GET: Todo/Details/5
        //    public ActionResult Details(int id)
        //    {
        //        return View();
        //    }

        //    // GET: Todo/Create
        //    public ActionResult Create()
        //    {
        //        return View();
        //    }

        //    // POST: Todo/Create
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public async Task<ActionResult> Create(Login item)
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            return View(item);
        //        }

        //        try
        //        {
        //            string jsonString = JsonConvert.SerializeObject(item);

        //            var request = CreateRequestToService(HttpMethod.Post, "api/Home");
        //            // we set what the Content-Type header will be here
        //            request.Content = new StringContent(jsonString, Encoding.UTF8, "application/json");

        //            var response = await HttpClient.SendAsync(request);

        //            if (!response.IsSuccessStatusCode)
        //            {
        //                return View("Error");
        //            }

        //            return RedirectToAction(nameof(Index));
        //        }
        //        catch
        //        {
        //            return View();
        //        }
        //    }

        //    // GET: Todo/Edit/5
        //    public ActionResult Edit(int id)
        //    {
        //        return View();
        //    }

        //    // POST: Todo/Edit/5
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult Edit(int id, IFormCollection collection)
        //    {
        //        try
        //        {
        //            // TODO: Add update logic here

        //            return RedirectToAction(nameof(Index));
        //        }
        //        catch
        //        {
        //            return View();
        //        }
        //    }

        //    // GET: Todo/Delete/5
        //    public ActionResult Delete(int id)
        //    {
        //        return View();
        //    }

        //    // POST: Todo/Delete/5
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public ActionResult Delete(int id, IFormCollection collection)
        //    {
        //        try
        //        {
        //            // TODO: Add delete logic here

        //            return RedirectToAction(nameof(Index));
        //        }
        //        catch
        //        {
        //            return View();
        //        }
        //    }
    }
}
