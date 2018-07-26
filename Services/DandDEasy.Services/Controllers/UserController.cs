using DandDEasy.Services.Repo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DandDEasy.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DnDEasyContext _context;
        public UserRepo Repo { get; }

       // public UserController(DnDEasyContext context/*, UserRepo repo*/)
       // {
       //     _context = context;
            //Repo = repo;

        //}



        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            User user = new User();
            var user = Repo.GetUsertable();
            var TheUser = user.FirstOrDefault(x => x.FirstName == "Varnathin");
            return new string[] { $"Name: {TheUser.FirstName}" + $"Last Name: {TheUser.LastName}" + $"Username: {TheUser.Username}"
            + $"Registration Date: {TheUser.RegistrationDate}"};
        }

        //[HttpGet]
        //public IEnumerable<User> GetUsertable()
        //{
        //    var user = Repo.GetUsertable();
        //}
    }
}
