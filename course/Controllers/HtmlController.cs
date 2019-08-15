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
        public ActionResult Form(FormCollection post_data)
        {
            var data = new Dictionary<string, string>();
            foreach (string key in post_data.Keys)
                data.Add(key.ToString(), post_data.GetValue(key).AttemptedValue);
            ViewData["postdata"] = data;
            return View();
        }


        public ActionResult HomeWork() => View();
        public ActionResult Test() => View();




    }
}