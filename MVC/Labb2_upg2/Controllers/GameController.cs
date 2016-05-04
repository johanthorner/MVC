using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Labb2_upg2.Models;

namespace Labb2_upg2.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        [HttpGet]
        public ActionResult Index()
        {
            Tiles.TileCordinates = new List<Cordinate>()
            {
                new Cordinate() {ID = 1, sign = 'o'},
                new Cordinate() {ID = 2, sign = 'o'},
                new Cordinate() {ID = 3, sign = 'o'},
                new Cordinate() {ID = 4, sign = 'o'},
                new Cordinate() {ID = 5, sign = 'o'},
                new Cordinate() {ID = 6, sign = 'o'},
                new Cordinate() {ID = 7, sign = 'o'},
                new Cordinate() {ID = 8, sign = 'o'},
                new Cordinate() {ID = 9, sign = 'o'}
            };
            return View();
        }

        [HttpPost]
        public ActionResult Index(string value)
        {
            
            return View();
        }

    }
}