using System;
using System.Collections.Generic;

namespace AddressBook.Modeels
{
    public class Contact
    {
        private static List<Contact> _instances = new List<Contact>{};
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
        public static List<Contact> GetAllInstances()
        {
            return _instances;
        }
    }
}
