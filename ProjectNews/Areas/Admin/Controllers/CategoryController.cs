using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectNews.Models;
using ProjectNews.Models.EF;
using PagedList;
namespace ProjectNews.Areas.Admin.Controllers
{
    
    public class CategoryController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/Category
        public ActionResult Index()
        {
            var items = db.categories;
            return View(items);
        }

        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Category model)
        {
            if(ModelState.IsValid)
            {
                db.categories.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
           return View();
        }
    }
}