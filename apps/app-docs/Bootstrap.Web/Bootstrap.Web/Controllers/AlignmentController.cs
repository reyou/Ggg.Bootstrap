﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Bootstrap.Web.Controllers
{
    public class AlignmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}