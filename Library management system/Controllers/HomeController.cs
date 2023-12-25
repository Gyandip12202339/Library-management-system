using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library_management_system.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult AddBooks()
        {
            return View();
        }

        public ActionResult AddStudents()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult completeBooksDetails()

        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Form()

        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult IssueBooks()

        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Form1()

        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult issueBooks()

        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}