using System;
using System.Collections.Generic;

namespace AddressBook.Models
{
    public class Contact
    {
        private static List<Contact> _instances = new List<Contact>{};
        private static Contact _currentlyFocused = null;
        private string _name;
        private int _id;

        public Contact(string name)
        {
            _name = name;
            _id = _instances.Count;
            _instances.Add(this);
        }

        public string GetName()
        {
            return _name;
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
        public static Contact GetFocused()
        {
            return _currentlyFocused;
        }
    }
}
