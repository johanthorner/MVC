using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Labb4_Upg2.Models;

namespace Labb4_Upg2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details()
        {
            Student student = new Student() {ID = 1, Name = "Johan Thörner"};
            student.Grades.Add(new Grade() {FinalGrade = "Vg", Subject = "Programming", StudentId = 1});
            Session["Student"] = student;
            return View(student);
        }

        public ActionResult GetGradesCreate(int id)
        {
            return RedirectToAction(
                actionName: "_Create2",
                controllerName: "Grades",
                routeValues: new {id});
        }
        public ActionResult SeeListOfGrades(int id)
        {
            return RedirectToAction(
                actionName: "_ViewList",
                controllerName: "Grades",
                routeValues: new { id });
        }
    }
}