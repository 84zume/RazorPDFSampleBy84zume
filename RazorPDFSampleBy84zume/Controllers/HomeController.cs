using RazorPDF;
using RazorPDFSampleBy84zume.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorPDFSampleBy84zume.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PersonPdf()
        {
            var person = new Person { Name = "Satoshi", Age = 24, Address = "Gifu" };

            var result = new PdfResult(person, "PersonPdf");
            result.ViewBag.Title = "Today's Member List";

            return result;
        }

        public ActionResult PeoplePdf()
        {
            var people = new List<Person> { 
                new Person{Name="Satoshi", Age=24, Address = "Gifu"},
                new Person{Name="Hanako", Age=23, Address = "Nagoya"},
                new Person{Name="Steve", Age=29, Address = "Osaka"},
                new Person{Name="Fu-ta", Age=25, Address = "Ishikawa"}
            };

            var result = new PdfResult(people, "PeoplePdf");
            result.ViewBag.Title = "Today's Member List";

            return result;
        }

    }
}
