using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        this._streetAddress = streetAddress;
        this._city = city;
        this._stateOrProvince = stateOrProvince;
        this._country = country;
    }

    public bool IsInUSA()
    {
        return _country == "USA";
    }
    public string FullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateOrProvince}\n{_country}";
    }

    public string Country { get => _country; }
}