using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DandDEasy.Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DandDEasy_WEB.Controllers
{
    public class CharacterController : AServiceController
    {

        public CharacterController(HttpClient httpClient) : base(httpClient)
        { }
        // GET: Character
        public async Task<ActionResult> Index()
        {

            var request = CreateRequestToService(HttpMethod.Get, "api/Character/Index"); // go to API
            try
            {
                var response = await HttpClient.SendAsync(request);

                if (!response.IsSuccessStatusCode)
                {
                    return View();
                }

                string jsonString = await response.Content.ReadAsStringAsync();

                Character2 characterCampaigns = JsonConvert.DeserializeObject<Character2>(jsonString);

                return View(characterCampaigns);
            }
            catch (HttpRequestException ex)
            {
                // logging
                return View("Error");
            }

            //return View();
        }

        // GET: Character/Details/5
        public async Task<ActionResult> Details(int ChaID)
        {
            int y = ChaID;
            var request = CreateRequestToService(HttpMethod.Get, "api/Characters/Details", y); // go to API

            try
            {
                var response = await HttpClient.SendAsync(request);

                if (!response.IsSuccessStatusCode)
                {
                    return View("unauthorized");
                }

                string jsonString = await response.Content.ReadAsStringAsync();

                Character2 characterCampaigns = JsonConvert.DeserializeObject<Character2>(jsonString);

                return View(characterCampaigns);
            }
            catch (HttpRequestException ex)
            {
                // logging
                return View("Error");
            }
        }

        // GET: Character/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Character/Create
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

        // GET: Character/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Character/Edit/5
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

        // GET: Character/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Character/Delete/5
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