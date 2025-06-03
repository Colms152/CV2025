using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ColmSheehan.Controllers
{
    public class ExperienceController : Controller
    {
        public IActionResult Work()
        {
            return View();
        }
        public IActionResult Education()
        {
            return View();
        }
    }
}