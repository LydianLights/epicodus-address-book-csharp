using System;

namespace AddressBook.Models
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
