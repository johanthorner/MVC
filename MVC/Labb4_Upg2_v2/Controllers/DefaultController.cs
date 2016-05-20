using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Labb4_Upg2_v2.Models;

namespace Labb4_Upg2_v2.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Details()
        {
           Student student = new Student()
           {
               StudentId = 1,
               Adress = "Mr snuggles avn",
               Name = "Charlie",
               LastName = "Brown",
               PersonNumber = "19870223-1234",
               Grades = new List<Grade>()
               {
                   new Grade() {CourseName = "Math", Id = 1, FinalGrade = "F"}
               }
           };
            Session["Student"] = student;
            return View(student);
        }
    }
}