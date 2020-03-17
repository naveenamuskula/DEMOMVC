using DEMOMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DEMOMVC.Controllers
{
    public class VCController : Controller
    {
        // GET: VC
        public ActionResult Index()
        {
            Emp E = new Emp();
            return View(E);
        }
        //if we want to go to another view/page after clicking on submit btn(passing obj in Index.cshtml) 
        public ActionResult Display(Emp A)
       {
            return View(A);
        }

        public ActionResult Index1()
        {
            Emp E = new Emp();
            return View(E);
        }
        //overloaded method
        //if we want to go to another view/page after clicking on submit btn(without passing obj in Index1.cshtml)
        //after clicking on the button
        [HttpPost]
        public ActionResult Index1(Emp B)
        {
            return View("Display",B);
        }


        //using Unbound controls
        //HttpPost cannot be used  with Unbound controls
        public ActionResult Unbound()
        {
            return View();
        }
        public ActionResult ShowData()
        {
            Emp E = new Emp();
            E.Empno1 = int.Parse(Request.Form["txtempno"]);
            E.Ename1 = Request.Form["txtename"];
            E.Salary1 = double.Parse(Request.Form["txtsalary"]);
            return View(E);
        }
    }
}