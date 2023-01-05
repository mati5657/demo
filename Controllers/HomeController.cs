using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pugcorn_v1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Pugcorn_v1.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Returns()
        {
            return View();
        }

        public IActionResult Shoppings()
        {
            return View();
        }

        public IActionResult ShopRules()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

    }
}
