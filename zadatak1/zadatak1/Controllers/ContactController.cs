using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace zadatak1.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public string[] Get()
        {
            return new string[]
            {
                "Hello",
                "World"
            };
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}