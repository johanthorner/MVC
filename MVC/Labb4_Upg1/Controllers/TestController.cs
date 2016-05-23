using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Labb4_Upg1.Models;

namespace Labb4_Upg1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        
        public ActionResult Index()
        {
         
            return View();
        }
     
      
        public ActionResult Details()
        {

            return View();
        }

        public PartialViewResult _Result()
        {
          return PartialView();
        }

    }
}