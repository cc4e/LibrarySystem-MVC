using LibrarySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibrarySystem.Controllers
{
	public class LoginController : Controller
	{
		readonly LibraryEntities db = new LibraryEntities();

		// GET: Login
		public ActionResult Index()
		{
			ViewBag.HideNavbar = true; 
			return View();
		}

		[HttpPost]
		public ActionResult Index(Login log)
		{
			var user = db.Logins.Where(x => x.UserName == log.UserName && x.Password == log.Password).Count();
			if (user > 0)
			{
				return RedirectToAction("Index", "Home");
			}
			else
			{
				return View();
			}
		}
	}
}
