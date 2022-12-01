using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiCho.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly] 
        public ActionResult Renderpartial() {

            return PartialView("_PartialNav");
        }
       
    }

}