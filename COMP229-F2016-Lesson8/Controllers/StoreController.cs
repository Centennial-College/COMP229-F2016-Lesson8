using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COMP229_F2016_Lesson8.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            ViewBag.message = "This is my store index page!";

            return View();
        }

        // GET: Store/Browse?genre=Rock
        public ActionResult Browse(string genre)
        {
            ViewBag.message = HttpUtility.HtmlEncode("Store.Browse, Genre= " + genre);

            return View();
        }

        // GET: Store/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.message = HttpUtility.HtmlEncode("Store.Details, ID= " + id);

            return View();
        }
    }
}