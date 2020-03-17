using DEMOMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DEMOMVC.Controllers
{
    public class Radio2Controller : Controller
    {
        // GET: Radio2
        List<EMPDATA> l = null;
        public ActionResult Index()
        {
            l = DBOperations.Emp();
            return View(l);
        }
        public ActionResult Submitbtn()
        {
            int empno = Convert.ToInt32(Request.Form["rdb"]);
            //int empno=int.Parse((Request.Form["rdb"]).ToString());
            //int empno = Convert.ToInt32(Request.QueryString["rdb"]);
            EMPDATA l = DBOperations.Display(empno);
            return View(l);
        }
    }
}