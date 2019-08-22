using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using course.Models;
namespace course.Controllers
{
    public class TestController : Controller
    {
       
        [HttpGet]
        public ActionResult Index()
        {
            using (courseEntities1 db = new courseEntities1())
            {
                db.Company.ToList();

            }
            return Json(new { } , JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Index2(Company oCompany)
        {
            if (!ModelState.IsValid)
            {
                return new HttpNotFoundResult("optional description");
            }

            if (Request.IsAjaxRequest())
            {
                return Json(oCompany, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return View("index", oCompany);

            }
        }

     
    }
  
}