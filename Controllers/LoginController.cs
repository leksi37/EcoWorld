using EcoFriendly.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoFriendly.Controllers
{
    public class LoginController : Controller
    {
        private readonly EcoDbContext _dbContext;

        public LoginController(EcoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(Credentials credentials)
        {
            if (ModelState.IsValid)
            {
                var orgQueryable = _dbContext.Organizations.Where(org => org.Email == credentials.Email && org.Password == credentials.Password);
                Organization org = orgQueryable.FirstOrDefault();
                if (org == null)
                {
                    return View("Index");
                }
                else
                    return View("../Home/Index", org);
            }
            return View("Index");
        }

        public IActionResult Guest()
        {
            return View("../Guest/Index");
        }
    }
}
