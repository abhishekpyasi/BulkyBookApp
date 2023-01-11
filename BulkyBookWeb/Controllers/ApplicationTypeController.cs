using BulkyBookWeb.Data;
using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BulkyBookWeb.Controllers
{
    public class ApplicationTypeController : Controller


    {

        private readonly AppDbContext _db;

        public ApplicationTypeController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()

        {

            IEnumerable<ApplicationType> objList = _db.AppliCationTypes;
            return View(objList);
        }
        // Get for create
        public IActionResult CreateApplicationType()

        {

            return View();
        }
        //

        [HttpPost] //attribute to tell that this is post action method
        [ValidateAntiForgeryToken]
        public IActionResult CreateApplicationType(ApplicationType obj)

        {
            _db.AppliCationTypes.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");// here we are redirecting to https://localhost:5001/Category URL
        }


    }
}
