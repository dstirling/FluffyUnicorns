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

            //public HttpPostedFileBase File { get; set; }
            // GET: /bookmark/
           
            public ActionResult Index()
            {
                var marks = bookObj.Images.Select(x => x);
                return View(marks);//must pass parameter to view in order to display information
            }

            public ActionResult Create()
            {
                return View();
            }
            [HttpPost]
            public ActionResult Create(Image upload, HttpPostedFileBase fileData)
            {

                if (fileData != null && fileData.ContentLength > 0)
                {
                    string file = fileData.FileName;
                    upload.fileData = file;
                    string filepath = Path.Combine(Server.MapPath("~/bookmarkFiles"), file);
                    fileData.SaveAs(filepath);
                }

                bookObj.Images.InsertOnSubmit(upload);
                bookObj.SubmitChanges();

                return View();
            }

            public ActionResult Edit(int Id)
            {
                var book = bookObj.Images.Single(x => x.Id == Id);
                return View(book);
            }
            [HttpPost]
            public ActionResult Edit(int Id, Image book)
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        var bookmark = bookObj.Images.Single(x => x.Id == Id);
                        UpdateModel(book);
                        bookObj.SubmitChanges();
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
            
            public ActionResult Delete(int Id)
            {
                var bmark = bookObj.Images.Single(x => x.Id == Id);
                return View(bmark);

            }

            [HttpPost]
            public ActionResult Delete(int Id, Image bmark)
            {
                try
                {
                    var marks = bookObj.Images.Single(x => x.Id == Id);
                    bookObj.Images.DeleteOnSubmit(marks);
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

