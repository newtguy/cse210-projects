public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        this._name = name;
        this._address = address;
    }

    private string GetName() { return this._name; }
    private Address GetCustomerAddress() { return this._address; }

    public bool LivesInUSA()
    {
        return GetCustomerAddress().IsUSA();
    }

    public string GetCustomerInfoString()
    {
        return $"{GetName()}\n{GetCustomerAddress().GetAddressString()}";
    }
}