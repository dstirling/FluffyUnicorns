//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using System.IO;
//using System.ComponentModel;


//using FileUploadAttempts.Models;



//namespace FileUploadAttempts.Controllers
//{
//    public class fileUploadController : Controller
//    {
//        //
//        // GET: /fileUpload/


//        uploadDataContext objFile = new uploadDataContext();
//        //
//        // GET: /fileUpload/

//        public ActionResult Index()
//        {
//            var uploads = objFile.Images.Select(x => x);

//            return View(uploads);
//        }

//        public ActionResult FileUpload(HttpPostedFileBase File)
//        {

//            //making object from LINQ class
            
//            uploadDataContext dataContext = new uploadDataContext();
//            //loop through request file collection 
//            foreach (string upload in Request.Files) //Request.Files is a class 
//            {
//                //create byte array of size equal to file input stream
//                byte[] fileData = new byte[Request.Files[upload].InputStream.Length];
               
//                //add file input stream into byte array
//                Request.Files[upload].InputStream.Read(fileData, 0, Convert.ToInt32(Request.Files[upload].InputStream.Length));
               
//                //create system.data.linq object using byte array
//                System.Data.Linq.Binary binaryFile = new System.Data.Linq.Binary(fileData);
              
//                //initialise object of fileuploadModel LINQ to sql class passing values to be inserted
//                fileuploadModel uploads = new fileuploadModel { fileData = Convert.ToByte(binaryFile.ToArray()), fileName = Path.GetFileName(Request.Files[upload].FileName) };
//                //passing new object to entity
//                dataContext.Images.InsertOnSubmit(uploads);
//                ////call submitChanges method to execute implement changes into database
//                dataContext.SubmitChanges();
                
//            }
//            var returnData = dataContext.Images;
//            ViewData.Model = returnData.ToList();
//            return View();

//        }
//        //public FileContentResult FileDownload(int Id)
//        //{
//        //    //declare byte array to get file content from database and string to store file name
//        //    byte[] fileData;
//        //    string fileName;
//        //    //create object of LINQ to SQL class
//        //    uploadDataContext dataContext = new uploadDataContext();
//        //    //using LINQ expression to get record from database for given id value
//        //    var record = from Image in dataContext.Images
//        //                 where Image.Id == Id
//        //                 select Image;
//        //    //only one record will be returned from database as expression uses condtion on primary field
//        //    //so get first record from returned values and retrive file content (binary) and filename 
//        //    fileData = (byte[])record.First().fileData.ToArray();
//        //    fileName = record.First().fileName;
//        //    //return file and provide byte file content and file name
//        //    return File(fileData, "text", fileName);
//        //}
//    }
//}
