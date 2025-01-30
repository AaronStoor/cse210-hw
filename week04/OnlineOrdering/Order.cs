using System;

public class Order()
{
    private List<Product> products;
    private Customer customer;

    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }

    public double TotalCost()
    {
        double productTotal = 0;
        foreach (var product in products)
        {
            productTotal += product.TotalCost();
        }

        double shippingCost = customer.LivesInUSA() ? 5 : 35;
        return productTotal + shippingCost;
    }

    public string PackingLabel()
    {
        string label = "";
        foreach (var product in products)
        {
            label += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return label.TrimEnd();
    }

    public string ShippingLabel()
    {
        return $"{customer.Name}\n{customer.Address.FullAddress()}";
    }
}