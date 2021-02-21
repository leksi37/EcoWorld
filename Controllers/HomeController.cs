﻿using EcoFriendly.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EcoFriendly.Controllers
{
    public class HomeController : Controller
    {
        private readonly EcoDbContext _dbContext;
        private Organization Org;

        public HomeController(EcoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {   
            return View("Index", Org);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
