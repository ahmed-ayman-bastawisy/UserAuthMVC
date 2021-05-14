using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAuthMVC.Models;

namespace UserAuthMVC.Controllers
{
    [Route("api/[controller]/[action]")]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddUser(User user)
        {
            User dbUser = new User
            {
                FName = user.FName,
                LName = user.LName,
                Age = user.Age
            };

            return View("GetUser", dbUser);
        }

        [HttpGet]
        public IActionResult GetUser(User user)
        {
            return View();
        }

    }
}
