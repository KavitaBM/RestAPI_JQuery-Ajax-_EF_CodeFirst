using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RestAPI_JQuery_Ajax__EF_CodeFirst.Models
{
    public class Cust
    {
        [Key]
        public int CustId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
    }
}