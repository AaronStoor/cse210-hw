using System;

public class Product
{
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product(string name, int productId, double price, int quantity)
    {
        this._name = name;
        this._productId = productId;
        this._price = price;
        this._quantity = quantity;
    }

    public double TotalCost()
    {
        return _price * _quantity;
    }

    public string Name { get => _name; }
    public int ProductId { get => _productId; }
}