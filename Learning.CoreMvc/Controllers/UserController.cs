﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Learning.CoreMvc.Business;
using Microsoft.AspNetCore.Mvc;

namespace Learning.CoreMvc.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager userManager;

        public UserController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}