using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Learning.CoreMvc.Business;
using Learning.CoreMvc.DataAccess.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Learning.CoreMvc.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager userManager;

        public UserController(UserManager userManager)
        {
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Users()
        {
            ViewBag.Users = userManager.GetAllUsers();
            return View();
        }
    }
}