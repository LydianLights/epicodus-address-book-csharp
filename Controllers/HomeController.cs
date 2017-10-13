using Microsoft.AspNetCore.Mvc;
using AddressBook.Models.ContactData;
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
