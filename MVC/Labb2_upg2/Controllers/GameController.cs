using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using Labb2_upg2.Models;

namespace Labb2_upg2.Controllers
{
    public class GameController : Controller
    {
        // GET: Game

        public ActionResult Index()
        {
            GameModel.ResetTile();
            return View();
        }

        [HttpPost]
        public ActionResult Index(string send)
        {
            try
            {
                if (send == "Reset Game")
                {
                    GameModel.ResetTile();
                }
                else
                {
                    ViewBag.Message = GameModel.RunGameLogic(send);
                }
                return View();
            }
            catch (Exception e)
            {
                ViewBag.Message = "Choose an empty space";
                return View();
            }
        }
    }
}