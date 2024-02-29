using ProjectNews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectNews.Controllers
{
    public class CategoryNewsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: CategoryNews
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult menucategory()
        {
            var item = db.categories;
            return PartialView(item);
        }
    }
}