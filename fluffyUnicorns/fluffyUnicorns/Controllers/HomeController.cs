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
         [Authorize]
        public ActionResult BookMarks()
        {
            return View();
        }
         [Authorize]
        public ActionResult Stats()
        {
            return View();
        }
         //[Authorize]
        //public ActionResult Contact()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Contact(contact con)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            objCon.contacts.InsertOnSubmit(con);
        //            objCon.SubmitChanges();
        //            return RedirectToAction("Contact");
        //        }
        //        catch
        //        {
        //            return View();
        //        }
        //    }
        //    else
        //    {
        //        return View();
        //    }
        //}
         [Authorize]
        public ActionResult Privacy()
        {
            return View();
        }
         [Authorize]
        public ActionResult Terms()
        {
            return View();
        }
         [Authorize]
        public ActionResult Help()
        {
            return View();
        }
    }
}
