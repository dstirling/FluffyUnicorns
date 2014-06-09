using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using fluffyUnicorns.Models;

namespace fluffyUnicorns.Controllers
{
    public class HomeController : Controller
    {
        bookmarksDataContext objCon = new bookmarksDataContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult BookMarks()
        {
            return View();
        }

        public ActionResult Stats()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(contact con)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    objCon.contacts.InsertOnSubmit(con);
                    objCon.SubmitChanges();
                    return RedirectToAction("Contact");
                }
                catch
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        public ActionResult Privacy()
        {
            return View();
        }

        public ActionResult Terms()
        {
            return View();
        }

        public ActionResult Help()
        {
            return View();
        }
    }
}
