using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlobAccessApi.Models
{
    public class User
    {
        public String username { get; set; }

        public String emailid { get; set; }

        public String photo { get; set; }


    }
}