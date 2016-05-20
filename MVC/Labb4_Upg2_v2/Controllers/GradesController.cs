using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Labb4_Upg2_v2.Models;

namespace Labb4_Upg2_v2.Controllers
{
    public class GradesController : Controller
    {
        // GET: Grades
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult _GradesForStudent(int id)
        {
            List<Grade> grades = ((Student) Session["Student"]).Grades;
            return PartialView(grades);
        }

        public PartialViewResult _Create(int id)
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult _Create(Grade model)
        {
            ((Student)Session["Student"]).Grades.Add(model);
            return RedirectToAction(actionName: "_GradesForStudent", routeValues: new {id = 9} );
        }
    }
}