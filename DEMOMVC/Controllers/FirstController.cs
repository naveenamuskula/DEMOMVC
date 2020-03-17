using DEMOMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DEMOMVC.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            //tosend small data we use viewbag,
            ViewBag.str = "My First MVC Project";
            ViewData["str1"] = "my first project";
            TempData["str2"] = "Welcome";
            return View();//controller should always return view
        }
        public ActionResult SendObject()
        {
            
            Emp E = new Emp();
            E.Empno1 = 5;
            E.Ename1 = "ram";
            E.Salary1 = 50000;
            return View(E);//sending  single object from controller to view
        }
        public ActionResult SendObjects()
        {
            //to send multiple objects  using List from controller  to view
            List<Emp> L = new List<Emp>();
            Emp E = null;
            E = new Emp();
            E.Empno1 = 1;
            E.Ename1 = "naveena";
            E.Salary1 = 50000;
            L.Add(E);

            E = new Emp();
            E.Empno1 = 2;
            E.Ename1 = "pravs";
            E.Salary1 = 50000;
            L.Add(E);
            return View(L);
        }
        public ActionResult SendObjViewBag()
        {
            //to send single obj using viewbag,view data
            Emp E = null;
            E = new Emp();
            E.Empno1 = 1;
            E.Ename1 = "naveena";
            E.Salary1 = 50000;
            //ViewBag.p = E;
            ViewData["p"] = E;
            return View();

        }
        public ActionResult SendObjsVB()
        {
            //to send multiple objs using viewbag,viewdata
            List<Emp> L = new List<Emp>();
            Emp E = null;
            E = new Emp();
            E.Empno1 = 1;
            E.Ename1 = "naveena";
            E.Salary1 = 50000;
            L.Add(E);

            E = new Emp();
            E.Empno1 = 2;
            E.Ename1 = "pravs";
            E.Salary1 = 50000;
            L.Add(E);
            //ViewBag.P = L;
            ViewData["P"] = L;
            return View();

        }
    }
}