using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ColmSheehan.Controllers
{
    public class Projects_Interests : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}