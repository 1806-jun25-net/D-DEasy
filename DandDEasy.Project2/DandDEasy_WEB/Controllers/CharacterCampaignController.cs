using DandDEasy_WEB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DandDEasy_WEB.Controllers
{
    public class CharacterCampaignController : AServiceController
    {
        public CharacterCampaignController(HttpClient httpClient) : base(httpClient)
        { }

        // GET: CharacterCampaign
        public async Task<ActionResult> Index()
        {

            
            var request = CreateRequestToService(HttpMethod.Get, "api/CharacterCampaign/MainPage");

            try
            {
                var response = await HttpClient.SendAsync(request);

                if (!response.IsSuccessStatusCode)
                {
                    return View("unauthorized");
                }

                string jsonString = await response.Content.ReadAsStringAsync();

                IEnumerable<CharacterCampaign> characterCampaigns = JsonConvert.DeserializeObject<IEnumerable<CharacterCampaign>>(jsonString);

                return View(characterCampaigns);
            }
            catch (HttpRequestException ex)
            {
                // logging
                return View("Error");
            }
        }

        // GET: CharacterCampaign/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CharacterCampaign/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CharacterCampaign/Create
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

        // GET: CharacterCampaign/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CharacterCampaign/Edit/5
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

        // GET: CharacterCampaign/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CharacterCampaign/Delete/5
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