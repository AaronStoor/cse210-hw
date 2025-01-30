using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        this._name = name;
        this._address = address;
    }
    
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    public string Name{ get => _name; }
    public Address Address { get => _address; }
}