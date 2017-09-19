using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mvc02.Models;
using Mvc02.Data;

namespace Mvc02.Controllers {
    public class HomeController : Controller {
        private readonly SubjectDb _db;

        public HomeController(SubjectDb db) {
            _db = db;
        }

        public IActionResult Index() {
            return View();
        }

        public IActionResult About() {
            var s = new Subject {
                Code = $"GF{DateTime.Now.Millisecond}",
                Title = "Demo",
                Days = 5,
                Hours = 30
            };
            _db.Subjects.Add(s);
            _db.SaveChanges();

            ViewData["Message"] = _db.Subjects.Count(); //"Your application description page.";

            return View();
        }

        public IActionResult Contact() {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
