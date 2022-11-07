using ORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ORM.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            DB01Entities db01 = new DB01Entities();
            var data = db01.Students.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student s)
        {
            DB01Entities db = new DB01Entities();
            db.Students.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            DB01Entities db = new DB01Entities();
            var student = (from st in db.Students
                           where st.Id == id
                           select st
                           ).FirstOrDefault();
            return View(student);
        }
        [HttpPost]
        public ActionResult Edit(Student S)
        {
            using (DB01Entities db = new DB01Entities())
            {
                var entity = (from st in db.Students
                              where st.Id == S.Id
                              select st).FirstOrDefault();
                db.Entry(entity).CurrentValues.SetValues(S);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
        public ActionResult Delete(int id)
        {
            using (DB01Entities db = new DB01Entities())
            {
                Student s = (from st in db.Students
                              where st.Id == id
                              select st).FirstOrDefault();
                return View(s);
            }
        }
        [HttpPost]
        public ActionResult Delete(Student S)
        {
            using (DB01Entities db = new DB01Entities())
            {
                Student entity = (from st in db.Students
                              where st.Id == S.Id
                              select st).FirstOrDefault();
                db.Students.Remove(entity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}