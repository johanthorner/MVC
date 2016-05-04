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
            Tiles.TileCordinates = new List<Cordinate>()
            {
                new Cordinate() {ID = 1, sign = '1', DisableButton = false},
                new Cordinate() {ID = 2, sign = '2', DisableButton = false},
                new Cordinate() {ID = 3, sign = '3', DisableButton = false},
                new Cordinate() {ID = 4, sign = '4', DisableButton = false},
                new Cordinate() {ID = 5, sign = '5', DisableButton = false},
                new Cordinate() {ID = 6, sign = '6', DisableButton = false},
                new Cordinate() {ID = 7, sign = '7', DisableButton = false},
                new Cordinate() {ID = 8, sign = '8', DisableButton = false},
                new Cordinate() {ID = 9, sign = '9', DisableButton = false}
            };
            return View();
        }

        [HttpPost]
        public ActionResult Index(string send)
        {

            for (int i = 0; i < Tiles.TileCordinates.Count; i++)
            {
                if (Tiles.TileCordinates[i].ID == int.Parse(send))
                {
                    Tiles.TileCordinates[i].sign = 'X';
                }
            }

            ViewBag.Message = Tiles.TileCordinates[0];
            ViewBag.Message = GameModel.CheckForWinner('X');

            for (int i = 0; i < Tiles.TileCordinates.Count; i++)
            {
                if (Tiles.TileCordinates[i].ID == GameModel.ComputerPlay())
                {
                    Tiles.TileCordinates[i].sign = 'o';
                }
            }
            ViewBag.Message = GameModel.CheckForWinner('o');

            return View();
        }
    }
}