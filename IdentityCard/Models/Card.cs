using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace IdentityCard.Models
{
    public class Card
    {
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Photo { get; set; }
      //  public HttpPostedFileBased file { get; set; }
      //  public HttpPostedFile ImageFile { get; set; }
        public string Position { get; set; }
    }
}
