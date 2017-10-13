using System;

namespace AddressBook.Models.ContactData
{
    public class PhoneNumber
    {
        private string _number;

        public PhoneNumber(string number)
        {
            _number = number;
        }

        public string GetAsString()
        {
            return _number;
        }
    }
}
