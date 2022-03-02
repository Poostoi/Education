using Abiturient.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Abiturient.Controllers
{
    public class HomeController : Controller
    {
        AbiturientContext db;

        public HomeController(AbiturientContext context)
        {
            db = context;
        }
        
        public IActionResult Index()
        {
            var summar = db.Summaries.Include(s => s.FormEducation).Include(s => s.Faculty);
            return View(summar.ToList());
        }
       /* public ActionResult TeamDetails(int? id)
        {
            
            Summary summ = db.Summaries.Find(id);
            
            summ.EducationOn = db.EducationOns.Where(m => m.Id == summ.EducationOnId);
            return View(summ);
        }*/
    }
}
