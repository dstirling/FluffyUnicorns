using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fluffyUnicorns.Controllers
{
    public class bookmarkController : Controller
    {
        //
        // GET: /bookmark/

        public ActionResult Index()
        {
            return View();
        }

    }
}
