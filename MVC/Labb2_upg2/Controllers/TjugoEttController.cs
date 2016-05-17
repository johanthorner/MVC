using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Labb2_upg2.Models;

namespace Labb2_upg2.Controllers
{
    public class TjugoEttController : Controller
    {
        // GET: TjugoEtt
        public ActionResult Play()
        {
            ViewBag.result = string.Empty;
            // ViewBag.choice = 0;
            TjugoEttModels.CurrentNumber = 0;
            TjugoEttModels.SetStartPlayer();
            return View();
        }

        [HttpPost]
        public ActionResult Play(string buttonValue)
        {
            try
            {
                int choise = int.Parse(Request["choice"]);
                TjugoEttModels.CurrentNumber += choise;
                ViewBag.result = TjugoEttModels.HandleGameResults();
            }
            catch (Exception)
            {
                ViewBag.result = "Choose a value!";
              
            }
            return View();
           
            
        }
    }
}