using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DandDEasy_WEB.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DandDEasy_WEB.Controllers
{
    public class CampaignsController : AServiceController
    {
        public CampaignsController(HttpClient httpClient) : base(httpClient)
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateCam()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCam(Campaign campaign)
        {
            var request = CreateRequestToService(HttpMethod.Post, "api/Campaigns/PostCampaign", campaign);

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
                return View("Error");
            }
        }

        public IActionResult DeleteCam(int id)
        {
            int ID = id;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteCam(Campaign campaign2)
        {
            int elid = campaign2.Id;
            var request = CreateRequestToService(HttpMethod.Post, $"api/campaigns/DeleteCampaign/{elid}");

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

        public void DGM()
        {
            Response.Redirect("http://localhost:4200/");
        }
    }
}