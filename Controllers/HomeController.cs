using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost("/contacts/add")]
        public ActionResult AddContact()
        {
            string name = Request.Form["contact-name"];
            if (name != "")
            {
                Contact newContact = new Contact(name);                
            }
            return Redirect("/");
        }
    }
}
