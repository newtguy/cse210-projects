using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address bobAddress = new Address("111 Bob Street", "BobVille", "Utah", "USA");
        Customer bob = new Customer("Bob Smith", bobAddress);
        Product eggs = new Product("dozen eggs", "1234E", 3.33F, 2);
        Product chips = new Product("chips", "4321C", 1.00F, 6);
        Product soapBar = new Product("bar of soap", "2222B", .90F, 10);
        List<Product> bobProducts = new List<Product>();
        bobProducts.Add(eggs);
        bobProducts.Add(chips);
        bobProducts.Add(soapBar);

        Order bobOrder = new Order(bob, bobProducts);
        Console.WriteLine(bobOrder.GetOrderString());

        Address henryAddress = new Address("222 Henry Lane", "Henry Town", "Burgas", "Bulgaria");
        Customer henry = new Customer("Henry Hen", henryAddress);
        Product pickle = new Product("jar of pickles", "pck12", 5.11F, 1);
        Product bellPepper = new Product("bell pepper", "pep22", .80F, 99);
        Product tv = new Product("flatscreen TV", "9999T", 9999.99F, 1);
        List<Product> henryProducts = new List<Product>();
        henryProducts.Add(pickle);
        henryProducts.Add(bellPepper);
        henryProducts.Add(tv);

        Order henryOrder = new Order(henry, henryProducts);
        Console.WriteLine(henryOrder.GetOrderString());


    }
}