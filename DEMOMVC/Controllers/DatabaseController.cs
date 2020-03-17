using DEMOMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DEMOMVC.Controllers
{
    public class DatabaseController : Controller
    {
        static List<DEPTDATA> L1 = null;
        static List<EMPDATA> L2 = null;
        // GET: Database
        public ActionResult Index()
        {
            EMPDATA E = new EMPDATA();
            return View(E);
        }
        [HttpPost]
        public ActionResult Index(EMPDATA E)
        {
            ViewBag.msg=DBOperations.InsertEmp(E);
            return View();
        }
        public ActionResult getDeptData()
        {
            return View();
        }
        public  ActionResult GetDept()
        {
            int deptno = int.Parse(Request.Form["txtdeptno"]);
            //ViewBag.L = DBOperations.GetDept(deptno);
            List<EMPDATA> L1= DBOperations.GetDept(deptno);
            return View("getDeptData",L1);
        }
        public ActionResult GetDetails()
        {
            L1 = DBOperations.GetDetails();//L1 has dept data
            ViewBag.DL= L1;//viewbag.L will have deptdata(deptno,dname)
            return View();
        }
        public ActionResult SendDetails()
        {
            int deptno = int.Parse(Request.QueryString["d"]);//getting the  selected deptno from view and assigning to deptno
            ViewBag.DL = L1;//whenever we reload the page the values in viewbag will be lost,so to retain its value we are declaring the List as static above 
            ViewBag.S = deptno;
            List<EMPDATA> EL = DBOperations.GetDept(deptno);//fetch the empdata for selected deptno from DBOperations
            return View("GetDetails",EL);
        }
        public ActionResult GetEmp()
        {
            L2 = DBOperations.Emp();
            ViewBag.E = L2;
            return View();

        }
        
        public ActionResult DeleteEmp()
        {
            int empno = int.Parse(Request.Form["ddlEmpno"]);
            ViewBag.Emp=DBOperations.DelEmp(empno);
            ViewBag.E = DBOperations.Emp();
            return View("GetEmp");
        }
        
    }
}