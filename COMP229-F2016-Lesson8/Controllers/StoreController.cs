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
        public string Index()
        {
            return "This is my store index page!";
        }

        // GET: Store/Browse?genre=Rock
        public string Browse(string genre)
        {
            return HttpUtility.HtmlEncode("Store.Browse, Genre= " + genre);
        }

        // GET: Store/Details/5
        public string Details(int id)
        {
            return HttpUtility.HtmlEncode("Store.Details, ID= " + id);
        }
    }
}