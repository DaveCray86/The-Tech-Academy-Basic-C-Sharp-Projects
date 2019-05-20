using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicAutoInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (BasicAutoEntities db = new BasicAutoEntities())
            {
                var quotes = (from x in db.Applicants where x.Total != null select x).ToList();
                var quoteList = new List<Applicant>();

                foreach (var quote in quotes)
                {
                    var quoted = new Applicant();
                    quoted.FirstName = quote.FirstName;
                    quoted.LastName = quote.LastName;
                    quoted.EmailAddress = quote.EmailAddress;
                    quoted.Total = quote.Total;
                    quoteList.Add(quoted);
                }
                return View(quoteList);
            }
        }
    }
}