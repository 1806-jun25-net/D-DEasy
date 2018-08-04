using DandDEasy.Services.Models;
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
        public async Task<ActionResult> Index(User credentials)
        {

            
            var request = CreateRequestToService(HttpMethod.Get, "api/CharacterCampaign/MainPage", credentials); // go to API

            try
            {
                var response = await HttpClient.SendAsync(request);

                if (!response.IsSuccessStatusCode)
                {
                    return View("unauthorized");
                }

                string jsonString = await response.Content.ReadAsStringAsync();

                CharacterCampaign characterCampaigns = JsonConvert.DeserializeObject<CharacterCampaign>(jsonString);

                return View(characterCampaigns);
            }
            catch (HttpRequestException ex)
            {
                // logging
                return View("Error");
            }
        }

        // GET: CharacterCampaign/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var request = CreateRequestToService(HttpMethod.Get, $"api/characters/Details/{id}"); 

            try
            {
                var response = await HttpClient.SendAsync(request);

                if (!response.IsSuccessStatusCode)
                {
                    return View("unauthorized");
                }

                string jsonString = await response.Content.ReadAsStringAsync();

                Character2 character = JsonConvert.DeserializeObject<Character2>(jsonString);

                return View(character);
            }
            catch (HttpRequestException ex)
            {
                // logging
                return View("Error");
            }
            //return RedirectToAction("Details", "character", id);
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
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            var request = CreateRequestToService(HttpMethod.Post, $"api/characters/Delete/{id}");

            try
            {
                var response = await HttpClient.SendAsync(request);

                if (!response.IsSuccessStatusCode)
                {
                    return View("unauthorized");
                }

                return RedirectToAction("Index", "CharacterCampaign");
            }
            catch (HttpRequestException ex)
            {
                // logging
                return View("Error");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CampDelete(int id, IFormCollection collection)
        {
            var request = CreateRequestToService(HttpMethod.Post, $"api/campaigns/DeleteCampaign/{id}");

            try
            {
                var response = await HttpClient.SendAsync(request);

                if (!response.IsSuccessStatusCode)
                {
                    return View("unauthorized");
                }

                return RedirectToAction("Index", "CharacterCampaign");
            }
            catch (HttpRequestException ex)
            {
                // logging
                return View("Error");
            }
        }

    }
}