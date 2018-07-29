using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DandDEasy_WEB.Controllers
{
    public class UserController : Controller
    {
        private readonly static string ServiceUri = "https://localhost:44345/api/";

        public HttpClient HttpClient { get; }

        public UserController(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }


    }
}
