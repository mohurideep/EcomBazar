using DemoDataAccess;
using Microsoft.AspNetCore.Mvc;
using Practise_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practise_Demo.Controllers
{
    public class LoginController : Controller
    {
        private AppDbContext _dbContext;

        public LoginController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult LIndex()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Login data)
        {
            var correct = _dbContext.Employee.Any(x => x.Email == data.Email && x.Password == data.Password);

            if (correct)
            {
                HttpContext.Response.Cookies.Append("auth-demo", data.Email);
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("LoginError", "Incorrect username or Password");
            return View("LIndex");
        }

        public IActionResult Logout()
        {
            HttpContext.Response.Cookies.Delete("auth-demo");
            return View("LIndex");
        }
    }
}
