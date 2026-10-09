using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RestAPI_JQuery_Ajax__EF_CodeFirst.Models
{
    public class CustContext:DbContext
    {
        public CustContext() : base("myconn")
        {
        }
        public DbSet<Cust> Custs { get; set; }
    }
}