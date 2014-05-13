using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace fluffyUnicorns.Models
{
    public class fileUpload
    {
         //[Required, Microsoft.Web.Mvc.FileExtensions(Extensions = "csv",
         //    ErrorMessage = "Specify a CSV file. (Comma-separated values)")]
        public HttpPostedFileBase File { get; set; }
    }
}