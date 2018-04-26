using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodiceFiscale.Models;
namespace CodiceFiscale.Controllers
{
	public class HomeController : Controller
	{
		DomainModel dm= new DomainModel();
		public ActionResult Index()
		{
			
			return View();
		}
		[HttpPost]
		public ActionResult Genera(string InsertCognome)
		{
			string D = dm.Cognome(InsertCognome);
			ViewBag.Cognome=D;
			return View("Contact");
		}
		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}