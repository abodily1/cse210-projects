using System;

class Customer
{
    private string _name = "";
    private Address _address ;
    public Customer(string name, string address, string city, string state, string country)
    {
        _name = name;
        _address = new Address(address, city, state, country);
    }
    public bool LocationUSA()
    {
        return _address.IsCountryUSA();
    }
    public string GetName()
    {
        return _name;
    }
        public string GetAddress()
    {
        return _address.GetAddress();
    }
}