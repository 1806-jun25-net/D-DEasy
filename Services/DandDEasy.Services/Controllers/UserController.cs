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
       // private readonly DnDEasyContext _context;
        public UserRepo Repo { get; set; }

        public UserController(UserRepo repo)
         {
            // _context = context;
            Repo = repo;

        }




        ////////////////////////////////////////////////////////////////////////////////////////////
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    var user = Repo.GetUsertable();
        //    var TheUser = user.FirstOrDefault(x => x.FirstName == "Wesley");
        //    return new string[] { $"Name: {TheUser.FirstName}" + $" Last Name: {TheUser.LastName}" + $" Username: {TheUser.Username}"
        //        + $" Registration Date: {TheUser.RegistrationDate}"};
        //} // Print in webpage


        /*[HttpGet]
        public ActionResult<User> Get()
        {
            var user = Repo.GetUsertable();
            var TheUser = user.FirstOrDefault(x => x.FirstName == "Wesley");
            return TheUser;
        }*/

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //[HttpGet]
        //public IActionResult LogIN()
        //{
        //    User user = new User();
        //    return user;
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult LogIN(User user)
        //{
        //    var use = Repo.GetUsertable(); // Getting the User Table
        //    foreach (var oneUser in use) //  searching User by Username and password
        //    {
        //        if (oneUser.Email == user.Email && oneUser.Password == user.Password)
        //        {
        //            user.Id = oneUser.Id;
        //            break;
        //        }
        //    }
        //    if (isUser == true) // If user exist
        //    {
        //        TempData["welcomemsg"] = "Welcome back" + user.FirstName;
        //    }
        //    else if (isUser == false) // if user dont exist, create new user
        //    {
        //        TempData["welcomemsg"] = "Welcome " + user.FirstName; // message to welcome ---------
        //        Repo.AddUser(user.FirstName, user.LastName, user.PhoneNumber, 1); // create user -------
        //        Repo.SaveChanges(); // Save changes to table
        //        TempData["userid"] = Repo.GetUserIDByPhone(user.FirstName, user.PhoneNumber); // get user ID -------
        //    }
        //    return RedirectToAction("TheLocation", "Locations", user); // Redirect to the controller Location to the Action method TheLocation
        //}


    }
}
