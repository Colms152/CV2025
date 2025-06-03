using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ColmSheehan.Models;
using System.Security.Cryptography.X509Certificates;

namespace ColmSheehan.Controllers
{
    public class RecomendationsController : Controller
    {
        public IActionResult Index()
        {
           ViewBag.recommendations = DB.recommendations;
            return View();
        }

        [Route("rDetails/{id?}")]
        public IActionResult Details(int id)
        {
            List<Recommendation> recommendations = DB.recommendations;
            

            foreach (Recommendation rec in recommendations)
            {
                if(rec.Id == id)
                {
                    string strOutput = rec.Author + "," + rec.Email + "," + rec.Text + "," + rec.Age + "," + rec.Id;
                    
                    return Content(strOutput);
                }
            };
            
            return Content("No Records with this ID");
        }
        
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Add(Recommendation rec)
        {
            if (ModelState.IsValid)
            {
                DB.recommendations.Add(rec);
                return View("Thanks", rec);
            }
            else
            {
                
                return View(rec);
            }
        }
    }
}