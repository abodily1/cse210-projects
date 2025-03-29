using System;

class Product
{
    private string _name = "";
    private string _productId = "";
    private double _price = 0.00;
    private int _quantity = 0;
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity; 
    }
    public double CostOfProduct()
    {
        double cost = _price * _quantity;
        return cost;
    }
    public string GetPackingLabel()
    {
        string label = $" Name: {_name}, ProductID: {_productId}";        
        return label;
    }
}