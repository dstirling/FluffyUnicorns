using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;


using FileUploadAttempts.Models;

namespace FileUploadAttempts.Controllers
{
    public class fileController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(fileupModel File)
        {
            uploadDataContext dataContext = new uploadDataContext();
//                
            byte[] fileData;

            if (Request.Files["files"] != null)
            {
                using (var binaryReader = new BinaryReader(Request.Files["File"].InputStream))
                {
                    fileData = binaryReader.ReadBytes(Request.Files["File"].ContentLength);
                }

                //dataContext.Images.SaveAs(); 
                File.fileData = fileData;
                //dataContext.Images.InsertOnSubmit();
                //dataContext.SubmitChanges();
              
            }
            return RedirectToAction("Index");
        }

    }
}
