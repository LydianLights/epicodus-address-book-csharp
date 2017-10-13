using System;
using System.Collections.Generic;

namespace AddressBook.Models.ContactData
{
    public class Contact
    {
        private static List<Contact> _instances = new List<Contact>{};
        private static Contact _currentlyFocused = null;
        private Name _name;
        private PhoneNumber _phoneNumber;
        private Address _address;
        private int _id;

        public Contact(Name name, PhoneNumber phoneNumber, Address address)
        {
            _name = name;
            _phoneNumber = phoneNumber;
            _address = address;
            _id = _instances.Count;
            _instances.Add(this);
        }

        public Name GetName()
        {
            return _name;
        }
        public PhoneNumber GetPhoneNumber()
        {
            return _phoneNumber;
        }
        public Address GetAddress()
        {
            return _address;
        }
        public int GetId()
        {
            return _id;
        }

        public static Contact FindById(int id)
        {
            return _instances[id];
        }
        public static Contact SelectById(int id)
        {
            _currentlyFocused = _instances[id];
            return _currentlyFocused;
        }
        public static List<Contact> GetAllInstances()
        {
            return _instances;
        }
        public static void ClearAllInstances()
        {
            _currentlyFocused = null;
            _instances.Clear();
        }
        public static Contact GetFocused()
        {
            return _currentlyFocused;
        }
    }
}
