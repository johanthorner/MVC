using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Labb4_Upg2.Models;

namespace Labb4_Upg2.Controllers
{
    public class GradesController : Controller
    {
        // GET: Grades
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult _Create2(int id)
        {

            Grade grade = new Grade() {StudentId = id};
            List<Grade> grades = ((Student) Session["Student"])grades.ToList();
            return PartialView(viewName:"_Create2", model: grade);

        }
        [HttpGet]
        public PartialViewResult _ViewList(int id)
        { // List<Grudge> grudges = ((Rabit) Session["Rabit"]).Grudge;

            var ListOfGrades = ((Student)Session["Student"]).Grades;
            ListOfGrades.Add(new Grade() {FinalGrade = "MVG", Subject = "MAth", StudentId = id});
            return PartialView(viewName: "_ViewList2", model: ListOfGrades);

        }


        [HttpPost]
        public string _Create2(int id, Grade model)
        {
            ((Student)Session["Student"]).Grades.Add(model);
            return "Grade Created";
        }
    }
}