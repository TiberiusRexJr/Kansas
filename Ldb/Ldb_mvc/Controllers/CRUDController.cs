﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ldb_mvc.Controllers
{
    public class CRUDController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}