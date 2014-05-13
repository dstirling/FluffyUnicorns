using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.IO; //needed to use memory stream

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

            [HttpPost]
            public ActionResult Create(fileUpload model)
            {
                if (ModelState.IsValid)
                {
                    // Use your file here
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        model.File.InputStream.CopyTo(memoryStream);

                    }
                    return View();
                }
                else
                {
                    return View();
                }
            }

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

                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            marks.File.InputStream.CopyTo(memoryStream);

                        }

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

            public ActionResult Delete(int Id)
            {
                var bmark = bookObj.bookmarks.Single(x => x.Id == Id);
                return View(bmark);

            }

            [HttpPost]
            public ActionResult Delete(int Id, bookmark bmark)
            {
                try
                {
                    var marks = bookObj.bookmarks.Single(x => x.Id == Id);
                    bookObj.bookmarks.DeleteOnSubmit(marks);
                    bookObj.SubmitChanges();
                    return RedirectToAction("Index");
                }

                catch
                {
                    return View(bmark);
                }
            }
        }
    }

