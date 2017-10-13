using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AddressBook.Models.ContactData;
using AddressBook.Models.PageData;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            IndexModel model = new IndexModel();
            return View(model);
        }

        [HttpGet("/contacts/add/success"), ActionName("Index")]
        public ActionResult ContactAddSuccess()
        {
            IndexModel model = new IndexModel();
            model.ContactAdded = true;
            return View(model);
        }

        [HttpGet("/contacts/clear/success"), ActionName("Index")]
        public ActionResult ContactsClearSuccess()
        {
            IndexModel model = new IndexModel();
            model.ContactsCleared = true;
            return View(model);
        }

        [HttpPost("/contacts/add")]
        public ActionResult AddContact()
        {
            string firstName = Request.Form["contact-first-name"];
            string lastName = Request.Form["contact-last-name"];
            string streetAddress = Request.Form["contact-street-address"];
            string city = Request.Form["contact-city"];
            string state = Request.Form["contact-state"];
            string zipCode = Request.Form["contact-zip-code"];
            string phoneNumber = Request.Form["contact-phone-number"];
            if (
                firstName != "" &&
                lastName != "" &&
                streetAddress != "" &&
                city != "" &&
                state != "" &&
                zipCode != "" &&
                phoneNumber != "")
            {
                Name contactName = new Name(firstName, lastName);
                PhoneNumber contactPhoneNumber = new PhoneNumber (phoneNumber);
                Address contactAddress = new Address(streetAddress, city, state, zipCode);
                Contact newContact = new Contact(contactName, contactPhoneNumber, contactAddress);
                return Redirect("/contacts/add/success");
            }
            return Redirect("/");
        }

        [HttpGet("/contacts/clear")]
        public ActionResult ClearContacts()
        {
            Contact.ClearAllInstances();
            return Redirect("/contacts/clear/success");
        }

        [HttpGet("/contacts/{id}")]
        public ActionResult ContactDetails(int id)
        {
            Contact.SelectById(id);
            return Redirect("/");
        }
    }
}
