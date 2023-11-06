using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using zadatak1.Models;
using zadatak1.Services;
using System.Web.Http;

namespace zadatak1.Controllers
{
    public class ContactController : ApiController
    {

        private ContactRepository contactRepository;

        public ContactController()
        {
            this.contactRepository = new ContactRepository();
        }
        // GET: Contact


        public Contact[] Get()
        {
            return this.contactRepository.GetAllContacts();
        }

    }
}