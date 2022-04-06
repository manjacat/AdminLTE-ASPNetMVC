using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLTE_ASPNetMVC.Controllers
{
    public class PagesController : Controller
    {
        // GET: Pages
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Icons()
        {
            return View();
        }

        public ActionResult Buttons()
        {
            return View();
        }

        public ActionResult Modals()
        {
            return View();
        }
    }
}