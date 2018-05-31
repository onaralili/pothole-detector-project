using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PotholeDetectorWebApp.Models;

namespace PotholeDetectorWebApp.Controllers
{
	public class HomeController : Controller
    {
		private WebAppContext db;
		public HomeController (WebAppContext context) {
			db = context;
		}
        public IActionResult Index()
        {
            return View();
        }

		public IActionResult Viewdata()
        {
			var potholes = db.Potholes.ToList();
			ViewData["Message"] = potholes;
            
            return View();
        }

		public IActionResult Heatmap()
        {
            return View();
        }

		[HttpGet]
		public IActionResult GetData(){
			var potholes = db.Potholes.ToList();
			return Json(potholes);
		}

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
