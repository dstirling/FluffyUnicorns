using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;


using FileUploadAttempts.Models;



namespace FileUploadAttempts.Controllers
{
    public class newController : Controller
    {
        //
        // GET: /new/
         uploadDataContext dataContext = new uploadDataContext();
         public ActionResult Index()
         {
             return View();
         }
        public ActionResult fileUploader()
        {
            return View();
        }
        [HttpPost]
        public ActionResult fileUploader(Image upload, HttpPostedFileBase fileData)
        {

            if (fileData !=null && fileData.ContentLength > 0)
            {
                string file = fileData.FileName;
                upload.fileData = file;
                string filepath = Path.Combine(Server.MapPath("~/Folder"), file);
                fileData.SaveAs(filepath);
            }

            dataContext.Images.InsertOnSubmit(upload);
            dataContext.SubmitChanges();

            return View();
        }

    }
}
