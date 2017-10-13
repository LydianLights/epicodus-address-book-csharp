using System;

namespace AddressBook.Models
{
    public class Address
    {
        private string _streetAddress;
        private string _city;
        private string _state;
        private string _zipCode;

        public Address(string streetAddress, string city, string state, string zipCode)
        {
            _streetAddress = streetAddress;
            _city = city;
            _state = state;
            _zipCode = zipCode;
        }

        public string GetStreetAddress()
        {
            return _streetAddress;
        }
        public string GetCity()
        {
            return _city;
        }
        public string GetState()
        {
            return _state;
        }
        public string GetZipCode()
        {
            return _zipCode;
        }
        public string GetFullCityAddress()
        {
            return $"{_city}, {_state} {_zipCode}";
        }
    }
}
