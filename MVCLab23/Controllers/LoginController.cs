using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCLab23.Models;

namespace MVCLab23.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Users1 u)
        {
            TempData["name"] = u.UserName;
            TempData["password"] = u.Password;
            return RedirectToAction("Secret");
        }

        public IActionResult Secret()
        {
            //Why won't the password show up in our view?
            //ViewBag.password = TempData.Peek("password");
            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }

        public IActionResult SetColor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SetColor(string color)
        {
            CookieOptions option = new CookieOptions();
            option.Expires = DateTime.Now.AddMinutes(2);
            Response.Cookies.Append("color", color, option);
            return View();
        }
    }
}