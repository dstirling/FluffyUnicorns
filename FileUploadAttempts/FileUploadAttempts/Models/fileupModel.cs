using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileUploadAttempts.Models
{
    public class fileupModel
    {
        public byte[] fileData { get; set; }

        public HttpPostedFileBase File { get; set; }
    }
}