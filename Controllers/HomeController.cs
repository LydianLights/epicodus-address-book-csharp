using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;
using System.Collections.Generic;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            Dictionary<string, object> model = new Dictionary<string, object>{};
            model.Add("contacts", Contact.GetAllInstances());
            model.Add("focused-contact", Contact.GetFocused());
            return View(model);
        }

        [HttpPost("/contacts/add")]
        public ActionResult AddContact()
        {
            string firstName = Request.Form["contact-first-name"];
            string lastName = Request.Form["contact-last-name"];
            if (firstName != "" && lastName != "")
            {
                Name contactName = new Name(firstName, lastName);
                Contact newContact = new Contact(contactName);
            }
            return Redirect("/");
        }

        [HttpGet("/contacts/clear")]
        public ActionResult ClearContacts()
        {
            Contact.ClearAllInstances();
            return Redirect("/");
        }

        [HttpGet("/contacts/{id}")]
        public ActionResult ContactDetails(int id)
        {
            Contact.SelectById(id);
            return Redirect("/");
        }
    }
}
