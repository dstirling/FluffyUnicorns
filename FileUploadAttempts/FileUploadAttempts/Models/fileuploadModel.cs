using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FileUploadAttempts.Models;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace FileUploadAttempts.Models
{
    public class fileuploadModel : uploadDataContext
    {

        public HttpPostedFileBase File { get; set; }

        public string fileName { get; set; }


        public byte fileData { get; set; }

    }
}
