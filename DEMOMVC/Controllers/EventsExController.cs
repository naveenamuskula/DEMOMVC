using DEMOMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DEMOMVC.Controllers
{
    public class EventsExController : Controller
    {
        // GET: EventsEx
        //step1
        //retrieve all empdata
        public ActionResult Index()
        {
            ViewBag.EL = DBOperations.Emp();
            return View();
        }
        public ActionResult DelEmpOn()
        {
            int eno = int.Parse(Request.QueryString["e"]);
            ViewBag.msg = DBOperations.DelEmp(eno);
            ViewBag.EL = DBOperations.Emp();//after deleting the record ,the refreshed data will be displayed(with 1 record less)
            return View("Index");
        }
    }
}