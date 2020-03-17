using DEMOMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DEMOMVC.Controllers
{
    public class EventsEx2Controller : Controller
    {
        // GET: EventsEx2
        public ActionResult Index()
        {
            ViewBag.EL = DBOperations.Emp();
            return View();
        }
        public ActionResult DelEmpbtn()
        {
            int eno = int.Parse(Request.Form["ddlempno"]);
            ViewBag.msg = DBOperations.DelEmp(eno);
            ViewBag.EL = DBOperations.Emp();
            return View("Index");
        }
    }
}