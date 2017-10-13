using System;

namespace AddressBook.Models
{
    public class Name
    {
        private string _first;
        private string _last;

        public Name(string first, string last)
        {
            _first = first;
            _last = last;
        }

        public string GetFirst()
        {
            return _first;
        }
        public string GetLast()
        {
            return _last;
        }
        public string GetFull()
        {
            return _first + " " + _last;
        }
    }
}
