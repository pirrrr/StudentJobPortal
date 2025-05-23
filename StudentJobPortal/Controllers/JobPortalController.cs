using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentJobPortal.Controllers
{
    public class JobPortalController : Controller
    {
        // GET: JobPortal
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoginPage()
        {
            return View();
        }
        public ActionResult RegisterPage()
        {
            return View();
        }
        public ActionResult StudentDashboard()
        {
            return View();
        }

        public ActionResult EmployerDashboard()
        {
            return View();
        }
    }
}