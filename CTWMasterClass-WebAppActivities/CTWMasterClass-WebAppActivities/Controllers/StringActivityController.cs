using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CTWMasterClass_WebAppActivities.Controllers
{
    public class StringActivityController : Controller
    {
        public ActionResult Index()
        {
            return View(viewName: "Index", model: "All starts here.");
        }
        [HttpPost]
        public ActionResult SayHello(string inputString)
        {
            return View(viewName: "Index", model: "Hello " + inputString);
        }
        public ActionResult StringLength(string inputString)
        {
            return View(viewName: "Index", model: "Your Name is "+inputString.Length+" letters long");
        }
        public ActionResult DifferenceBetweenNameAndAge(string inputName, int inputAge)
        {
            int abValue = Math.Abs((inputName.Length)-inputAge);
            return View(viewName: "Index", model:"The absoluet diffenrece between the last name and your age is "+abValue);
        }

    }
}