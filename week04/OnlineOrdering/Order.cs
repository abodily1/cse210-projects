using System;

class Order
{   
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    public Order(string name, string address, string city, string state, string country)
    {
        _customer = new Customer(name, address, city, state, country);
    }
    public double ComputeCost()
    {
        double totalCost = 0.00;

        foreach ( Product product in _products)
        {
            product.CostOfProduct();
            totalCost += product.CostOfProduct();
        }

        if (_customer.LocationUSA())
        {
            totalCost += 5.00;
        }
        else
        {
            totalCost += 35.00; 
        } 

        return totalCost;
    }
    public void GetPackingLabel()
    {
        List<string> label = new List<string>();

        foreach ( Product product in _products)
        {
           Console.WriteLine(product.GetPackingLabel());
        }
    }
    public void GetShippingLabel()
    {
        Console.WriteLine(_customer.GetName());
        Console.WriteLine(_customer.GetAddress());
    }
    public void AddProduct(string name, string productId, double price, int quantity)
    {
        Product product = new Product(name, productId, price, quantity);
        _products.Add(product);
    }    
}