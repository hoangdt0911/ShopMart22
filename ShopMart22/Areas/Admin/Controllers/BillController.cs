﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ShopMart22.Areas.Admin.Controllers
{
    public class BillController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}