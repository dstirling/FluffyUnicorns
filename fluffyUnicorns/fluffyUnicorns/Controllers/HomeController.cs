using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fluffyUnicorns.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Fluffy unicorns prancing around, fluffy unicorns once lost, now found.  Can unicorns fly? Apparently only Pegasus have wings.. but what if a pegasus and unicorn did it and had a baby... to make a flying unipeg? pegacorn? Uniasus?  or all three?  ";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Fluffy Unicorns bein all pretty, looking for a Pegasus so they can fly!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact the Fluffy Unicorns!";

            return View();
        }
    }
}
