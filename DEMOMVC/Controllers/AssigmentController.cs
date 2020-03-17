using DEMOMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DEMOMVC.Controllers
{
    public class AssigmentController : Controller
    {
        // GET: Assigment
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Extract()
        {
            int empno = int.Parse(Request.QueryString["e"]);//getting the empno from View (using addressbar)
            EMPDATA E = DBOperations.extractemp(empno);//empno will be passed to model and extract details
            return View("Index", E);//extracted emp details for the entered empno will be stored in E and passing it to view
            //and will be stored in EMPDATA of view
        }
        public ActionResult updatebtn(EMPDATA P)//the values in textboxes from View will be stored in P
        {
            int empno = int.Parse(Request.Form["EMPNO"]);
            string s = DBOperations.updatedata(empno, P);//it will go to model and update details and the updated emp details will be stored in "P object"
            ViewBag.msg = s;//s contains the msg to be display after updation
            return View("Index");
        }
    }
}