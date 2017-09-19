using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mvc02.Models;
using Mvc02.Data;

namespace Mvc02.Controllers {
    public class SubjectsController : Controller {
        private readonly SubjectDb _db;

        public SubjectsController(SubjectDb db) {
            _db = db;
        }

        //private static List<Subject> items = new List<Subject>() {
        //    new Subject{Code="GF225c",Title="ASP MVC Core",Days =5,Hours=30},
        //    new Subject{Code="GF120",Title="Programing C#",Days =4,Hours=24}
        //};

        public IActionResult Index() {
            var items = _db.Subjects.ToList();
            return View(items);
        }

        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Subject item) {
            if (!ModelState.IsValid) {
                return View(item);
            }
            _db.Subjects.Add(item);
            _db.SaveChanges();

            TempData["NewCode"] = item.Code;

            return RedirectToAction("Index");
        }

    }
}