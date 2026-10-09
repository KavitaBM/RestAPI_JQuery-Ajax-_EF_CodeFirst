using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestAPI_JQuery_Ajax__EF_CodeFirst.Models;

namespace RestAPI_JQuery_Ajax__EF_CodeFirst.Controllers
{
    public class CustomerController : ApiController
    {
        public List<Cust> Get()
        {
            CustContext db = new CustContext();
            List<Cust> customers = db.Custs.ToList();
            return customers;
        }
    }
}
