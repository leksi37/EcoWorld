using EcoFriendly.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoFriendly.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly EcoDbContext _dbContext;

        public RegistrationController(EcoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register(Organization organization)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Organizations.Add(organization);
                return View("../Login/Index");
            }
            else
            {
                return View("Index");
            }
        }
    }
}
