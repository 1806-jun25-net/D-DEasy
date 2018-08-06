using DandDEasy_WEB.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DandDEasy_WEB.Controllers
{
    public class UserController : AServiceController
    {

        public UserController(HttpClient httpClient) : base(httpClient)
        { }


        public async Task<ActionResult> Index()
        {

            var request = CreateRequestToService(HttpMethod.Get, "api/user/getusertable");

            try
            {
                var response = await HttpClient.SendAsync(request);

                if (!response.IsSuccessStatusCode)
                {
                    return View("unauthorized");
                }

                string jsonString = await response.Content.ReadAsStringAsync();

                IEnumerable<User> AllUsers = JsonConvert.DeserializeObject<IEnumerable<User>>(jsonString);

                return View(AllUsers);
            }
            catch (HttpRequestException ex)
            {
                // logging
                return View("Error");
            }
        }

        public async Task<ActionResult> InsertUser(User credentials)
        {

            var request = CreateRequestToService(HttpMethod.Post, "api/user/InsertUser", credentials); // Call insert method in the API

            try
            {
                var response = await HttpClient.SendAsync(request);

                if (!response.IsSuccessStatusCode)
                {
                    return View("Error");
                }


                return RedirectToAction("Login", "Account");
            }
            catch (HttpRequestException ex)
            {
                // logging
                return View("Error");
            }
        }

    }
}
