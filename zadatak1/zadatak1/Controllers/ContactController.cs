using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using zadatak1.Models;

namespace zadatak1.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public Contact[] Get()
        {
            return new Contact[]
            {
                new Contact
                {
                    Id = 1,
                    Name = "Glenn Block"
                },
                new Contact
                {
                    Id = 2,
                    Name = "Dan Roth"
                }

            };
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}