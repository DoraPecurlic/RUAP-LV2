using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using zadatak1.Models;
using zadatak1.Services;
using System.Web.Http;
using System.Net.Http;

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

        public HttpResponseMessage Post(Contact contact)
        {
            this.contactRepository.SaveContact(contact);

            var response = Request.CreateResponse<Contact>(System.Net.HttpStatusCode.Created, contact);

            return response;
        }

    }
}