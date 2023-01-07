using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pugcorn_v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pugcorn_v1.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<UserModel> userMenager;
        private readonly SignInManager<UserModel> signInManager;

        public AccountController(UserManager<UserModel> userMenager, SignInManager<UserModel> signInManager)
        {
            this.userMenager = userMenager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(Login userLoginData)
        {
            if (!ModelState.IsValid)
            {
                return View(userLoginData);
            }

            await LogIn(userLoginData);

            return RedirectToAction("Index", "Home");
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(Register userRegisterData)
        {
            if (!ModelState.IsValid)
            {
                return View(userRegisterData);
            }

            await RegisterNewUser(userRegisterData);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        private async Task RegisterNewUser(Register userRegisterData)
        {
            var newUser = new UserModel
            {
                Email = userRegisterData.Email,
                UserName = userRegisterData.Username
            };

            await userMenager.CreateAsync(newUser, userRegisterData.Password);
        }

        private async Task LogIn(Login userLoginData)
        {
            await signInManager.PasswordSignInAsync(userLoginData.Username, userLoginData.Password, false, false);
        }
    }
}
