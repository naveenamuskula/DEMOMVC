using DEMOMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DEMOMVC.Controllers
{
    public class ValidationController : Controller
    {
        // GET: Validation
        public ActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Index(Validationscls1 V)
        //{
        //    return View();
        //}
        public ActionResult Getback(Validationscls1 V)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Addpage");
            }
            return View("Index");
        }
        public ActionResult Addpage()
        {
            return View();
        }
    }
}