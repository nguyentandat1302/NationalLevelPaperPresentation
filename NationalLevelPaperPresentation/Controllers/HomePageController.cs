using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NationalLevelPaperPresentation.Controllers
{
    public class HomePageController : Controller
    {
        // GET: HomePage
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FooterPartial()
        {
            return PartialView();
        }
        public ActionResult Menu()
        {
            return PartialView();
        }
        public ActionResult LayoutNavbar()
        {
            return View();
        }
        public ActionResult NavBarDetail()
        {
            return PartialView();
        }
        public ActionResult one()
        {
            return PartialView();
        }
        public ActionResult two()
        {
            return PartialView();
        }
        public ActionResult three()
        {
            return PartialView();
        }
        public ActionResult Infor1() 
        {
            return PartialView();
        }
    }
}