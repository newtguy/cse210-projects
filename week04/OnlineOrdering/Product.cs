public class Product
{
    private string _name;
    private string _productID;
    private float _price;
    private int _quantity;

    public Product(string name, string id, float price, int quantity)
    {
        this._name = name;
        this._productID = id;
        this._price = price;
        this._quantity = quantity;
    }

    private string GetName() { return this._name; }
    private string GetProductID() { return this._productID; }
    private float GetPrice() { return this._price; }
    private int GetQuantity() { return this._quantity; }

    public float CalculateProductPrice()
    {
        return GetPrice() * GetQuantity();
    }

    public string DisplayProductInfo()
    {
        return $"{GetName()} ({GetProductID()}) {GetQuantity()} @ ${GetPrice()}";
    }
}