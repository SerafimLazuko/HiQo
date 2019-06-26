using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MVC.Models;
using MVC.Controllers;

namespace MVC.Controllers
{
    public class ContentPageController : Controller
    {
        [Authorize]
        public IActionResult ContentPage()
        {
            return View();
        }
    }
}