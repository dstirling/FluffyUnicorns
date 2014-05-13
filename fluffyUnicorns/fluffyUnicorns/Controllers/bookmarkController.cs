using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using fluffyUnicorns.Models;


namespace fluffyUnicorns.Controllers
{
    
    public class bookmarkController : Controller
    {
        bookmarksDataContext bookObj = new bookmarksDataContext();
        //
        // GET: /bookmark/

        public ActionResult Index()
        {
            var marks = bookObj.bookmarks.Select(x => x);
            return View(marks);//must pass parameter to view in order to display information
        }

        //making insert 
        public ActionResult Create() //when user clicks on like a create thing it'll go to create page
        {
            return View();
        }
        [HttpPost] //creating post 
        public ActionResult Create(bookmark marks)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    bookObj.bookmarks.InsertOnSubmit(marks);
                    bookObj.SubmitChanges();
                    return RedirectToAction("Index"); //on successful insert it'll go to index page
                }
                catch
                {
                    return View(); //will reshow form
                }
            }
            else
            {
                return View(); //will reshow form if error
            }
        }

    }
}
