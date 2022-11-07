using LAB_ASSIGNMENT_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LAB_ASSIGNMENT_02.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Register r)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(r);
        }
    }
}