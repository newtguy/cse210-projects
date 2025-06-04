public class Address
{
    private string _address;
    private string _city;
    private string _state;
    private string _country;

    public Address(string address, string city, string state, string country)
    {
        this._address = address;
        this._city = city;
        this._state = state;
        this._country = country;
    }

    private string GetAddress() { return this._address; }
    private string GetCity() { return this._city; }
    private string GetState() { return this._state; }
    private string GetCountry() { return this._country; }

    public bool IsUSA()
    {
        if (GetCountry() == "USA") { return true; }
        else { return false; }
    }

    public string GetAddressString()
    {
        return $"{GetAddress()}\n{GetCity()}, {GetState()}\n{GetCountry()}";
    }
}