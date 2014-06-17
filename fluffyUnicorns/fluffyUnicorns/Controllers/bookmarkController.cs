using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Text;
using fluffyUnicorns.Models;


namespace fluffyUnicorns.Controllers
{

        public class bookmarkController : Controller
        {
            
            bookmarksDataContext bookObj = new bookmarksDataContext();

            //public HttpPostedFileBase File { get; set; }
            // GET: /bookmark/
            
            [Authorize]
            public ActionResult Index()
            {


                var marks = bookObj.bookmarks.Select(x => x);

                return View(marks);//must pass parameter to view in order to display information
            }
            
            [Authorize]
            public ActionResult Create()
            {
                return View();
            }
            
            [Authorize]
            [HttpPost]
            public ActionResult Create(bookmark upload, HttpPostedFileBase fileData)
            {

                if (fileData != null && fileData.ContentLength > 0)
                {
                    string file = fileData.FileName;
                    upload.fileData = file;
                    string filepath = Path.Combine(Server.MapPath("~/files"), file);
                    fileData.SaveAs(filepath);
                }
                bookObj.bookmarks.InsertOnSubmit(upload);
                bookObj.SubmitChanges();
                ViewBag.result = "Success";

                return View();
            }
            
            [Authorize]
            public ActionResult AddLink()
            {
                return View();
            }

            [HttpPost]
            public ActionResult AddLink(bookmark link)
            {
                bookObj.bookmarks.InsertOnSubmit(link);
                bookObj.SubmitChanges();
                ViewBag.result = "Success";

                return View();
            }

            [Authorize]
            public ActionResult Edit(int Id)
            {
                var book = bookObj.bookmarks.Single(x => x.Id == Id);
                return View(book);
            }
            
            [Authorize]
            [HttpPost]
            public ActionResult Edit(int Id, bookmark book)
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        var bookmark = bookObj.bookmarks.Single(x => x.Id == Id);
                        UpdateModel(bookmark);
                        bookObj.SubmitChanges();
                        ViewBag.result = "Success";
                        return RedirectToAction("Index");
                    }
                    catch
                    {
                        return View(book);
                    }
                }
                else
                {
                    return View(book);
                }
            }

            public ActionResult EditLink(int Id)
            {
                var link = bookObj.bookmarks.Single(x => x.Id == Id);
                return View(link);
            }
            
            [Authorize]
            [HttpPost]
            public ActionResult EditLink(int Id, bookmark link)
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        var editlink = bookObj.bookmarks.Single(x => x.Id == Id);
                        UpdateModel(editlink);
                        bookObj.SubmitChanges();
                        ViewBag.result = "Success";
                        return RedirectToAction("Index");
                    }
                    catch
                    {
                        return View(link);
                    }
                }
                else
                {
                    return View(link);
                }
            }

            [Authorize]
            public ActionResult Delete(int Id)
            {
                var bmark = bookObj.bookmarks.Single(x => x.Id == Id);
                return View(bmark);

            }

            [Authorize]
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
        
       
    

