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
        public async Task<IActionResult> CreateCam([Bind("Title", "Password")] Campaign campaign)
        {
            var request = CreateRequestToService(HttpMethod.Get, "api/campaign/PostCampaign");

            try
            {
                var response = await HttpClient.SendAsync(request);

                if (!response.IsSuccessStatusCode)
                {
                    return View("unauthorized");
                }



                return RedirectToAction("Index", "Home");
            }
            catch (HttpRequestException ex)
            {
                return View("Error");
            }

        }
    }
}