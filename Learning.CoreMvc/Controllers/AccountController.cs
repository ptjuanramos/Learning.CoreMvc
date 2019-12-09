using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Learning.CoreMvc.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Learning.CoreMvc.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            if(ModelState.IsValid)
            {
                //TODO- ask UserRepository and check information
            }

            return View();
        }
    }
}