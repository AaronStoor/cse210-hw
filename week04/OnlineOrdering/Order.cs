using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        this._products = products;
        this._customer = customer;
    }

    public double TotalCost()
    {
        double productTotal = 0;
        foreach (var product in _products)
        {
            productTotal += product.TotalCost();
        }

        double shippingCost = _customer.LivesInUSA() ? 5 : 35;
        return productTotal + shippingCost;
    }

    public string PackingLabel()
    {
        string label = "";
        foreach (var product in _products)
        {
            label += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return label.TrimEnd();
    }

    public string ShippingLabel()
    {
        return $"{_customer.Name}\n{_customer.Address.FullAddress()}";
    }
}