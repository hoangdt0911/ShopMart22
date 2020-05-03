﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShopMart22.Data.Entities;

namespace ShopMart22.Areas.Admin.Controllers
{
    public class AccountController : BaseController
    {
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return Redirect("/Admin/Login/Index");
        }
    }
}