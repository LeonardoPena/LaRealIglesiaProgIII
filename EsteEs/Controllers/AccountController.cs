﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsteEs.Controllers
{
    public class Account : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
