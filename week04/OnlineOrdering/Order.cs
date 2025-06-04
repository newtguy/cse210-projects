public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        this._products = new List<Product>();
        this._customer = customer;
    }
    public Order(Customer customer, List<Product> products)
    {
        this._products = products;
        this._customer = customer;
    }

    private Customer GetCustomer() { return this._customer; }
    private List<Product> GetProducts() { return this._products; }

    private float CalculateTotalPrice()
    {
        float total = 0;

        //Product totals
        foreach (Product product in GetProducts())
        {
            total += product.CalculateProductPrice();
        }

        //Shipping Cost
        if (GetCustomer().LivesInUSA()) { total += 5; }
        else { total += 35; }

        return total;
    }

    private string GetPackingLabel()
    {
        string concat = "";
        foreach (Product product in GetProducts())
        {
            concat += product.DisplayProductInfo() + "\n";
        }
        return concat;
    }

    private string GetShippingLabel()
    {
        return GetCustomer().GetCustomerInfoString();
    }

    public string GetOrderString()
    {
        return $"{GetPackingLabel()}\n{GetShippingLabel()}\n\nTotal: ${CalculateTotalPrice()}";
    }
}