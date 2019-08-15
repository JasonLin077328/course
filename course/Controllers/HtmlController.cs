using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace course.Controllers
{
    public class HtmlController : Controller
    {
        public ActionResult Index() => View();
        public ActionResult Structure() => View();
        public ActionResult Attribute() => View();
        public ActionResult Header() => View();
        public ActionResult Body() => View();
        public ActionResult Paragraph() => View();
        [HttpGet]
        public ActionResult Form() => View();
        [HttpPost]
        public ActionResult Form(Dictionary<string, string> data)
        {
            ViewData["postdata"] = data;
            return View();
        }


        public ActionResult HomeWork() => View();


    }
}