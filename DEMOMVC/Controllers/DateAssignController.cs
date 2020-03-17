using DEMOMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DEMOMVC.Controllers
{
    public class DateAssignController : Controller
    {
        // GET: DateAssign
        static List<EMPDATA> L = null;
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ExtractDate()
        {
            DateTime sd = DateTime.Parse(Request.Form["txtstartdate"]);
            DateTime ed= DateTime.Parse(Request.Form["txtenddate"]);
            L = DBOperations.Empdate(sd, ed);
            ViewBag.S = L;
            return View("Index",L);
        }
    }
}