using System.Collections.Generic;
using AddressBook.Models.ContactData;

namespace AddressBook.Models.PageData
{
    public class IndexModel
    {
        public List<Contact> Contacts {get; private set;}
        public Contact FocusedContact {get; private set;}
        public bool ContactAdded {get; set;}
        public bool ContactsCleared {get; set;}

        public IndexModel()
        {
            Contacts = Contact.GetAllInstances();
            FocusedContact = Contact.GetFocused();
            ContactAdded = false;
            ContactsCleared = false;
        }
    }
}
