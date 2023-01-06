﻿using Microsoft.AspNetCore.Mvc;
using Pugcorn_v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pugcorn_v1.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Register userRegisterData)
        {
            if (!ModelState.IsValid)
            {
                return View(userRegisterData);
            }

            //logika rejestrujaca

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            return View();
        }
    }
}
