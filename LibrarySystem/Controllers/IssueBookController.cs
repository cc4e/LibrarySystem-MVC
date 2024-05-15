using LibrarySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibrarySystem.Controllers
{
    public class IssueBookController : Controller
	{
		readonly LibraryEntities db = new LibraryEntities();

		public ActionResult Index()
		{
			return View();
		}
		[HttpGet]

		public ActionResult GetBook()
		{
			var Book = db.Books.Select(p => new
			{
				ID = p.id,

				bname = p.Bname

			}).ToList();
			return Json(Book, JsonRequestBehavior.AllowGet);
		}


		[HttpPost]
		public ActionResult GetMid(int mid)
        {
           var memberid = (from s in db.members where s.id == mid select s.name).ToList();
			return Json(memberid, JsonRequestBehavior.AllowGet);
        }



		[HttpPost]
		public ActionResult Save(issuebook issuebook)
		{
			if (ModelState.IsValid)
			{
				db.issuebooks.Add(issuebook);
				db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(issuebook);
		}



	}
}