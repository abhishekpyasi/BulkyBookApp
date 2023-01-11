using BulkyBookWeb.Data;
using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BulkyBookWeb.Controllers
{
    public class CategoryController : Controller


    {

        private readonly AppDbContext _db;

        public CategoryController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()

        {

            IEnumerable<Categorymodel> objList = _db.Category;
            return View(objList);
        }
        // Get for create
        public IActionResult CreateCategory()

        {

            return View();
        }
        //
        [HttpPost] //attribute to tell that this is post action method
        [ValidateAntiForgeryToken]
        public IActionResult CreateCategory(Categorymodel obj)

        {
            if (ModelState.IsValid) // checks that rules(like  [Required] ) defined in model are valid then only add to DB
            {
                _db.Category.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");// here we are redirecting to https://localhost:5001/Category URL

            }

            return View(obj);

        }
        //get Edit


        public IActionResult Edit(int? id)

        {
            if (id == null || id == 0)
            {

                return NotFound();
            }

            var obj = _db.Category.Find(id);
            if(obj==null)
            {

                return NotFound();
            }

            return View(obj);
        }


        //Post - Edit

        [HttpPost] //attribute to tell that this is post action method
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Categorymodel obj)

        {
            if (ModelState.IsValid) // checks that rules(like  [Required] ) defined in model are valid then only add to DB
            {
                _db.Category.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");// here we are redirecting to https://localhost:5001/Category URL

            }

            return View(obj);

        }

        // get - Delete

        public IActionResult Delete(int? id)

        {
            if (id == null || id == 0)
            {

                return NotFound();
            }

            var obj = _db.Category.Find(id);
            if (obj == null)
            {

                return NotFound();
            }

            return View(obj);
        }


        //Post - Delete

        [HttpPost] //attribute to tell that this is post action method
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Categorymodel obj)

        {
            if (obj == null)
            {

                return NotFound();
            }
            
                _db.Category.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");// here we are redirecting to https://localhost:5001/Category URL

            

            

        }





    }

}
